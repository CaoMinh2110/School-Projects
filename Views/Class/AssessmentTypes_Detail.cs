using BTL.Data;
using BTL.Models;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BTL.Views.Class
{
    public partial class AssessmentTypes_Detail : Form
    {
        private int borderRadius = 20;
        private int borderSize = 4;
        private Color borderColor = Color.Gray;
        private bool added = false;
        private int CourseID;
        private List<int> DeletedList = new List<int>();

        public AssessmentTypes_Detail(int CourseID)
        {
            InitializeComponent();
            this.CourseID = CourseID;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;
            DataTable dt = AssessmentType_Repository.GetByCourseID(CourseID);
            foreach (DataRow dr in dt.Rows)
            {
                CoursePoint_Input cp = new()
                {
                    AssTypeID = int.Parse(dr["AssTypeID"].ToString()),
                    AssTypeName = dr["AssTypeName"].ToString(),
                    WeightPercentage = dr["WeightPercentage"].ToString(),
                    Tag = "old"
                };

                pnlPointList.Controls.Add(cp);
                pnlPointList.Controls.SetChildIndex(cp, 0);
            }
            this.Disposed += AssessmentTypes_Detail_Disposed;
        }

        private void AssessmentTypes_Detail_Disposed(object? sender, EventArgs e)
        {
            if (pnlPointList.Controls.Count == 0)
            {
                AssessmentType_Repository.Add(new Assessment_Type(0, CourseID, "Điểm quá trình", 100));
            }
        }

        public bool ValidInput()
        {
            bool valid = true;
            HashSet<string> list = new HashSet<string>();
            foreach (CoursePoint_Input row in pnlPointList.Controls)
            {
                string name = row.AssTypeName;
                if (name.IsNullOrEmpty()) valid = false;
                if (list.Contains(name))
                {
                    valid = false;
                }
                else
                {
                    list.Add(name);
                }
            }
            return valid;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_AddAssessment_Click(object sender, EventArgs e)
        {
            CoursePoint_Input control = new();
            control.Tag = "new";
            pnlPointList.Controls.Add(control);
            pnlPointList.Controls.SetChildIndex(control, 0);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ", "Lỗi dữ liệu");
                return;
            }

            foreach (CoursePoint_Input item in pnlPointList.Controls)
            {
                switch (item.Tag)
                {
                    case "old": item.Edit(); break;
                    case "new": item.Executed(CourseID); break;
                }
            }
            foreach (int id in DeletedList)
            {
                AssessmentType_Repository.Delete(id);
            }
            MessageBox.Show("Cập nhật thành công", "Thông báo");
        }

        private void Item_Disposed(object? sender, EventArgs e)
        {
            DeletedList.Add((sender as CoursePoint_Input).AssTypeID);
        }

        private void PnlPointList_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Disposed += Item_Disposed;
        }

        #region Radius_Setup
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

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
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

        private void AssessmentTypesDetail_Paint(object sender, PaintEventArgs e)
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
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(tableLayoutPanel1, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void AssessmentTypesDetail_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void AssessmentTypesDetail_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void AssessmentTypesDetail_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion


    }
}
