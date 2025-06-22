namespace BTL.Models
{
    public class Student
    {
        private int _studentID;
        private string _firstName;
        private string _lastName;
        private string _studentCode;
        private string _email;
        private string _phone;
        private int _majorID;
        private char _gender;
        private string _address;
        private string _identityNumber;
        private string _cohort;
        private DateTime _dob;
        private string _note;
        private bool _isDelete;

        public Student()
        {
            _isDelete = false;
        }

        public Student(int studentID, string firstName, string lastName, string studentCode, string email, string phone,
            int majorID, char gender, string address, string identity, string cohort, DateTime dob, string note, bool isDelete = false)
        {
            _studentID = studentID;
            _firstName = firstName;
            _lastName = lastName;
            _studentCode = studentCode;
            _email = email;
            _phone = phone;
            _majorID = majorID;
            _gender = gender;
            _address = address;
            _identityNumber = identity;
            _cohort = cohort;
            _dob = dob;
            _note = note;
            _isDelete = isDelete;
        }
        public int StudentID { get => _studentID; set => _studentID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string StudentCode { get => _studentCode; set => _studentCode = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public DateTime DOB { get => _dob; set => _dob = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public int MajorID { get => _majorID; set => _majorID = value; }
        public string Email { get => _email; set => _email = value; }
        public string Address { get => _address; set => _address = value; }
        public string IdentityNumber { get => _identityNumber; set => _identityNumber = value; }
        public string Cohort { get => _cohort; set => _cohort = value; }
        public string Note { get => _note; set => _note = value; }
        public bool IsDelete { get => _isDelete; set => _isDelete = value; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Student)) return false;

            Student other = (Student)obj;
            return this.FirstName == other.FirstName
                && this.LastName == other.LastName
                && this.StudentCode == other.StudentCode
                && this.Email == other.Email
                && this.Phone == other.Phone
                && this.MajorID == other.MajorID
                && this.Gender == other.Gender
                && this.Address == other.Address
                && this.Cohort == other.Cohort
                && this.IdentityNumber == other.IdentityNumber
                && this.Note == other.Note
                && this.IsDelete == other.IsDelete;
        }
    }
}
