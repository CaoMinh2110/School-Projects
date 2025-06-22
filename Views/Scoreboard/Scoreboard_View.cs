using BTL.CustomControls;
using BTL.Data;
using BTL.Models;
using FontAwesome.Sharp;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace BTL.Views.Scoreboard
{
    [ToolboxItem(false)]
    public partial class Scoreboard_View : UserControl
    {
        public Scoreboard_View()
        {
            InitializeComponent();
            cmb_Course.DisplayMember = "CourseName";
            cmb_Course.ValueMember = "CourseID";
            cmb_Course.DataSource = Course_Repository.GetAll();

            cmb_Class.DisplayMember = "ClassName";
            cmb_Class.ValueMember = "ClassID";

            IconPictureBox lopIcon = new IconPictureBox()
            {
                Dock = DockStyle.Right,
                Height = txtSearch.Width - txtSearch.Padding.Top * 2,
                IconChar = IconChar.Search,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                IconColor = txtSearch.BorderColor,
            };
            lopIcon.Click += (sen, ev) =>
            {
                TxtSearch_KeyDown(null, new KeyEventArgs(Keys.Enter));
            };
            txtSearch.Controls.Add(lopIcon);
        }

        public async void DisplayList(string condition = "")
        {
            try
            {
                pnlList.Controls.Clear();
                if (!int.TryParse(cmb_Class.SelectedValue.ToString(), out int classID)) return;
                var list = await Enroll_Repository.GetClassAsync(classID, condition);
                await Task.Run(() =>
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Scoreboard_Row item = new(list[i])
                        {
                            STT = i + 1,
                            Tag = i
                        };
                        SetDoubleBuffer(item);
                        this.Invoke((System.Windows.Forms.MethodInvoker)delegate
                        {
                            pnlList.Controls.Add(item);
                            pnlList.Controls.SetChildIndex(item, 0);
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetTable()
        {
            pnlProcessScore.ColumnCount = 0;
            pnlProcessScore.Controls.Clear();
            if (!int.TryParse(cmb_Class.SelectedValue.ToString(), out int ClassID)) return;
            DataTable dt = Class_Repository.GetAssType(ClassID);
            if (dt.Rows.Count == 0) return;
            while (dt.Rows.Count > pnlProcessScore.ColumnCount)
            {
                pnlProcessScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, pnlProcessScore.Width / dt.Rows.Count));
                pnlProcessScore.ColumnCount++;
            }
            pnlProcessScore.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, pnlProcessScore.Width / dt.Rows.Count);
            for (int i = 0; i < pnlProcessScore.ColumnCount; i++)
            {
                Label l = new()
                {
                    BackColor = Color.Silver,
                    Text = dt.Rows[i][1].ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0, 0, 1, 0)
                };
                if (i == pnlProcessScore.ColumnCount - 1) l.Margin = new Padding(0);
                pnlProcessScore.Controls.Add(l, i, 0);
            }
        }

        private void PnlList_SizeChanged(object sender, EventArgs e)
        {
            if (pnlScroll.VerticalScroll.Visible)
                pnlList.Padding = new Padding(15, 0, 0, 0);
            else
                pnlList.Padding = new Padding(15, 0, 22, 0);
            splitContainer3.SplitterDistance = 100;
        }

        private void CmbCourse_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Class.DataSource = Class_Repository.GetByCourseID(int.Parse(cmb_Course.SelectedValue.ToString()));
            cmb_Class.Texts = "";
            pnlList.Controls.Clear();
        }

        private void CmbClass_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Texts = string.Empty;
            SetTable();
            DisplayList();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (pnlList.Controls.Count != 0)
                if (MessageBox.Show("Bạn có chắc chắn với thông tin mình nhập, dữ liệu sẽ thay đổi sau khi lưu và không thể lấy lại", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    foreach (Scoreboard_Row row in pnlList.Controls)
                    {
                        row.Executed();
                    }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.BackColor = Color.White;
            ((IconPictureBox)txtSearch.Controls[1]).IconColor = Color.FromArgb(27, 90, 255);
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.BackColor = Color.LightGray;
            ((IconPictureBox)txtSearch.Controls[1]).IconColor = Color.Gray;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtSearch.Texts.IsNullOrEmpty())
            {
                e.SuppressKeyPress = true;
                DisplayList(txtSearch.Texts.Trim());
            }
        }

        #region Smooth Appeatance
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        static void SetDoubleBuffer(Control ctl)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctl, [true]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Control control in ctl.Controls)
                SetDoubleBuffer(control);
        }

        #endregion
    }

    [ToolboxItem(false)]
    public partial class Scoreboard_Row : Panel
    {
        Enroll item;
        int PointToPass = 0;
        int MaxAllowedAbsences = 1;

        public int STT { get => int.Parse(lbl_STT.Text); set => lbl_STT.Text = value.ToString(); }

        public Enroll Item
        {
            get => item;
            set
            {
                item = value;
                DataRow dr = Enroll_Repository.GetClassDetail(item.ClassID, item.StudentID).Rows[0];
                lbl_FirstName.Text = dr["FirstName"].ToString();
                lbl_LastName.Text = dr["LastName"].ToString();
                lbl_Code.Text = dr["StudentCode"].ToString();
                lbl_Gender.Text = dr["Gender"].ToString();
                lbl_ExamsTimes.Text = item.ExamsTimes.ToString();
                lbl_ExamsNo.Text = item.ExamsNo.ToString();
                txt_ExamsPoint.Texts = item.ExamsPoint.ToString();
                txt_Absences.Texts = item.Absences.ToString();
                PointToPass = int.Parse(dr["PointToPass"].ToString());
                MaxAllowedAbsences = int.Parse(dr["MaxAllowedAbsences"].ToString());
                UpdatePoint();
            }
        }

        public void UpdatePoint()
        {
            //Chuyên cần
            float AttendancePoint = float.Parse(txt_Absences.Texts.ToString()) / (float)MaxAllowedAbsences * 100;
            if (AttendancePoint > 100) icn_ExamAllowed.IconChar = IconChar.XmarkCircle;
            else icn_ExamAllowed.IconChar = IconChar.CheckCircle;
            if (AttendancePoint >= 100) lbl_AttendancePoint.Text = "0";
            else if (AttendancePoint >= 70) lbl_AttendancePoint.Text = "2";
            else if (AttendancePoint >= 40) lbl_AttendancePoint.Text = "4";
            else if (AttendancePoint >= 20) lbl_AttendancePoint.Text = "6";
            else if (AttendancePoint > 0) lbl_AttendancePoint.Text = "8";
            else lbl_AttendancePoint.Text = "10";

            //Điểm tổng kết
            float diemChuyenCan = float.Parse(lbl_AttendancePoint.Text) * 10;
            float diemQuaTrinh = GetDiemQuaTrinh() * 30;
            float diemThi = float.Parse(txt_ExamsPoint.Texts) * 60;
            decimal totalPoint = (decimal)((diemChuyenCan + diemQuaTrinh + diemThi) / 100);
            lbl_TotalPoint.Text = Math.Round(totalPoint, 2).ToString();
            if (totalPoint >= PointToPass && icn_ExamAllowed.IconChar == IconChar.CheckCircle)
                icn_Pass.IconChar = IconChar.CheckCircle;
            else icn_Pass.IconChar = IconChar.XmarkCircle;
        }

        public float GetDiemQuaTrinh()
        {
            float sumValue = 0;
            float sumPercent = 0;
            foreach (CustomTextBox txt in pnlAssType.Controls)
            {
                int AssTypeID = int.Parse(txt.Tag.ToString());
                int StudentID = item.StudentID;
                float percent = float.Parse(AssessmentType_Repository.GetByID(AssTypeID).Rows[0]["WeightPercentage"].ToString());
                float point = float.Parse(txt.Texts);
                sumValue += point * percent;
                sumPercent += percent;
            }

            if (sumPercent != 0) return sumValue / sumPercent;
            else return sumValue;
        }

        public void Executed()
        {
            Enroll_Repository.EditAbsences(new Enroll(item.StudentID, item.ClassID, int.Parse(txt_Absences.Texts)));

            foreach (CustomTextBox txt in pnlAssType.Controls)
            {
                Score score = new(0, item.StudentID, int.Parse(txt.Tag.ToString()), int.Parse(txt.Texts));
                Score_Repository.Edit(score);
            }
            if (Properties.Settings.Default.ExamsAllowed)
            {
                Enroll_Repository.EditExamsPoint(new Enroll(item.StudentID, item.ClassID, float.Parse(txt_ExamsPoint.Texts)));
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_ValueSet(object sender, EventArgs e)
        {
            CustomTextBox txt = (CustomTextBox)sender;
            txt.Texts = txt.Texts.TrimStart('0');
            if (txt.Texts.IsNullOrEmpty()) txt.Texts = "0";
            else if (float.Parse(txt.Texts) > txt.TabIndex) txt.Texts = txt.TabIndex.ToString();
            UpdatePoint();
        }

        public Scoreboard_Row(Enroll item)
        {
            Item = item;

            #region InitializeComponent
            SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlStudentInfor.SuspendLayout();
            pnlAssType.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();

            pnlStudentInfor.ForeColor = Color.FromArgb(64, 64, 64);
            pnlStudentInfor.ColumnCount = 5;
            pnlStudentInfor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            pnlStudentInfor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            pnlStudentInfor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlStudentInfor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            pnlStudentInfor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            pnlStudentInfor.Controls.Add(lbl_Gender, 4, 0);
            pnlStudentInfor.Controls.Add(lbl_FirstName, 3, 0);
            pnlStudentInfor.Controls.Add(lbl_LastName, 2, 0);
            pnlStudentInfor.Controls.Add(lbl_Code, 1, 0);
            pnlStudentInfor.Controls.Add(lbl_STT, 0, 0);
            pnlStudentInfor.Dock = DockStyle.Fill;
            pnlStudentInfor.Margin = new Padding(0);
            pnlStudentInfor.RowCount = 1;
            pnlStudentInfor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            foreach (Label label in pnlStudentInfor.Controls)
            {
                label.BackColor = Color.White;
                label.Dock = DockStyle.Fill;
                label.Margin = new Padding((0));
                label.TextAlign = ContentAlignment.MiddleLeft;
            }
            lbl_STT.TextAlign = ContentAlignment.MiddleCenter;

            pnlAssType.Dock = DockStyle.Fill;
            pnlAssType.Margin = new Padding((0));
            pnlAssType.RowCount = 1;
            pnlAssType.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            DataTable listAssType = Class_Repository.GetAssType(item.ClassID);
            if (listAssType.Rows.Count != 0)
            {
                while (listAssType.Rows.Count > pnlAssType.ColumnCount)
                {
                    pnlAssType.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, pnlAssType.Width / listAssType.Rows.Count));
                    pnlAssType.ColumnCount++;
                }
                for (int i = 0; i < pnlAssType.ColumnCount; i++)
                {
                    DataRow score = Score_Repository.GetScoreByAssTypeAndStudent((int)listAssType.Rows[i][0], item.StudentID).Rows[0];
                    CustomTextBox txt = new()
                    {
                        BackColor = Color.Wheat,
                        BorderColor = Color.White,
                        BorderFocusColor = Color.FromArgb(27, 90, 255),
                        BorderSize = 2,
                        BorderRadius = 8,
                        Tag = listAssType.Rows[i][0],
                        Texts = score["ScoreValue"].ToString().IsNullOrEmpty() ? "0" : score["ScoreValue"].ToString(),
                        TabIndex = 10,
                        TabStop = false,
                        TextAlign = HorizontalAlignment.Center,
                        Dock = DockStyle.Fill,
                        ForeColor = Color.FromArgb(64, 64, 64),
                        PlaceholderColor = Color.FromArgb(64, 64, 64)
                    };

                    txt.Leave += Txt_ValueSet;
                    txt.KeyPress += txt_KeyPress;
                    pnlAssType.Controls.Add(txt, i, 0);
                }
            }
            pnlAssType.SizeChanged += (sen, ev) =>
            {
                int width = (pnlAssType.Width / pnlAssType.ColumnCount - 74) / 2;
                foreach (Control control in pnlAssType.Controls)
                    control.Margin = new Padding(width, 8, width, 8);
            };

            pnlContainer.BackColor = Color.White;
            pnlContainer.ColumnCount = 10;
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 550F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            pnlContainer.Controls.Add(panel2, 9, 0);
            pnlContainer.Controls.Add(lbl_TotalPoint, 8, 0);
            pnlContainer.Controls.Add(txt_ExamsPoint, 7, 0);
            pnlContainer.Controls.Add(lbl_ExamsNo, 6, 0);
            pnlContainer.Controls.Add(lbl_ExamsTimes, 5, 0);
            pnlContainer.Controls.Add(panel1, 4, 0);
            pnlContainer.Controls.Add(pnlAssType, 3, 0);
            pnlContainer.Controls.Add(lbl_AttendancePoint, 2, 0);
            pnlContainer.Controls.Add(txt_Absences, 1, 0);
            pnlContainer.Controls.Add(pnlStudentInfor, 0, 0);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.ForeColor = Color.FromArgb(64, 64, 64);
            pnlContainer.RowCount = 1;
            pnlContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            foreach (Control control in pnlContainer.Controls)
            {
                if (control is CustomTextBox txt)
                {
                    txt.BackColor = Color.Wheat;
                    txt.BorderColor = Color.White;
                    txt.ForeColor = Color.FromArgb(64, 64, 64);
                    txt.PlaceholderColor = Color.FromArgb(64, 64, 64);
                    txt.BorderFocusColor = Color.FromArgb(27, 90, 255);
                    txt.BorderSize = 2;
                    txt.BorderRadius = 8;
                    txt.Margin = new Padding(8, 8, 8, 8);
                    txt.TextAlign = HorizontalAlignment.Center;
                    txt.TabIndex = 10;
                    txt.TabStop = false;
                    txt.Dock = DockStyle.Fill;
                    txt.Leave += Txt_ValueSet;
                    txt.KeyPress += txt_KeyPress;
                }
                if (control is Label lbl)
                {
                    lbl.Dock = DockStyle.Fill;
                    lbl.Margin = new Padding((0));
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
            txt_Absences.TabIndex = 10000;

            panel1.BackColor = panel2.BackColor = Color.White;
            panel1.Dock = panel2.Dock = DockStyle.Fill;
            panel1.Padding = panel2.Padding = new Padding(7);

            panel1.Controls.Add(icn_ExamAllowed);
            panel2.Controls.Add(icn_Pass);

            icn_Pass.BackColor = icn_ExamAllowed.BackColor = Color.Transparent;
            icn_Pass.Dock = icn_ExamAllowed.Dock = DockStyle.Fill;
            icn_Pass.IconChar = icn_ExamAllowed.IconChar = IconChar.CheckCircle;

            this.BackColor = Color.Gray;
            this.Dock = DockStyle.Top;
            this.Size = new Size(777, 50);
            this.Padding = new Padding(0, 0, 0, 2);
            this.Controls.Add(pnlContainer);

            PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlAssType.ResumeLayout(false);
            pnlStudentInfor.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            ResumeLayout(false);

            #endregion

            UpdatePoint();
        }

        //Components
        private TableLayoutPanel pnlContainer = new();
        private TableLayoutPanel pnlStudentInfor = new();
        private TableLayoutPanel pnlAssType = new();
        private Label lbl_STT = new();
        private Label lbl_Code = new();
        private Label lbl_LastName = new();
        private Label lbl_FirstName = new();
        private Label lbl_Gender = new();

        private Panel panel1 = new();
        private Panel panel2 = new();
        private IconPictureBox icn_ExamAllowed = new();
        private IconPictureBox icn_Pass = new();
        private CustomTextBox txt_ExamsPoint = new();
        private CustomTextBox txt_Absences = new();
        private Label lbl_AttendancePoint = new();
        private Label lbl_ExamsTimes = new();
        private Label lbl_ExamsNo = new();
        private Label lbl_TotalPoint = new();
    }
}
