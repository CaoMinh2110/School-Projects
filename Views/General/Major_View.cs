using BTL.Data;
using BTL.Models;
using System.ComponentModel;

namespace BTL.Views
{
    [ToolboxItem(false)]
    public partial class Major_View : UserControl
    {
        //Constructor
        public Major_View()
        {
            InitializeComponent();
            dgvList.DataSource = Major_Repository.GetAll();
        }

        #region Events
        private void DgvList_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvList.Columns)
            {
                column.Width = dgvList.Width / dgvList.ColumnCount;
            }
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Texts = dgvList.SelectedRows[0].Cells[0].Value.ToString();
            txt_Name.Texts = dgvList.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xoá vĩnh viên ngành " + txt_ID.Texts, "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (Major_Repository.Delete(txt_ID.Texts))
                {
                    dgvList.DataSource = Major_Repository.GetAll();
                    txt_ID.Texts = "";
                    txt_Name.Texts = "";
                }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Texts) ||
               !int.TryParse(txt_ID.Texts, out int id))
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi dữ liệu");
            else
            if (Major_Repository.Edit(new Major(id, txt_Name.Texts)))
            {
                dgvList.DataSource = Major_Repository.GetAll();
                txt_ID.Texts = "";
                txt_Name.Texts = "";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Texts))
                MessageBox.Show("Thông tin không hợp lệ", "Lỗi dữ liệu");
            else if (Major_Repository.Add(txt_Name.Texts))
            {
                dgvList.DataSource = Major_Repository.GetAll();
                txt_ID.Texts = "";
                txt_Name.Texts = "";
            }
        }
        #endregion

        //Smooth Appearance
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
    }
}
