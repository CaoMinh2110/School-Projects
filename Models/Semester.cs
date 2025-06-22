namespace BTL.Models
{
    public class Semester
    {
        private int _semesterID;
        private string _semesterName;
        private int _year;
        private bool _isDelete;

        public Semester()
        {
        }

        public Semester(int semeterID, string semesterName, int year, bool isDelete = false)
        {
            _semesterID = semeterID;
            _semesterName = semesterName;
            _year = year;
            _isDelete = isDelete;
        }
        public int SemesterID { get => _semesterID; set => _semesterID = value; }
        public string SemesterName { get => _semesterName; set => _semesterName = value; }
        public int Year { get => _year; set => _year = value; }
        public bool IsDelete { get => _isDelete; set => _isDelete = value; }
    }
}
