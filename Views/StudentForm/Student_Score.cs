using BTL.Data;
using BTL.Models;
using System.ComponentModel;
using System.Data;

namespace BTL.Views.StudentForm
{
    [ToolboxItem(false)]
    public partial class Student_Score : UserControl
    {
        Student s;
        DataTable dt = new();

        public Student_Score(Student student)
        {
            s = student;
            InitializeComponent();
            cmb_Semester.ValueMember = "SemesterID";
            cmb_Semester.DisplayMember = "SemesterName";
            dt = Semester_Repository.GetStudent_BeginToEnd_Semester(student.StudentID);
            DataRow dr = dt.NewRow();
            dr[0] = -1;
            dr[1] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);
            cmb_Semester.DataSource = dt;
        }

        private void CmbSemester_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            pnlList.Controls.Clear();
            if (int.Parse(cmb_Semester.SelectedValue.ToString()) == -1)
            {
                int count = 1;
                foreach (DataRow item in dt.Rows)
                {
                    if (item["SemesterID"].ToString() == "-1") continue;
                    Student_Scoreboard control = new Student_Scoreboard(s.StudentID, int.Parse(item["SemesterID"].ToString()), count);
                    control.Dock = DockStyle.Top;
                    pnlList.Controls.Add(control);
                    pnlList.Controls.SetChildIndex(control, 0);
                    count += control.Count;
                }
            }
            else
            {
                Control control = new Student_Scoreboard(s.StudentID, int.Parse(cmb_Semester.SelectedValue.ToString()), 1);
                control.Dock = DockStyle.Top;
                pnlList.Controls.Add(control);
                pnlList.Controls.SetChildIndex(control, 0);
            }
        }
    }
}
