using BTL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class Enroll_Repository
    {
        public static async Task<List<Enroll>> GetClassAsync(int classID, string search)
        {
            using (IDbConnection conn = DBConnection.GetConnection())
            {
                string cmdText = "SELECT * FROM Enroll e " +
                    "JOIN Students s ON s.StudentID = e.StudentID " +
                    $"WHERE ClassID = '{classID}' " +
                    $"AND (s.FirstName LIKE N'%{search}%' " +
                    $"OR s.LastName LIKE N'%{search}%' " +
                    $"OR s.StudentCode LIKE N'%{search}%')";
                var students = await conn.QueryAsync<Enroll>(cmdText);
                return students.AsList();
            }
        }

        public static bool Add(Enroll e)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "BEGIN TRANSACTION; " +
                            "INSERT INTO Enroll (StudentID, ClassID) VALUES (@StudentID, @ClassID); " +
                            "INSERT INTO Scores (StudentID, AssTypeID) " +
                            "SELECT @StudentID, at.AssTypeID " +
                            "FROM Assessment_Types at " +
                            "JOIN Classes c ON at.CourseID = c.CourseID " +
                            "WHERE c.ClassID = @ClassID; " +
                        "COMMIT TRANSACTION; ";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("StudentID", e.StudentID);
                    cmd.Parameters.AddWithValue("ClassID", e.ClassID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
            }
            return false;
        }

        public static int GetStudentCount(int ClassID)
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "SELECT (SELECT * FROM CauHinh) - COUNT(*) FROM Enroll WHERE ClassID = " + ClassID;
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

        public static bool EditAbsences(Enroll e)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "UPDATE Enroll SET Absences = @absences WHERE " +
                        "StudentID = @student AND ClassID = @class";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("absences", e.Absences);
                    cmd.Parameters.AddWithValue("student", e.StudentID);
                    cmd.Parameters.AddWithValue("class", e.ClassID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
            }
            return false;
        }

        public static bool EditExamsPoint(Enroll e)
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText = "UPDATE Enroll SET ExamsPoint = @point WHERE " +
                        "StudentID = @student AND ClassID = @class";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("point", e.ExamsPoint);
                    cmd.Parameters.AddWithValue("student", e.StudentID);
                    cmd.Parameters.AddWithValue("class", e.ClassID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex);
            }
            return false;
        }

        public static DataTable GetClassDetail(int ClassID, int StudentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "SELECT " +
                            "e.StudentID, " +
                            "e.ClassID, " +
                            "s.StudentCode, " +
                            "s.LastName, " +
                            "s.FirstName, " +
                            "CASE " +
                                "WHEN s.Gender = '0' THEN 'Nam' " +
                                "WHEN s.Gender = '1' THEN N'Nữ' " +
                            "END AS Gender, " +
                            "e.Absences, " +
                            "e.ExamsNo, " +
                            "e.ExamsTimes, " +
                            "e.ExamsPoint," +
                            "co.MaxAllowedAbsences, " +
                            "co.PointToPass " +
                        "FROM Enroll e " +
                        "JOIN Students s ON s.StudentID = e.StudentID " +
                        "JOIN Classes c ON c.ClassID = e.ClassID " +
                        "JOIN Courses co ON co.CourseID = c.CourseID " +
                        $"WHERE e.ClassID = {ClassID} AND e.StudentID = {StudentID}";
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

        public static DataTable GetStudentScoreBySemester(int StudentID, int SemesterID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                        "SELECT " +
                            "e.StudentID, " +
                            "e.ClassID, " +
                            "c.ClassName, " +
                            "co.CourseCode, " +
                            "co.CourseCredits, " +
                            "CASE " +
                                "WHEN CAST(e.Absences AS FLOAT) / CAST(co.MaxAllowedAbsences AS FLOAT)  * 100 >= 100 THEN 0 " +
                                "WHEN CAST(e.Absences AS FLOAT) / CAST(co.MaxAllowedAbsences AS FLOAT)  * 100 >= 70 THEN 2 " +
                                "WHEN CAST(e.Absences AS FLOAT) / CAST(co.MaxAllowedAbsences AS FLOAT)  * 100 >= 40 THEN 4 " +
                                "WHEN CAST(e.Absences AS FLOAT) / CAST(co.MaxAllowedAbsences AS FLOAT)  * 100 >= 20 THEN 6 " +
                                "WHEN CAST(e.Absences AS FLOAT) / CAST(co.MaxAllowedAbsences AS FLOAT)  * 100 > 10 THEN 8 " +
                                "ELSE 10 " +
                            "END AS AttendancePoint, " +
                            "CASE " +
                                "WHEN(e.Absences > co.MaxAllowedAbsences) THEN 0 " +
                                "ELSE 1 " +
                            "END AS ExamsAllowed, " +
                            "(SELECT ROUND(SUM(sc.ScoreValue * at.WeightPercentage) / SUM(at.WeightPercentage), 2) " +
                            "FROM Assessment_Types at " +
                            "JOIN Scores sc ON sc.AssTypeID = at.AssTypeID AND sc.StudentID = e.StudentID " +
                            "WHERE at.CourseID = co.CourseID AND at.IsDeleted = 0) AS ProcessPoint," +
                            "e.ExamsPoint, " +
                            "co.PointToPass " +
                        "FROM Enroll e " +
                        "JOIN Classes c ON c.ClassID = e.ClassID " +
                        "JOIN Courses co ON co.CourseID = c.CourseID " +
                        $"WHERE e.StudentID = {StudentID} AND c.SemesterID = {SemesterID}";
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
