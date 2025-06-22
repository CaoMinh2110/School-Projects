using BTL.Data;
using BTL.Models;
using BTL.Views.Class;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace BTL.Views
{
    [ToolboxItem(false)]
    public partial class Course_View : UserControl
    {
        int id = -1;

        public Course_View()
        {
            InitializeComponent();
            cmb_CatID.ValueMember = "CourseCatID";
            cmb_CatID.DisplayMember = "CourseCatName";
            DataTable dt = CourseCategories_Repository.GetAll();
            DataRow row = dt.NewRow();
            row[0] = -1;
            row[1] = "Tất cả";
            dt.Rows.InsertAt(row, 0);
            cmb_CatID.DataSource = dt;

            CmbCatID_OnSelectedChanged(null, null);
        }

        public void Reset()
        {
            id = -1;
            txt_Code.Texts = "";
            txt_Name.Texts = "";
            txt_Credit.Texts = "";
            txt_Session.Texts = "";
            txt_Absences.Texts = "";
            txt_Point.Texts = "";
        }

        private void DgvList_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < pnlHeaderText.ColumnCount; i++)
            {
                float columnWidth = pnlHeaderText.ColumnStyles[i].Width;
                columnWidth = (pnlHeaderText.ClientSize.Width * columnWidth) / 100;
                dgvList.Columns[i].Width = (int)columnWidth;
            }
        }

        private void CmbCatID_OnSelectedChanged(object sender, EventArgs e)
        {
            if (cmb_CatID.SelectedValue.ToString() == "-1") dgvList.DataSource = Course_Repository.GetAll();
            else dgvList.DataSource = Course_Repository.GetCourseByCatID(cmb_CatID.SelectedValue.ToString());
            dgvList.Columns["CourseID"].Visible = false;
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Code.Texts = dgvList.SelectedRows[0].Cells[0].Value.ToString();
            txt_Name.Texts = dgvList.SelectedRows[0].Cells[1].Value.ToString();
            txt_Credit.Texts = dgvList.SelectedRows[0].Cells[2].Value.ToString();
            txt_Session.Texts = dgvList.SelectedRows[0].Cells[3].Value.ToString();
            txt_Absences.Texts = dgvList.SelectedRows[0].Cells[4].Value.ToString();
            txt_Point.Texts = dgvList.SelectedRows[0].Cells[5].Value.ToString();

            id = int.Parse(dgvList.SelectedRows[0].Cells["CourseID"].Value.ToString());
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_Credit.Texts, out int credit) ||
                !int.TryParse(cmb_CatID.SelectedValue.ToString(), out int catID) ||
                !int.TryParse(txt_Session.Texts, out int session) ||
                !int.TryParse(txt_Absences.Texts, out int absences) ||
                !float.TryParse(txt_Point.Texts, out float point))
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi dữ liệu");
            else if (Course_Repository.Edit(new Course(id, txt_Code.Texts, txt_Name.Texts, credit, catID, session, absences, point)))
            {
                CmbCatID_OnSelectedChanged(null, null);
                Reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Course_Repository.Delete(id))
            {
                CmbCatID_OnSelectedChanged(null, null);
                Reset();
            }
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


        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AssessmentTypes_Detail frm = new(int.Parse(dgvList.SelectedRows[0].Cells["CourseID"].Value.ToString()));
            frm.Show();

        }
    }
}
