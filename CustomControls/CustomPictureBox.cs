using System.Drawing.Drawing2D;

namespace BTL.CustomControls
{
    internal class CustomPictureBox : PictureBox
    {
        //Fields
        private int borderSize = 2;
        private Color borderColor1 = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        //Constructor
        public CustomPictureBox()
        {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Properties
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public Color BorderColor1
        {
            get
            {
                return borderColor1;
            }

            set
            {
                borderColor1 = value;
                Invalidate();
            }
        }

        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }

            set
            {
                borderColor2 = value;
                Invalidate();
            }
        }

        public DashStyle BorderLineStyle
        {
            get
            {
                return borderLineStyle;
            }

            set
            {
                borderLineStyle = value;
                Invalidate();
            }
        }

        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }

            set
            {
                borderCapStyle = value;
                Invalidate();
            }
        }

        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

        //Overridden
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields
            var graph = pe.Graphics;
            var rectSurface = Rectangle.Inflate(ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize); ;
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (var borderGradientColor = new LinearGradientBrush(rectBorder, borderColor1, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGradientColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectSurface);
                Region = new Region(pathRegion);

                graph.DrawEllipse(penSmooth, rectSurface);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
