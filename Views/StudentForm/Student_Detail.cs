using BTL.Models;
using System.ComponentModel;
using System.Reflection;

namespace BTL.Views.StudentForm
{
    [ToolboxItem(false)]
    public partial class Student_Detail : UserControl
    {
        Student student;
        public Student_Detail(Student s)
        {
            InitializeComponent();
            student = s;
            Btn_Infor_Click(btn_Infor, null);
        }

        private void ActivateTabPage(Button sender, Control ctl)
        {
            pnlCoverBorder.Location = new Point(pnlTabBar.Location.X + 4
                + (sender.Width + 6) * sender.TabIndex, 0);
            foreach (Control c in pnlTab.Controls)
                if (!(c is Panel))
                    pnlTab.Controls.Remove(c);
            pnlTab.Controls.Add(ctl);
            ctl.Dock = DockStyle.Fill;
            SetDoubleBuffer(ctl);
        }

        private void Btn_Score_Click(object sender, EventArgs e)
        {
            ActivateTabPage((Button)sender, new Student_Score(student));
        }

        private void Btn_Infor_Click(object sender, EventArgs e)
        {
            ActivateTabPage((Button)sender, new Student_Infor(student));
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Main_View frm = Application.OpenForms["Main_View"] as Main_View;
            frm.OpenChildForm(new Student_View());
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

        static void SetDoubleBuffer(Control ctl)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctl, [true]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Control control in ctl.Controls)
                SetDoubleBuffer(control);
        }

        #endregion
    }
}
