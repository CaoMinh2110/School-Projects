namespace BTL.Models
{
    public class Enroll
    {
        private int _studentID;
        private int _classID;
        private int _absences;
        private int _examsNo;
        private float _examsPoint;
        private int _examsTimes;

        public Enroll()
        {
        }

        public Enroll(int studentID, int courseID, float examsPoint)
        {
            StudentID = studentID;
            ClassID = courseID;
            ExamsPoint = examsPoint;
        }

        public Enroll(int studentID, int courseID, int absences)
        {
            StudentID = studentID;
            ClassID = courseID;
            Absences = absences;
        }

        public Enroll(int studentID, int courseID, int absences = 0, int examsNo = 0, float examsPoint = 0, int examsTimes = 0)
        {
            StudentID = studentID;
            ClassID = courseID;
            Absences = absences;
            ExamsNo = examsNo;
            ExamsPoint = examsPoint;
            ExamsTimes = examsTimes;
        }

        public int StudentID { get => _studentID; set => _studentID = value; }
        public int ClassID { get => _classID; set => _classID = value; }
        public int Absences { get => _absences; set => _absences = value; }
        public int ExamsNo { get => _examsNo; set => _examsNo = value; }
        public float ExamsPoint { get => _examsPoint; set => _examsPoint = value; }
        public int ExamsTimes { get => _examsTimes; set => _examsTimes = value; }
    }
}
