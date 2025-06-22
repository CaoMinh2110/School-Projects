using BTL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class Semester_Repository
    {
        public static bool Add(Semester sm)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "INSERT INTO Semester VALUES (@name, @year, @delete)";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("name", sm.SemesterName);
                    cmd.Parameters.AddWithValue("year", sm.Year);
                    cmd.Parameters.AddWithValue("delete", sm.IsDelete);
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
                string cmdText = $"UPDATE Semester SET IsDeleted = 1 WHERE SemesterID = {id}";
                SqlCommand cmd = new(cmdText, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Edit(Semester sm)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Semester SET SemesterName = @name, " +
                    "Year = @year, IsDeleted = @delete where SemesterID = @id";
                SqlCommand cmd = new(cmdText, conn);
                cmd.Parameters.AddWithValue("name", sm.SemesterName);
                cmd.Parameters.AddWithValue("year", sm.Year);
                cmd.Parameters.AddWithValue("delete", sm.IsDelete);
                cmd.Parameters.AddWithValue("id", sm.SemesterID);
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
                       "SELECT SemesterID, SemesterName, Year FROM Semester WHERE IsDeleted = 0";
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

        public static DataTable GetByID(int id)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                       "SELECT * FROM Semester WHERE IsDeleted = 0 AND SemesterID = " + id;
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

        public static DataTable GetStudent_BeginToEnd_Semester(int StudentID)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "SELECT * FROM Semester WHERE " +
                            //MIN
                            "SemesterID >= " +
                            "(SELECT MIN(c.SemesterID) " +
                            "FROM Enroll e " +
                            "JOIN Classes c ON c.ClassID = e.ClassID " +
                            "JOIN Courses co ON co.CourseID = c.CourseID " +
                            $"WHERE e.StudentID = {StudentID}) " +
                            //MAX
                            "AND SemesterID <= " +
                            "(SELECT MAX(c.SemesterID) " +
                            "FROM Enroll e " +
                            "JOIN Classes c ON c.ClassID = e.ClassID " +
                            "JOIN Courses co ON co.CourseID = c.CourseID " +
                            $"WHERE e.StudentID = {StudentID}) " +

                        "AND IsDeleted = 0";
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
                    string cmdText = "SELECT SemesterID, SemesterName FROM Semester WHERE IsDeleted = 1";
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

