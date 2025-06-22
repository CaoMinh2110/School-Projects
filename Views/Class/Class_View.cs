using BTL.Data;
using BTL.Models;
using BTL.Views.General;
using System.ComponentModel;

namespace BTL.Views.Class
{
    [ToolboxItem(false)]
    public partial class Class_View : UserControl
    {
        int id = -1;
        public EventHandler CourseAdd;
        public Class_View()
        {
            InitializeComponent();

            cmb_Course.ValueMember = "CourseID";
            cmb_Course.DisplayMember = "CourseName";
            cmb_Course.DataSource = Course_Repository.GetAll();

            cmb_Semester.ValueMember = "SemesterID";
            cmb_Semester.DisplayMember = "SemesterName";
            cmb_Semester.DataSource = Semester_Repository.GetAll();

            dgvList.DataSource = Class_Repository.GetAll();
            dgvList.Columns[2].Visible = false;
            dgvList.Columns[3].Visible = false;
        }

        private void DgvList_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgvList.Columns)
            {
                if (col.Visible)
                    col.Width = dgvList.Width / pnlHeaderText.ColumnCount;
            }
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Texts = dgvList.SelectedRows[0].Cells[0].Value.ToString();
            txt_Name.Texts = dgvList.SelectedRows[0].Cells[1].Value.ToString();
            cmb_Course.SelectedValue = dgvList.SelectedRows[0].Cells[2].Value;
            cmb_Semester.SelectedValue = dgvList.SelectedRows[0].Cells[3].Value;
        }

        private void BtnCourseCatAdd_Click(object sender, EventArgs e)
        {
            CourseAdd?.Invoke(this, EventArgs.Empty);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ID.Texts, out int id))
                if (Class_Repository.Delete(id))
                {
                    dgvList.DataSource = Class_Repository.GetAll();
                }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_ID.Texts, out int id))
                if (Class_Repository.Edit(new Classes(id, int.Parse(cmb_Course.SelectedValue.ToString()),
                    int.Parse(cmb_Semester.SelectedValue.ToString()), txt_Name.Texts)))
                {
                    dgvList.DataSource = Class_Repository.GetAll();
                }
        }

        private void SemesterAdd_Click(object sender, EventArgs e)
        {
            Semester_Add frm = new();
            frm.Show();
            frm.Disposed += (sen, ev) =>
            {
                if (frm.Added)
                {
                    cmb_Semester.DataSource = Semester_Repository.GetAll();
                    cmb_Semester.SelectedIndex = Semester_Repository.GetAll().Rows.Count - 1;
                }
            };
        }

        #region Smooth Appearance
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        #endregion

    }
}
