using BTL.CustomControls;
using BTL.Views.Class;
using BTL.Views.Scoreboard;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace BTL.Views
{
    public partial class Main_View : Form
    {
        //Fields
        private Control currentChildForm;
        private Control lastAddedControl;

        //Constructor
        public Main_View()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
                SetDoubleBuffer(control);
            BtnGeneral_Click(btnGeneral, null);
        }

        #region Methods
        private void ActivateButton(object button)
        {
            foreach (CustomButton control in pnlButton.Controls.OfType<CustomButton>())
            {
                control.IconColor = Color.LightCoral;
            }
            ((CustomButton)button).IconColor = Color.Cyan;
        }

        public void OpenChildForm(Control childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
            }
            currentChildForm = childForm;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            SetDoubleBuffer(childForm);
            childForm.Paint += (sen, e) =>
            {
                Control control = sen as Control;
                using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, pnlChildForm.Radius.Left))
                using (Pen penBorder = new(pnlChildForm.BackColor, 1))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    control.Region = new Region(roundPath);
                    e.Graphics.DrawPath(penBorder, roundPath);
                }
            };
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);
            path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);
            path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);
            path.CloseFigure();
            return path;
        }
        #endregion

        #region Events
        private void BtnStudent_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            toolTip1.SetToolTip(control, control.Tag.ToString());
        }

        private void BtnStudent_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(sender as Control);
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new General_View());
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Student_View());
        }

        private void BtnScoreboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Scoreboard_View());
        }

        private void BtnClass_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Classes_View());
        }

        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DeleteList_View());
        }

        private void BtnDeletedList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new DeleteList_View());
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Setting_View());
        }

        #endregion

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
