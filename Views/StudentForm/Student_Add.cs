using BTL.Data;
using BTL.Models;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BTL.Views.StudentForm
{
    public partial class Student_Add : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 4;
        private Color borderColor = Color.Gray;

        Student newInfor = new();
        bool _dataChanged = false;
        //Constructor
        public Student_Add()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;

            cbxMajor.DisplayMember = "MajorName";
            cbxMajor.ValueMember = "MajorID";
            cbxMajor.DataSource = Major_Repository.GetAll();
            cbxGender.SelectedIndex = 0;
        }


        #region Function
        //Properties
        public bool DataChanged { get => _dataChanged; set => _dataChanged = value; }

        //Methods
        private void GetName()
        {
            string cleanedFullName = string.Join(" ", txtName.Texts.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            string[] nameParts = cleanedFullName.Split(' ');

            if (nameParts.Length >= 2)
            {
                newInfor.FirstName = nameParts[nameParts.Length - 1];
                newInfor.LastName = string.Join(" ", nameParts, 0, nameParts.Length - 1);
            }
            else
            {
                newInfor.FirstName = txtName.Texts;
                newInfor.LastName = "";
            }
        }

        //Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GetName();
                newInfor.StudentCode = txtId.Texts;
                newInfor.Email = txtEmail.Texts;
                newInfor.Phone = txtPhone.Texts;
                newInfor.MajorID = Int32.Parse(cbxMajor.SelectedValue.ToString());
                newInfor.Gender = Char.Parse(cbxGender.SelectedIndex.ToString());
                newInfor.DOB = dpBirth.Value;
                newInfor.Address = txtAddress.Texts;
                newInfor.IdentityNumber = txtIdentity.Texts;
                newInfor.Cohort = txtCohort.Texts;
                newInfor.Note = txtNote.Texts;

                if (Student_Repository.Add(newInfor))
                {
                    _dataChanged = true;
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region Custom Form
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAnStudent_Repositoryorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new(borderColor, borderSize))
                using (Matrix transform = new())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        private void Student_Add_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAnStudent_Repositoryorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void ControlRegionAnStudent_Repositoryorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAnStudent_Repositoryorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void Student_Add_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Student_Add_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Student_Add_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion
    }
}
