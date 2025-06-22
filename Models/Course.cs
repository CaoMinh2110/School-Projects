namespace BTL.Models
{
    public class Course
    {
        private int _courseID;
        private string _courseCode;
        private string _courseName;
        private int _courseCredit;
        private int _courseCatID;
        private int _classSessions;
        private int _maxAllowedAbsences;
        private float _pointToPass;
        private bool _isDelete;

        public Course()
        {
        }

        public Course(int courseID, string courseCode, string courseName, int courseCredit,
            int courseCatID, int classSessions, int maxAllowedAbsences, float pointToPass, bool isDelete = false)
        {
            CourseID = courseID;
            CourseCode = courseCode;
            CourseName = courseName;
            CourseCredits = courseCredit;
            CourseCatID = courseCatID;
            ClassSessions = classSessions;
            MaxAllowedAbsences = maxAllowedAbsences;
            PointToPass = pointToPass;
            IsDelete = isDelete;
        }

        public int CourseID { get => _courseID; set => _courseID = value; }
        public string CourseCode { get => _courseCode; set => _courseCode = value; }
        public string CourseName { get => _courseName; set => _courseName = value; }
        public int CourseCredits { get => _courseCredit; set => _courseCredit = value; }
        public int CourseCatID { get => _courseCatID; set => _courseCatID = value; }
        public int ClassSessions { get => _classSessions; set => _classSessions = value; }
        public int MaxAllowedAbsences { get => _maxAllowedAbsences; set => _maxAllowedAbsences = value; }
        public float PointToPass { get => _pointToPass; set => _pointToPass = value; }
        public bool IsDelete { get => _isDelete; set => _isDelete = value; }
    }
}
