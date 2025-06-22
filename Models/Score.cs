namespace BTL.Models
{
    public class Score
    {
        private int _scoreID;
        private int _studentID;
        private int _assTypeID;
        private float _scoreValue;

        public Score(int scoreID, int studentID, int assTypeID, float scoreValue = 0)
        {
            ScoreID = scoreID;
            StudentID = studentID;
            AssTypeID = assTypeID;
            ScoreValue = scoreValue;
        }

        public int ScoreID { get => _scoreID; set => _scoreID = value; }
        public int StudentID { get => _studentID; set => _studentID = value; }
        public int AssTypeID { get => _assTypeID; set => _assTypeID = value; }
        public float ScoreValue { get => _scoreValue; set => _scoreValue = value; }
    }
}
