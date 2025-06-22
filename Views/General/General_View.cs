using System.ComponentModel;
using System.Reflection;

namespace BTL.Views
{
    [ToolboxItem(false)]
    public partial class General_View : UserControl
    {
        public General_View()
        {
            InitializeComponent();
            BtnCourse_Click(btnCourseCat, null);
        }

        //Methods
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

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            ActivateTabPage((Button)sender, new CourseCategories_View());

        }

        private void BtnMajors_Click(object sender, EventArgs e)
        {
            ActivateTabPage((Button)sender, new Major_View());
        }

        private void BtnSemester_Click(object sender, EventArgs e)
        {
            ActivateTabPage((Button)sender, new Semester_View());
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
