using BTL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class Major_Repository
    {
        public static bool Add(string name)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = $"INSERT INTO Majors VALUES (N'{name}', 0)";
                    SqlCommand cmd = new(cmdText, conn);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public static bool Delete(string id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = $"UPDATE Majors SET IsDeleted = 1 WHERE MajorID = " + id;
                SqlCommand cmd = new(cmdText, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Edit(Major mj)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Majors SET MajorName = @name WHERE MajorID = @id";
                SqlCommand cmd = new(cmdText, conn);
                cmd.Parameters.AddWithValue("name", mj.MajorName);
                cmd.Parameters.AddWithValue("id", mj.MajorID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "SELECT MajorID, MajorName FROM Majors WHERE IsDeleted = 0";
                    SqlCommand cmd = new(cmdText, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return dt;
        }

        public static DataTable GetDeleted()
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT MajorID, MajorName FROM Majors WHERE IsDeleted = 1";
                    SqlDataReader reader = new SqlCommand(cmdText, conn).ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return dt;
        }
    }
}
