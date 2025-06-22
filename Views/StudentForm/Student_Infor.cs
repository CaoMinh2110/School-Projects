using BTL.Data;
using BTL.Models;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;

namespace BTL.Views.StudentForm
{
    [ToolboxItem(false)]
    public partial class Student_Infor : UserControl
    {
        Student s = new();
        public Student_Infor(Student student)
        {
            InitializeComponent();
            cmb_Gender.SelectedIndex = 0;

            cmb_Major.DisplayMember = "MajorName";
            cmb_Major.ValueMember = "MajorID";
            cmb_Major.DataSource = Major_Repository.GetAll();

            s.StudentID = student.StudentID;
            s.StudentCode = txt_Code.Texts = student.StudentCode;
            s.FirstName = txt_FirstName.Texts = student.FirstName;
            s.LastName = txt_LastName.Texts = student.LastName;
            s.Phone = txt_Phone.Texts = student.Phone;
            s.Email = txt_Email.Texts = student.Email;
            s.IdentityNumber = txt_Identity.Texts = student.IdentityNumber;
            s.Address = txt_Address.Texts = student.Address;
            s.Note = txt_Note.Texts = student.Note;
            s.DOB = dpBirth.Value = student.DOB;
            s.Cohort = txt_Cohort.Texts = student.Cohort;

            s.Gender = student.Gender;

            cmb_Gender.SelectedIndex = int.Parse(student.Gender.ToString());
            cmb_Major.SelectedValue = s.MajorID = student.MajorID;

            btn_Edit.Enabled = false;
        }

        private bool ValidInput()
        {
            bool valid = false;
            if (s.StudentCode != txt_Code.Texts.Trim() ||
                s.FirstName != txt_FirstName.Texts.Trim() ||
                s.LastName != txt_LastName.Texts.Trim() ||
                s.Phone != txt_Phone.Texts.Trim() ||
                s.Email != txt_Email.Texts.Trim() ||
                s.IdentityNumber != txt_Identity.Texts.Trim() ||
                s.Address != txt_Address.Texts.Trim() ||
                s.Note != txt_Note.Texts.Trim() ||
                s.DOB != dpBirth.Value ||
                s.Gender != char.Parse(cmb_Gender.SelectedIndex.ToString()) ||
                s.MajorID != int.Parse(cmb_Major.SelectedValue.ToString())) valid = true;

            if (txt_FirstName.Texts.IsNullOrEmpty() ||
                txt_Phone.Texts.IsNullOrEmpty() ||
                txt_Email.Texts.IsNullOrEmpty() ||
                txt_Identity.Texts.IsNullOrEmpty() ||
                txt_Cohort.Texts.IsNullOrEmpty()) valid = false;

            return valid;
        }

        private void InputChanged(object sender, EventArgs e)
        {
            btn_Edit.Enabled = ValidInput();
        }


        #region Smooth Appearance
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        #endregion

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentID = s.StudentID;
            student.StudentCode = txt_Code.Texts;
            student.FirstName = txt_FirstName.Texts;
            student.LastName = txt_LastName.Texts;
            student.Phone = txt_Phone.Texts;
            student.Email = txt_Email.Texts;
            student.IdentityNumber = txt_Identity.Texts;
            student.Address = txt_Address.Texts;
            student.Note = txt_Note.Texts;
            student.DOB = dpBirth.Value;
            student.Cohort = txt_Cohort.Texts.Trim();
            student.Gender = char.Parse(cmb_Gender.SelectedIndex.ToString());
            student.MajorID = int.Parse(cmb_Major.SelectedValue.ToString());
            if (Student_Repository.Edit(student))
            {
                MessageBox.Show("Cập nhật thành công", "Chỉnh sửa", MessageBoxButtons.OK);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xoá sinh viên {s.StudentCode}",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (Student_Repository.Delete(s.StudentID))
                {
                    this.Dispose();
                }
        }
    }
}
