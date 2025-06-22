namespace BTL.Models
{
    public class Classes
    {
        private int _classID;
        private int _courseID;
        private int _semesterID;
        private string _className;
        private bool _isDeleted;

        public Classes()
        {
        }

        public Classes(int classID, int courseID, int semesterID, string className, bool isDeleted = false)
        {
            ClassID = classID;
            CourseID = courseID;
            SemesterID = semesterID;
            ClassName = className;
            IsDeleted = isDeleted;
        }

        public int ClassID { get => _classID; set => _classID = value; }
        public int CourseID { get => _courseID; set => _courseID = value; }
        public int SemesterID { get => _semesterID; set => _semesterID = value; }
        public string ClassName { get => _className; set => _className = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
    }
}
