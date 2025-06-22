using System.ComponentModel;
using System.Reflection;

namespace BTL.Views.Class
{
    [ToolboxItem(false)]
    public partial class Classes_View : UserControl
    {
        int tab;
        public Classes_View()
        {
            InitializeComponent();
            Btn_Class_Click(btn_Class, null);
        }

        private void ActivateTabPage(Button sender, Control ctl)
        {
            pnlCoverBorder.Location = new Point(pnlTabBar.Location.X + 4
                + (sender.Width + 6) * sender.TabIndex, 0);
            foreach (Control c in pnlTab.Controls)
                if (!(c is Panel))
                    pnlTab.Controls.Remove(c);
            pnlTab.Controls.Add(ctl);
            tab = sender.TabIndex;
            ctl.Dock = DockStyle.Fill;
            SetDoubleBuffer(ctl);
        }

        private void Btn_Course_Click(object sender, EventArgs e)
        {
            ActivateTabPage(((Button)sender), new Course_View());
        }

        private void Btn_Class_Click(object sender, EventArgs e)
        {
            Class_View frm = new Class_View();
            frm.CourseAdd += (sender, ev) =>
            {
                ActivateTabPage(btn_Course, new Course_View());
            };
            ActivateTabPage(((Button)sender), frm);
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            switch (tab)
            {
                case 0:
                    Class_Add frm1 = new();
                    frm1.Show();
                    SetDoubleBuffer(frm1);
                    frm1.Disposed += (se, ev) =>
                    {
                        if (frm1.Added) Btn_Class_Click(btn_Class, null);
                    };
                    break;

                case 1:
                    Course_Add frm2 = new();
                    frm2.Show();
                    SetDoubleBuffer(frm2);
                    frm2.Disposed += (se, ev) =>
                    {
                        if (frm2.Added) Btn_Course_Click(btn_Course, null);
                    };
                    break;
            }
        }
    }
}
