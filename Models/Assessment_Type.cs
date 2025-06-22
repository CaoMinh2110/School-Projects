namespace BTL.Models
{
    public class Assessment_Type
    {
        private int _assTypeID;
        private int _courseID;
        private string _assTypeName;
        private float _weightPercentage;
        private bool _isDeleted;

        public Assessment_Type()
        {
        }

        public Assessment_Type(int assTypeID, int courseID, string assTypeName, float weightPercentage, bool isDelete = false)
        {
            AssTypeID = assTypeID;
            CourseID = courseID;
            AssTypeName = assTypeName;
            WeightPercentage = weightPercentage;
            IsDeleted = isDelete;
        }

        public int AssTypeID { get => _assTypeID; set => _assTypeID = value; }
        public int CourseID { get => _courseID; set => _courseID = value; }
        public string AssTypeName { get => _assTypeName; set => _assTypeName = value; }
        public float WeightPercentage { get => _weightPercentage; set => _weightPercentage = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
    }
}
