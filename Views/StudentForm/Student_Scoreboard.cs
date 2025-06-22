using BTL.Data;
using FontAwesome.Sharp;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;

namespace BTL.Views.StudentForm
{
    public partial class Student_Scoreboard : UserControl
    {
        public int Count { get => pnlList.Controls.Count; }

        public Student_Scoreboard(int StudentID, int SemesterID, int count)
        {
            InitializeComponent();

            lbl_Semester.Text = Semester_Repository.GetByID(SemesterID).Rows[0]["SemesterName"].ToString();
            foreach (DataRow item in Enroll_Repository.GetStudentScoreBySemester(StudentID, SemesterID).Rows)
            {
                Control control = new Student_ScoreBySemester(item) { STT = count++ };
                pnlList.Controls.Add(control);
                pnlList.Controls.SetChildIndex(control, 0);
            }

            if (pnlList.Controls.Count > 0) label1.Visible = false;
        }

        private void lblSemester_Click(object sender, EventArgs e)
        {
            pnlList.Visible = !pnlList.Visible;
        }

        private void lbl_Semester_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath roundPath = GetRoundedPath(lbl_Semester.ClientRectangle, 6))
            using (Pen penBorder = new(Color.White, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                lbl_Semester.Region = new Region(roundPath);
                e.Graphics.DrawPath(penBorder, roundPath);
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
    }


    [ToolboxItem(false)]
    public partial class Student_ScoreBySemester : TableLayoutPanel
    {
        private DataRow item;

        public DataRow Item
        {
            get { return item; }
            set
            {
                item = value;
                lbl_ClassName.Text = item["Classname"].ToString();
                lbl_CourseCode.Text = item["CourseCode"].ToString();
                lbl_CourseCredits.Text = item["CourseCredits"].ToString();
                lbl_AttendancePoint.Text = item["AttendancePoint"].ToString();
                lbl_ProcessPoint.Text = item["ProcessPoint"].ToString();
                lbl_ExamsPoint.Text = item["ExamsPoint"].ToString();
                pcb_ExamsAllowed.IconChar = item["ExamsAllowed"].ToString() == "1" ? IconChar.CheckCircle : IconChar.XmarkCircle;
                pcb_Pass.IconChar = IconChar.XmarkCircle;
                if (float.TryParse(lbl_AttendancePoint.Text, out float ap) &&
                    float.TryParse(lbl_ProcessPoint.Text, out float pp) &&
                    float.TryParse(lbl_ExamsPoint.Text, out float ep))
                {
                    decimal tp = (decimal)((ap + pp * 3 + ep * 6) / 10);
                    lbl_TotalPoint.Text = tp.ToString("0.00");
                    if (tp >= decimal.Parse(item["PointToPass"].ToString()) && item["ExamsAllowed"].ToString() == "1")
                        pcb_Pass.IconChar = IconChar.CheckCircle;
                }
            }
        }

        public int STT
        {
            get { return int.Parse(lbl_STT.Text); }
            set { lbl_STT.Text = value.ToString(); }
        }

        public Student_ScoreBySemester(DataRow item)
        {
            Item = item;

            #region InitializeComponent
            SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();

            RowCount = 1;
            RowStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ColumnCount = 10;
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Controls.Add(panel2, 9, 0);
            Controls.Add(lbl_TotalPoint, 8, 0);
            Controls.Add(lbl_ExamsPoint, 7, 0);
            Controls.Add(panel1, 6, 0);
            Controls.Add(lbl_ProcessPoint, 5, 0);
            Controls.Add(lbl_AttendancePoint, 4, 0);
            Controls.Add(lbl_CourseCredits, 3, 0);
            Controls.Add(lbl_CourseCode, 2, 0);
            Controls.Add(lbl_ClassName, 1, 0);
            Controls.Add(lbl_STT, 0, 0);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(64, 64, 64);
            Padding = new Padding(0, 0, 0, 2);
            BackColor = Color.Gray;
            Size = new Size(937, 50);
            Dock = DockStyle.Top;

            foreach (Label lbl in Controls.OfType<Label>())
            {
                lbl.BackColor = Color.White;
                lbl.Dock = DockStyle.Fill;
                lbl.Margin = new Padding(0);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
            }
            lbl_STT.Padding = new Padding(10, 0, 0, 0);
            lbl_AttendancePoint.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ProcessPoint.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ExamsPoint.TextAlign = ContentAlignment.MiddleCenter;
            lbl_TotalPoint.TextAlign = ContentAlignment.MiddleCenter;

            panel1.BackColor = panel2.BackColor = Color.White;
            panel1.Dock = panel2.Dock = DockStyle.Fill;
            panel1.Padding = panel2.Padding = new Padding(6);
            panel1.Margin = panel2.Margin = new Padding(0);

            panel1.Controls.Add(pcb_ExamsAllowed);
            panel2.Controls.Add(pcb_Pass);

            pcb_Pass.BackColor = pcb_ExamsAllowed.BackColor = Color.Transparent;
            pcb_Pass.Dock = pcb_ExamsAllowed.Dock = DockStyle.Fill;
            pcb_Pass.SizeMode = pcb_ExamsAllowed.SizeMode = PictureBoxSizeMode.CenterImage;

            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);

            #endregion
        }

        private Label lbl_STT = new();
        private Label lbl_ClassName = new();
        private Label lbl_CourseCode = new();
        private Label lbl_CourseCredits = new();
        private Label lbl_AttendancePoint = new();
        private Label lbl_ProcessPoint = new();
        private Label lbl_ExamsPoint = new();
        private Label lbl_TotalPoint = new();
        private IconPictureBox pcb_ExamsAllowed = new();
        private IconPictureBox pcb_Pass = new();
        private Panel panel1 = new();
        private Panel panel2 = new();
    }
}
