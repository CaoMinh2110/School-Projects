using BTL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class CourseCategories_Repository
    {
        public static bool Add(string CourseCatName)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = $"INSERT INTO CourseCategories VALUES (N'{CourseCatName}', 0)";
                    SqlCommand cmd = new(cmdText, conn);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
            }
            return false;
        }

        public static bool Edit(CourseCategories cc)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "UPDATE CourseCategories SET CourseCatName = @name WHERE CourseCatID = @id";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("name", cc.CourseCatName);
                    cmd.Parameters.AddWithValue("id", cc.CourseCatID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
            }
            return false;
        }

        public static bool Delete(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE CourseCategories SET IsDeleted = 1 WHERE CourseCatID = " + id;
                SqlCommand cmd = new(cmdText, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT CourseCatID, CourseCatName FROM CourseCategories WHERE IsDeleted = 0";
                    SqlDataReader reader = new SqlCommand(cmdText, conn).ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
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
                    string cmdText = "SELECT CourseCatID, CourseCatName FROM CourseCategories WHERE IsDeleted = 1";
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
