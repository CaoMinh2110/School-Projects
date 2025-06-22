using System.ComponentModel;

namespace BTL.Models
{
    public class Major
    {
        private int _majorID;
        private string _majorName;
        private bool _isDelete;

        public Major()
        {
        }

        public Major(int majorID, string majorName, bool isDelete = false)
        {
            MajorID = majorID;
            MajorName = majorName;
            IsDelete = isDelete;
        }

        public int MajorID { get => _majorID; set => _majorID = value; }
        [DisplayName("Tên ngành")]
        public string MajorName { get => _majorName; set => _majorName = value; }
        [DisplayName("Trạng thái")]
        public bool IsDelete { get => _isDelete; set => _isDelete = value; }
    }
}
