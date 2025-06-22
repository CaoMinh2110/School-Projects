using BTL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    public class Course_Repository
    {
        public static decimal Add(Course c)
        {
            decimal id = -1;
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "INSERT INTO Courses VALUES " +
                        "(@code, @name, @credit, @catID, @session, @absences, @point, 0);" +
                        "SELECT SCOPE_IDENTITY() AS NewID;";
                    SqlCommand cmd = new SqlCommand(cmdText, conn);
                    cmd.Parameters.AddWithValue("code", c.CourseCode);
                    cmd.Parameters.AddWithValue("name", c.CourseName);
                    cmd.Parameters.AddWithValue("credit", c.CourseCredits);
                    cmd.Parameters.AddWithValue("catID", c.CourseCatID);
                    cmd.Parameters.AddWithValue("session", c.ClassSessions);
                    cmd.Parameters.AddWithValue("absences", c.MaxAllowedAbsences);
                    cmd.Parameters.AddWithValue("point", c.PointToPass);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetDecimal(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
            }
            return id;
        }

        public static bool Edit(Course c)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Courses SET " +
                    "CourseName = @name, " +
                    "CourseCredits = @credit, " +
                    "ClassSessions = @session, " +
                    "MaxAllowedAbsences = @absences, " +
                    "PointToPass = @point " +
                    "WHERE CourseCode = @code";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("name", c.CourseName);
                cmd.Parameters.AddWithValue("credit", c.CourseCredits);
                cmd.Parameters.AddWithValue("session", c.ClassSessions);
                cmd.Parameters.AddWithValue("absences", c.MaxAllowedAbsences);
                cmd.Parameters.AddWithValue("point", c.PointToPass);
                cmd.Parameters.AddWithValue("code", c.CourseCode);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Delete(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Courses SET IsDeleted = 1 WHERE CourseID = " + id;
                SqlCommand cmd = new(cmdText, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetCourseByCatID(string id)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT CourseCode, CourseName, CourseCredits, " +
                        "ClassSessions, MaxAllowedAbsences, PointToPass, CourseID " +
                        $"FROM Courses WHERE CourseCatID = N'{id}' AND IsDeleted = 0";
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
                    string cmdText = "SELECT CourseCode, CourseName, CourseCredits, " +
                        "ClassSessions, MaxAllowedAbsences, PointToPass, CourseID " +
                        "FROM Courses WHERE IsDeleted = 0";
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

        public static DataTable GetByID(int id)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT * FROM Courses WHERE IsDeleted = 0 AND CourseID = " + id;
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
                    string cmdText = "SELECT CourseID, CourseName FROM Courses WHERE IsDeleted = 1";
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
