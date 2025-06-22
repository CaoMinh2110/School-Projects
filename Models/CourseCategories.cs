namespace BTL.Models
{
    public class CourseCategories
    {
        private int _courseCatID;
        private string _courseCatName;
        private bool _isDeleted;

        public CourseCategories()
        {
        }

        public CourseCategories(int courseCatID, string courseCatName, bool isDeleted = false)
        {
            CourseCatID = courseCatID;
            CourseCatName = courseCatName;
            IsDeleted = isDeleted;
        }

        public int CourseCatID { get => _courseCatID; set => _courseCatID = value; }
        public string CourseCatName { get => _courseCatName; set => _courseCatName = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
    }
}
