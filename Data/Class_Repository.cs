using BTL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class Class_Repository
    {
        public static DataTable GetAssType(int ClassID)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "SELECT at.AssTypeID, at.AssTypeName " +
                        "FROM Classes c " +
                        "JOIN Assessment_Types at ON c.CourseID = at.CourseID AND at.IsDeleted = 0 " +
                        "WHERE c.ClassID = " + ClassID;
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

        public static bool Add(Classes c)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "INSERT INTO Classes (CourseID, SemesterID, ClassName) " +
                        "VALUES (@course, @semester, @name)";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("course", c.CourseID);
                    cmd.Parameters.AddWithValue("semester", c.SemesterID);
                    cmd.Parameters.AddWithValue("name", c.ClassName);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
            }
            return false;
        }

        public static bool Edit(Classes c)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Classes SET " +
                    "ClassName = @name, " +
                    "CourseID = @course, " +
                    "SemesterID = @semester " +
                    "WHERE ClassID = @id";
                SqlCommand cmd = new(cmdText, conn);
                cmd.Parameters.AddWithValue("name", c.ClassName);
                cmd.Parameters.AddWithValue("course", c.CourseID);
                cmd.Parameters.AddWithValue("semester", c.SemesterID);
                cmd.Parameters.AddWithValue("id", c.ClassID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Delete(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Classes SET IsDeleted = 1 WHERE ClassID = " + id;
                SqlCommand cmd = new(cmdText, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetByID(int id)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT * FROM Classes WHERE IsDeleted = 0 AND ClassID = " + id;
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

        public static DataTable GetAll()
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT ClassID, ClassName, Classes.CourseID, Classes.SemesterID, Courses.CourseName, Semester.SemesterName " +
                        "FROM Classes " +
                        "INNER JOIN Courses ON Classes.CourseID = Courses.CourseID " +
                        "INNER JOIN Semester ON Classes.SemesterID = Semester.SemesterID " +
                        "WHERE Classes.IsDeleted = 0";
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

        public static DataTable GetByCourseID(int id)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = $"SELECT ClassID, ClassName FROM Classes WHERE CourseID = {id} AND IsDeleted = 0";
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
                    string cmdText = "SELECT ClassID, ClassName FROM Classes WHERE IsDeleted = 1";
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
    }
}
