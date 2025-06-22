using BTL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class Student_Repository
    {
        public static async Task<List<Student>> GetStudentsAsync(string condition, int MajorID, int page, int pagesize)
        {
            using (IDbConnection conn = DBConnection.GetConnection())
            {
                string cmdText =
                    "SELECT * FROM Students " +
                    "WHERE IsDeleted = 0 " + (MajorID > 0 ? $"AND MajorID = {MajorID}" : "") +
                    $"AND (LastName LIKE N'%{condition}%' " +
                    $"OR FirstName LIKE N'%{condition}%' " +
                    $"OR StudentCode LIKE N'%{condition}%' " +
                    $"OR Phone LIKE N'%{condition}%')" +
                    $"ORDER BY StudentID OFFSET {page} ROW FETCH NEXT {pagesize} ROW ONLY";
                var students = await conn.QueryAsync<Student>(cmdText);
                return students.AsList();
            }
        }

        public static int GetStudentCount(int MajorID)
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT COUNT(*) FROM Students WHERE IsDeleted = 0 ";
                    if (MajorID != -1) cmdText += $"AND MajorID = {MajorID}";
                    SqlCommand cmd = new(cmdText, conn);
                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return count;
        }

        public static bool Add(Student s)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "INSERT INTO Students VALUES " +
                        "(" +
                        "@firstN, @lastN, @code, " +
                        "@email, @phone , @major, " +
                        "@gender, @address , @identity, " +
                        "@cohort, @birth , @note, 0" +
                        ")";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("firstN", s.FirstName);
                    cmd.Parameters.AddWithValue("lastN", s.LastName);
                    cmd.Parameters.AddWithValue("code", s.StudentCode);
                    cmd.Parameters.AddWithValue("email", s.Email);
                    cmd.Parameters.AddWithValue("phone", s.Phone);
                    cmd.Parameters.AddWithValue("major", s.MajorID);
                    cmd.Parameters.AddWithValue("gender", s.Gender);
                    cmd.Parameters.AddWithValue("address", s.Address);
                    cmd.Parameters.AddWithValue("identity", s.IdentityNumber);
                    cmd.Parameters.AddWithValue("cohort", s.Cohort);
                    cmd.Parameters.AddWithValue("birth", s.DOB);
                    cmd.Parameters.AddWithValue("note", s.Note);
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
                string cmdText = $"UPDATE Students SET IsDeleted = 1 WHERE StudentID = '{id}'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool Edit(Student s)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Students SET " +
                    "FirstName = @firstN, " +
                    "LastName = @lastN, " +
                    "StudentCode = @code, " +
                    "Email = @email, " +
                    "Phone = @phone, " +
                    "MajorID = @major, " +
                    "Gender = @gender, " +
                    "Address = @address, " +
                    "IdentityNumber = @identity, " +
                    "Cohort = @cohort, " +
                    "DOB = @birth, " +
                    "Note = @note " +
                    "WHERE StudentID = @id";
                SqlCommand cmd = new(cmdText, conn);
                cmd.Parameters.AddWithValue("firstN", s.FirstName);
                cmd.Parameters.AddWithValue("lastN", s.LastName);
                cmd.Parameters.AddWithValue("code", s.StudentCode);
                cmd.Parameters.AddWithValue("email", s.Email);
                cmd.Parameters.AddWithValue("phone", s.Phone);
                cmd.Parameters.AddWithValue("major", s.MajorID);
                cmd.Parameters.AddWithValue("gender", s.Gender);
                cmd.Parameters.AddWithValue("address", s.Address);
                cmd.Parameters.AddWithValue("identity", s.IdentityNumber);
                cmd.Parameters.AddWithValue("cohort", s.Cohort);
                cmd.Parameters.AddWithValue("birth", s.DOB);
                cmd.Parameters.AddWithValue("note", s.Note);
                cmd.Parameters.AddWithValue("id", s.StudentID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetByValue(string value)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "SELECT * FROM Students WHERE " +
                        "StudentCode LIKE @value OR " +
                        "FirstName LIKE @value OR " +
                        "LastName LIKE @value OR " +
                        "Phone LIKE @value";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("@value", "%" + value + "%");
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

        public static DataTable GetByID(int value)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "SELECT * FROM Students WHERE StudentID = @value ";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("@value", value);
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
                    string cmdText = "SELECT StudentID, LastName + ' ' + FirstName AS StudentName FROM Students WHERE IsDeleted = 1";
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
