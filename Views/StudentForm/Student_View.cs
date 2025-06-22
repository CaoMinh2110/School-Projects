using BTL.CustomControls;
using BTL.Data;
using BTL.Models;
using BTL.Views.StudentForm;
using FontAwesome.Sharp;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace BTL.Views
{
    [ToolboxItem(false)]
    public partial class Student_View : UserControl
    {
        //Fields
        private int page = 0;
        private int SelectedCount = 0;

        //Construcstor
        public Student_View()
        {
            InitializeComponent();
            cmbMajor.ValueMember = "MajorID";
            cmbMajor.DisplayMember = "MajorName";
            DataTable dt = Major_Repository.GetAll();
            DataRow dr = dt.NewRow();
            dr[0] = -1;
            dr[1] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);
            cmbMajor.DataSource = dt;
            SetDoubleBuffer(this);
            cmbMajor.SelectedIndex = 0;
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

        #region Function
        //Table
        public async void DisplayList(string condition = "")
        {
            try
            {
                int.TryParse(btnPageShow.Text, out int startRow);
                startRow *= page;
                int lastRow = GetPage();
                pnlList.Controls.Clear();
                if (lastRow == 0) return;
                var list = await Student_Repository.GetStudentsAsync(condition, int.Parse(cmbMajor.SelectedValue.ToString()), startRow, lastRow);
                await Task.Run(() =>
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        Student_Row item = new(list[i]) { Tag = i };
                        item.Row_CheckedChanged += Row_CheckedChanged;
                        item.Edit_Click += Row_EditClick;
                        SetDoubleBuffer(item);
                        this.Invoke((System.Windows.Forms.MethodInvoker)delegate
                        {
                            pnlList.Controls.Add(item);
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void CmbMajor_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            page = 0;
            DisplayList();
        }

        private void PnlList_SizeChanged(object sender, EventArgs e)
        {
            if (pnlScroll.VerticalScroll.Visible)
                pnlList.Padding = new Padding(15, 0, 0, 0);
            else
                pnlList.Padding = new Padding(15, 0, 22, 0);
        }

        private void CbAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = pnlList.Controls.Count - 1; i >= 0; i--)
            {
                ((Student_Row)pnlList.Controls[i]).IsSelected = cbAll.Checked;
            }
        }

        private void Row_CheckedChanged(object sender, EventArgs e)
        {
            SelectedCount = 0;
            foreach (Student_Row row in pnlList.Controls)
                if (row.IsSelected) SelectedCount++;
            if (SelectedCount == 0) btnAction.Visible = false;
            else
            {
                btnAction.Visible = true;
                btnAction.Text = "Selected: " + SelectedCount;
            }
            Student_Row cb = sender as Student_Row;
            if (!cb.IsSelected)
            {
                cbAll.CheckedChanged -= CbAll_CheckedChanged;
                cbAll.Checked = false;
                cbAll.CheckedChanged += CbAll_CheckedChanged;
            }
            else
            {
                foreach (Student_Row row in pnlList.Controls)
                    if (!row.IsSelected) return;
                cbAll.Checked = true;
            }
        }

        //Data Modify Action
        private void Row_EditClick(object sender, EventArgs e)
        {
            Student_Row currentRow = sender as Student_Row;
            Main_View frm = Application.OpenForms["Main_View"] as Main_View;
            frm.OpenChildForm(new Student_Detail(currentRow.Item));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Student_Add frm = new Student_Add();
            frm.Show();
            frm.Disposed += (s, args) =>
            {
                if (frm.DataChanged) DisplayList();
            };
        }

        //Search
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtSearch.Texts.IsNullOrEmpty())
            {
                e.SuppressKeyPress = true;
                page = 0;
                DisplayList(txtSearch.Texts);
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

        //Page Button
        private int GetPage()
        {
            lblPageCount.Text = "0";
            int last = Student_Repository.GetStudentCount(int.Parse(cmbMajor.SelectedValue.ToString()));
            if (int.TryParse(btnPageShow.Text, out int first))
            {
                first *= page;
                last = first + int.Parse(btnPageShow.Text);
                lblPageCount.Text = first.ToString();
            }
            last = Math.Min(last, Student_Repository.GetStudentCount(int.Parse(cmbMajor.SelectedValue.ToString())));
            lblPageCount.Text += $" - {last} of {Student_Repository.GetStudentCount(int.Parse(cmbMajor.SelectedValue.ToString()))}";
            return last;
        }

        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                DisplayList();
            }
        }

        private void BtnAfterPage_Click(object sender, EventArgs e)
        {
            if (GetPage() == Student_Repository.GetStudentCount(int.Parse(cmbMajor.SelectedValue.ToString()))) return;
            page++;
            DisplayList();
        }

        private void BtnPageShow_Click(object sender, EventArgs e)
        {
            cmbListPage.Select();
            cmbListPage.DroppedDown = true;
            btnPageShow.Rotation += 180;
        }

        private void BtnPageShow_TextChanged(object sender, EventArgs e)
        {
            page = 0;
            DisplayList();
        }

        private void CmbListPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPageShow.Text = cmbListPage.SelectedItem.ToString();
        }

        private void CmbListPage_DropDownClosed(object sender, EventArgs e)
        {
            btnPageShow.Rotation += 180;
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            cmbListAction.Select();
            cmbListAction.DroppedDown = true;
            btnAction.Rotation += 180;
        }

        private void CmbListAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbListAction.SelectedIndex)
            {
                case 0: break;
                case 1:
                    if (SelectedCount == 0) break;
                    else if (MessageBox.Show($"Xác nhận xoá {SelectedCount} sinh viên", "Xác nhận",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (Student_Row row in pnlList.Controls)
                        {
                            if (row.IsSelected)
                                Student_Repository.Delete(row.Item.StudentID);
                        }
                        DisplayList();
                    }
                    break;

                case 2:
                    Student_ToClass frm = new();
                    SetDoubleBuffer(frm);
                    frm.Show();
                    frm.Disposed += (sen, ev) =>
                    {
                        if (frm.Added)
                        {
                            if (Enroll_Repository.GetStudentCount(frm.ClassID) > 0)
                            {
                                int end = 0;
                                if (SelectedCount > Enroll_Repository.GetStudentCount(frm.ClassID))
                                {
                                    if (MessageBox.Show($"Lớp này chỉ còn thừa {Enroll_Repository.GetStudentCount(frm.ClassID)} chỗ " +
                                        "trống, hệ thống sẽ chỉ lấy vừa đủ những người đầu danh sách", "Hết chỗ"
                                        , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                        end = pnlList.Controls.Count - Enroll_Repository.GetStudentCount(frm.ClassID);
                                    else return;
                                }
                                for (int i = pnlList.Controls.Count - 1; i >= end; i--)
                                {
                                    Student_Row row = pnlList.Controls[i] as Student_Row;
                                    if (row.IsSelected)
                                        Enroll_Repository.Add(new Enroll(row.Item.StudentID, frm.ClassID));
                                }


                            }
                            else { MessageBox.Show("Lớp đã hết chỗ trống", "Hết chỗ"); }
                        }
                    };
                    break;
            }
        }

        private void CmbListAction_DropDownClosed(object sender, EventArgs e)
        {
            btnAction.Rotation += 180;
        }

        #endregion

        #region Smooth Apearance 
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
    public partial class Student_Row : TableLayoutPanel
    {
        //Fields
        private Student item;

        //Events
        public event EventHandler Row_CheckedChanged;
        public event EventHandler Edit_Click;

        //Constructor
        public Student_Row(Student item)
        {
            #region InitializeComponent
            SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEdit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(716, 0);
            panel1.Margin = new Padding(0);
            panel1.Padding = new Padding(9);
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 15;
            btnDelete.BorderSize = 0;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDelete.IconColor = Color.FromArgb(192, 0, 0);
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 20;
            btnDelete.Location = new Point(9, 9);
            btnDelete.Margin = new Padding(9);
            btnDelete.Padding = new Padding(0, 1, 0, 0);
            btnDelete.Size = new Size(30, 30);
            btnDelete.TabStop = false;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnDelete);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(668, 0);
            panel2.Margin = new Padding(0);
            panel2.Padding = new Padding(9, 9, 19, 9);
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BorderColor = Color.PaleVioletRed;
            btnEdit.BorderRadius = 15;
            btnEdit.BorderSize = 0;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderColor = Color.White;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEdit.IconColor = Color.FromArgb(64, 64, 64);
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 20;
            btnEdit.Location = new Point(9, 9);
            btnEdit.Margin = new Padding(9);
            btnEdit.Padding = new Padding(1, 3, 0, 0);
            btnEdit.Size = new Size(30, 30);
            btnEdit.TabStop = false;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // cbSelect
            // 
            cbSelect.AutoSize = true;
            cbSelect.BackColor = Color.White;
            cbSelect.Dock = DockStyle.Fill;
            cbSelect.Text = item.StudentID.ToString();
            cbSelect.Margin = new Padding(0);
            cbSelect.Padding = new Padding(10, 0, 0, 0);
            cbSelect.UseVisualStyleBackColor = false;
            cbSelect.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // Label_PropertiesSet
            //            

            this.BackColor = Color.Gray;
            this.ColumnCount = 10;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            this.Controls.Add(panel2, 9, 0);
            this.Controls.Add(panel1, 8, 0);
            this.Controls.Add(lbl_Phone, 7, 0);
            this.Controls.Add(lbl_Birth, 6, 0);
            this.Controls.Add(lbl_Gender, 5, 0);
            this.Controls.Add(lbl_Cohort, 4, 0);
            this.Controls.Add(lbl_Code, 3, 0);
            this.Controls.Add(lbl_FirstName, 2, 0);
            this.Controls.Add(lbl_LastName, 1, 0);
            this.Controls.Add(cbSelect, 0, 0);
            this.Dock = DockStyle.Top;
            this.ForeColor = Color.FromArgb(64, 64, 64);
            this.Location = new Point(0, 0);
            this.Padding = new Padding(0, 0, 0, 2);
            this.RowCount = 1;
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Size = new Size(777, 50);

            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                lbl.BackColor = Color.White;
                lbl.Dock = DockStyle.Fill;
                lbl.Margin = new Padding(0);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
            }
            PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);

            #endregion
            Item = item;
            foreach (Control ctl in this.Controls)
            {
                if (!(ctl is CheckBox)) ctl.Click += Row_Click;
                ctl.MouseEnter += RowEnter_MouseEnter;
                ctl.MouseLeave += RowLeave_MouseEnter;
            }
        }

        #region Function
        public Student Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                cbSelect.Text = item.StudentID.ToString();
                lbl_LastName.Text = item.LastName;
                lbl_FirstName.Text = item.FirstName;
                lbl_Code.Text = item.StudentCode;
                lbl_Cohort.Text = item.Cohort;
                lbl_Gender.Text = item.Gender == '0' ? "Nam" : "Nữ";
                lbl_Birth.Text = item.DOB.ToShortDateString();
                lbl_Phone.Text = item.Phone;
            }
        }

        public bool IsSelected { get => cbSelect.Checked; set => cbSelect.Checked = value; }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit_Click?.Invoke(this, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xoá sinh viên {Item.StudentCode}",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (Student_Repository.Delete(item.StudentID))
                {
                    this.Dispose();
                }
        }

        private void Row_Click(object sender, EventArgs e)
        {
            cbSelect.Checked = !cbSelect.Checked;
        }

        private void RowEnter_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
                ctl.BackColor = SystemColors.Control;
        }

        private void RowLeave_MouseEnter(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
                ctl.BackColor = Color.White;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Row_CheckedChanged?.Invoke(this, e);
        }

        #endregion

        //Components
        private CheckBox cbSelect = new();
        private Label lbl_LastName = new();
        private Label lbl_FirstName = new();
        private Label lbl_Code = new();
        private Label lbl_Cohort = new();
        private Label lbl_Gender = new();
        private Label lbl_Birth = new();
        private Label lbl_Phone = new();
        private CustomButton btnEdit = new();
        private CustomButton btnDelete = new();
        private Panel panel1 = new();
        private Panel panel2 = new();
    }
}
