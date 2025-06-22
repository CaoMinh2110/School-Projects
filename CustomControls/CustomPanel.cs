using System.Drawing.Drawing2D;

namespace BTL.CustomControls
{
    public class CustomPanel : Panel
    {
        // Fields
        private Padding radius = new Padding(20);
        private float gradientAngle = 20F;
        private Color backColor1 = Color.RoyalBlue;
        private Color backColor2 = Color.HotPink;
        private int borderSize = 2; // New field for border size
        private Color borderColor = Color.Black; // New field for border color

        // Constructor
        public CustomPanel()
        {
            Size = new Size(100, 100);
        }

        // Methods
        private GraphicsPath GetFigurePath(RectangleF rect, Padding radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSizeTL = (radius.Left - borderSize) * 2F;
            float curveSizeTR = (radius.Top - borderSize) * 2F;
            float curveSizeBR = (radius.Right - borderSize) * 2F;
            float curveSizeBL = (radius.Bottom - borderSize) * 2F;
            path.StartFigure();

            if (radius.Left > 0)
                path.AddArc(rect.X, rect.Y, curveSizeTL, curveSizeTL, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            if (radius.Top > 0)
                path.AddArc(rect.Right - curveSizeTR, rect.Y, curveSizeTR, curveSizeTR, 270, 90);
            else
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);

            if (radius.Right > 0)
                path.AddArc(rect.Right - curveSizeBR, rect.Bottom - curveSizeBR, curveSizeBR, curveSizeBR, 0, 90);
            else
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);

            if (radius.Bottom > 0)
                path.AddArc(rect.X, rect.Bottom - curveSizeBL, curveSizeBL, curveSizeBL, 90, 90);
            else
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);

            path.CloseFigure();
            return path;
        }

        // Properties
        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

        public Color BackColor1
        {
            get => backColor1;
            set
            {
                backColor1 = value;
                Invalidate();
            }
        }

        public Color BackColor2
        {
            get => backColor2;
            set
            {
                backColor2 = value;
                Invalidate();
            }
        }

        public Padding Radius
        {
            get => radius;
            set
            {
                radius = value;
                Invalidate();
            }
        }

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        // Overridden
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rectSurface = Rectangle.Inflate(ClientRectangle, 0, 0);
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            using (var brush = new LinearGradientBrush(rectSurface, backColor1, backColor2, gradientAngle))
                e.Graphics.FillRectangle(brush, rectSurface);

            if (radius.All == 0)
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, Width + 1, Height + 1);
                    }
                }
            }
            else
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, radius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, new Padding(radius.Left - borderSize)))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize > 0)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }
    }
}
