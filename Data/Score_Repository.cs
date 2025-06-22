using BTL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BTL.Data
{
    internal class Score_Repository
    {
        public static bool Edit(Score c)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string cmdText = "UPDATE Scores SET ScoreValue = @value " +
                    "WHERE AssTypeID = @assType AND StudentID = @student";
                SqlCommand cmd = new(cmdText, conn);
                cmd.Parameters.AddWithValue("value", c.ScoreValue);
                cmd.Parameters.AddWithValue("assType", c.AssTypeID);
                cmd.Parameters.AddWithValue("student", c.StudentID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable GetScoreByAssTypeAndStudent(int AssTypeID, int StudentID)
        {
            DataTable dt = new();
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string cmdText =
                    "IF NOT EXISTS (SELECT 1 FROM Scores WHERE AssTypeID = @atID AND StudentID = @student) " +
                    "BEGIN " +
                        "INSERT INTO Scores (AssTypeID, StudentID, ScoreValue) " +
                        "VALUES (@atID, @student, 0) " +
                    "END; " +
                    "SELECT * FROM Scores WHERE AssTypeID = @atID AND StudentID = @student";
                    SqlCommand cmd = new(cmdText, conn);
                    cmd.Parameters.AddWithValue("atID", AssTypeID);
                    cmd.Parameters.AddWithValue("student", StudentID);
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
    }
}
