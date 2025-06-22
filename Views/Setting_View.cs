using BTL.Data;
using Microsoft.Data.SqlClient;

namespace BTL.Views
{
    public partial class Setting_View : UserControl
    {
        public Setting_View()
        {
            InitializeComponent();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new("SELECT * FROM CauHinh", conn);
                numericUpDown1.Value = decimal.Parse(cmd.ExecuteScalar().ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new("UPDATE CauHinh SET MaxStudentInClass = " + numericUpDown1.Text, conn);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Cập nhật thành công", "Cập nhật hệ thống");
            }
        }
    }
}
