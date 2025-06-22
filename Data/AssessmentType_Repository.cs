using BTL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class AssessmentType_Repository
    {
        public static bool Add(Assessment_Type at)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "INSERT INTO Assessment_Types " +
                        "(CourseID, AssTypeName, WeightPercentage) " +
                        "VALUES (@course, @name, @percent)";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("course", at.CourseID);
                    cmd.Parameters.AddWithValue("name", at.AssTypeName);
                    cmd.Parameters.AddWithValue("percent", at.WeightPercentage);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public static bool Delete(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = $"UPDATE Assessment_Types SET IsDeleted = 1 WHERE AssTypeID = " + id;
                SqlCommand cmd = new(cmdText, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Edit(Assessment_Type at)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Assessment_Types SET " +
                    "AssTypeName = @name, " +
                    "WeightPercentage = @percent " +
                    "WHERE AssTypeID = @id";
                SqlCommand cmd = new(cmdText, conn);
                cmd.Parameters.AddWithValue("name", at.AssTypeName);
                cmd.Parameters.AddWithValue("percent", at.WeightPercentage);
                cmd.Parameters.AddWithValue("id", at.AssTypeID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetByID(int AssTypeID)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT * FROM Assessment_Types WHERE IsDeleted = 0 AND AssTypeID = " + AssTypeID;
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

        public static DataTable GetByCourseID(int CourseID)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT * FROM Assessment_Types WHERE IsDeleted = 0 AND CourseID = " + CourseID;
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

        public static DataTable GetDeleted()
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT * FROM Assessment_Types WHERE IsDeleted = 1";
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
