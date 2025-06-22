using BTL.CustomControls;
using BTL.Data;
using BTL.Models;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BTL.Views.Class
{
    public partial class Course_Add : Form
    {
        private int borderRadius = 20;
        private int borderSize = 4;
        private Color borderColor = Color.Gray;
        private bool added = false;
        public Course_Add()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;
            cmb_CatID.ValueMember = "CourseCatID";
            cmb_CatID.DisplayMember = "CourseCatName";
            cmb_CatID.DataSource = CourseCategories_Repository.GetAll();
            CoursePoint_Input hs1 = new()
            {
                AssTypeName = "Hệ số 1",
                WeightPercentage = "10",
            };
            CoursePoint_Input hs2 = new()
            {
                AssTypeName = "Hệ số 2",
                WeightPercentage = "20",
            };
            pnlPointList.Controls.Add(hs2);
            pnlPointList.Controls.Add(hs1);
        }

        public bool Added { get => added; set => added = value; }

        public bool ValidInput()
        {
            bool valid = true;
            if (txt_Code.Texts.IsNullOrEmpty() || txt_Name.Texts.IsNullOrEmpty())
            {
                valid = false;
            }

            HashSet<string> list = new HashSet<string>();
            foreach (CoursePoint_Input row in pnlPointList.Controls)
            {
                string name = row.AssTypeName;
                if (name.IsNullOrEmpty()) valid = false;
                if (list.Contains(name))
                {
                    valid = false;
                }
                else
                {
                    list.Add(name);
                }
            }
            return valid;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            pnlContainer.Panel1Collapsed = false;
            pnlContainer.Panel2Collapsed = true;
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            pnlContainer.Panel1Collapsed = true;
            pnlContainer.Panel2Collapsed = false;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string code = txt_Code.Texts;
            string name = txt_Name.Texts;
            int credit = Int16.Parse(txt_Credit.Value.ToString());
            int catID = Int16.Parse(cmb_CatID.SelectedValue.ToString());
            int session = Int16.Parse(txt_Session.Value.ToString());
            int absences = Int16.Parse(txt_Absences.Value.ToString());
            float point = float.Parse(txt_Point.Value.ToString());

            decimal id = Course_Repository.Add(new Course(0, code, name, credit, catID, session, absences, point));
            if (id != -1)
            {
                added = true;
                if (pnlPointList.Controls.Count != 0)
                    foreach (CoursePoint_Input control in pnlPointList.Controls)
                        control.Executed(int.Parse(id.ToString()));
                else
                {
                    AssessmentType_Repository.Add(new Assessment_Type(0, int.Parse(id.ToString()), "Điểm quá trình", 100));
                }
                this.Dispose();
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_AddAssessment_Click(object sender, EventArgs e)
        {
            CoursePoint_Input control = new();
            pnlPointList.Controls.Add(control);
        }

        #region Radius_Setup
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new(borderColor, borderSize))
                using (Matrix transform = new())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        private void Course_Add_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(tableLayoutPanel1, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void Course_Add_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Course_Add_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Course_Add_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion
    }

    [ToolboxItem(false)]
    public class CoursePoint_Input : SplitContainer
    {
        int id = 0;

        //Constructor
        public CoursePoint_Input()
        {
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlInputFields).BeginInit();
            pnlInputFields.Panel1.SuspendLayout();
            pnlInputFields.Panel2.SuspendLayout();
            pnlInputFields.SuspendLayout();

            this.Dock = DockStyle.Top;
            this.Location = new Point(0, 0);
            this.SplitterDistance = 516;
            this.Panel1.Controls.Add(pnlInputFields);
            this.Panel2.Controls.Add(btn);
            this.Panel2.Padding = new Padding(0, 40, 0, 2);
            this.Size = new Size(560, 80);
            this.SplitterDistance = 516;

            btn.BackColor = Color.Gray;
            btn.BorderRadius = 5;
            btn.BorderSize = 0;
            btn.Dock = DockStyle.Fill;
            btn.FlatAppearance.BorderColor = Color.Gray;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn.IconColor = Color.White;
            btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn.IconSize = 22;
            btn.TabStop = false;
            btn.UseVisualStyleBackColor = false;
            btn.Click += BtnDelete_Click;

            pnlInputFields.Dock = DockStyle.Fill;
            pnlInputFields.Panel1.Controls.Add(txt_Name);
            pnlInputFields.Panel1.Controls.Add(lbl_Name);
            pnlInputFields.Panel2.Controls.Add(txt_Percentage);
            pnlInputFields.Panel2.Controls.Add(lbl_Percentage);
            pnlInputFields.Size = new Size(516, 78);
            pnlInputFields.SplitterDistance = 340;

            lbl_Percentage.Dock = lbl_Name.Dock = DockStyle.Top;
            lbl_Percentage.ForeColor = lbl_Name.ForeColor = Color.Gray;
            lbl_Percentage.Padding = lbl_Name.Padding = new Padding(0, 10, 0, 0);
            lbl_Percentage.Size = lbl_Name.Size = new Size(341, 40);
            lbl_Percentage.TextAlign = lbl_Name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Name.Text = "Tên đầu điểm";
            lbl_Percentage.Text = "Tỉ lệ trọng số (%)";

            txt_Percentage.BackColor = txt_Name.BackColor = SystemColors.Control;
            txt_Percentage.BorderColor = txt_Name.BorderColor = Color.Gray;
            txt_Percentage.BorderFocusColor = txt_Name.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Percentage.BorderRadius = txt_Name.BorderRadius = 8;
            txt_Percentage.BorderSize = txt_Name.BorderSize = 2;
            txt_Percentage.Dock = txt_Name.Dock = DockStyle.Top;
            txt_Percentage.ForeColor = txt_Name.ForeColor = Color.DimGray;
            txt_Percentage.Margin = txt_Name.Margin = new Padding(4);
            txt_Percentage.Padding = txt_Name.Padding = new Padding(7);
            txt_Name.PlaceholderColor = Color.DimGray;

            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            this.ResumeLayout(false);

            pnlInputFields.Panel1.ResumeLayout(false);
            pnlInputFields.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlInputFields).EndInit();
            pnlInputFields.ResumeLayout(false);
        }

        public int AssTypeID { get => id; set => id = value; }

        public string AssTypeName { get => txt_Name.Texts; set => txt_Name.Texts = value; }

        public string WeightPercentage { get => txt_Percentage.Texts; set => txt_Percentage.Texts = value; }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Executed(int courseID)
        {
            AssessmentType_Repository.Add(new Assessment_Type(0, courseID, AssTypeName, float.Parse(WeightPercentage)));
        }

        public void Edit()
        {
            AssessmentType_Repository.Edit(new Assessment_Type(id, 0, AssTypeName, float.Parse(WeightPercentage)));
        }

        //Component
        SplitContainer pnlInputFields = new();
        Label lbl_Name = new();
        Label lbl_Percentage = new();
        CustomTextBox txt_Name = new();
        CustomNumbericUpDown txt_Percentage = new();
        CustomButton btn = new();
    }
}
