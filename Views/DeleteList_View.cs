using BTL.Data;
using System.ComponentModel;

namespace BTL.Views
{
    [ToolboxItem(false)]
    public partial class DeleteList_View : UserControl
    {
        public DeleteList_View()
        {
            InitializeComponent();
            Btn_Major_Click(btn_Major, null);
        }

        private void DgvList_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                column.Width = dgvList.Width / 2;
            }
        }

        private void Btn_Major_Click(object sender, EventArgs e)
        {
            pnlCoverBorder.Location = new Point(0, ((Button)sender).Location.Y + 4);
            lbl_ID.Text = "Mã ngành học";
            lbl_Name.Text = "Tên ngành học";
            dgvList.DataSource = Major_Repository.GetDeleted();
        }

        private void btn_Semester_Click(object sender, EventArgs e)
        {
            pnlCoverBorder.Location = new Point(0, ((Button)sender).Location.Y + 4);
            lbl_ID.Text = "Mã học kỳ";
            lbl_Name.Text = "Tên học kỳ";
            dgvList.DataSource = Semester_Repository.GetDeleted();
        }

        private void btn_Course_Click(object sender, EventArgs e)
        {
            pnlCoverBorder.Location = new Point(0, ((Button)sender).Location.Y + 4);
            lbl_ID.Text = "Mã học phần";
            lbl_Name.Text = "Tên học phần";
            dgvList.DataSource = Course_Repository.GetDeleted();
        }

        private void btn_CourseCat_Click(object sender, EventArgs e)
        {
            pnlCoverBorder.Location = new Point(0, ((Button)sender).Location.Y + 4);
            lbl_ID.Text = "Mã nhóm học phần";
            lbl_Name.Text = "Tên nhóm học phần";
            dgvList.DataSource = CourseCategories_Repository.GetDeleted();
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            pnlCoverBorder.Location = new Point(0, ((Button)sender).Location.Y + 4);
            lbl_ID.Text = "Mã lớp học";
            lbl_Name.Text = "Tên lớp học";
            dgvList.DataSource = Class_Repository.GetDeleted();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            pnlCoverBorder.Location = new Point(0, ((Button)sender).Location.Y + 4);
            lbl_ID.Text = "Mã sinh viên";
            lbl_Name.Text = "Tên sinh viên";
            dgvList.DataSource = Student_Repository.GetDeleted();
        }

        private void dgvList_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                column.Width = dgvList.Width / 2;
            }
        }
    }
}
