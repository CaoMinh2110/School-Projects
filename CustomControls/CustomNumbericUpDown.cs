using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace BTL.CustomControls
{
    public partial class CustomNumbericUpDown : UserControl
    {
        public event EventHandler _ValueChanged;
        //TextBox-> TextChanged event
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (_ValueChanged != null)
                _ValueChanged.Invoke(sender, e);
        }

        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private bool isFocused = false;

        private int borderRadius = 0;
        public CustomNumbericUpDown()
        {
            InitializeComponent();
            SetDoubleBuffer(this);
        }

        #region -> Properties
        [Category("Apperance")]
        public decimal Increament
        {
            get
            {
                return numericUpDown1.Increment;
            }
            set
            {
                numericUpDown1.Increment = value;
            }
        }

        [Category("Apperance")]
        public int DecimalPlaces
        {
            get
            {
                return numericUpDown1.DecimalPlaces;
            }
            set
            {
                numericUpDown1.DecimalPlaces = value;
            }
        }

        [Category("Apperance")]
        public decimal Maximum
        {
            get
            {
                return numericUpDown1.Maximum;
            }
            set
            {
                numericUpDown1.Maximum = value;
            }
        }

        [Category("Apperance")]
        public decimal Minimun
        {
            get
            {
                return numericUpDown1.Minimum;
            }
            set
            {
                numericUpDown1.Minimum = value;
            }
        }

        [Category("Apperance")]
        public string Texts
        {
            get
            {
                return numericUpDown1.Text;
            }
            set
            {
                numericUpDown1.Text = value;
            }
        }

        [Category("Apperance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Apperance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("Apperance")]
        public HorizontalAlignment TextAlign
        {
            get { return numericUpDown1.TextAlign; }
            set { numericUpDown1.TextAlign = value; }
        }

        [Category("Apperance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 2)
                {
                    borderSize = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Apperance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                numericUpDown1.BackColor = value;
            }
        }

        [Category("Apperance")]
        public override Color ForeColor
        {
            get { return numericUpDown1.ForeColor; }
            set
            {
                numericUpDown1.ForeColor = value;
            }
        }

        [Category("Apperance")]
        public decimal Value
        {
            get
            {
                return numericUpDown1.Value;
            }
            set
            {
                numericUpDown1.Value = value;
            }
        }

        [Category("Apperance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        #endregion

        #region -> Private methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            pathTxt = GetFigurePath(numericUpDown1.ClientRectangle, borderSize * 2);
            numericUpDown1.Region = new Region(pathTxt);
            pathTxt.Dispose();
        }

        private void UpdateControlHeight()
        {
            int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
            numericUpDown1.MinimumSize = new Size(0, txtHeight);
            this.Height = numericUpDown1.Height + this.Padding.Top + this.Padding.Bottom;
        }
        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
            this.Invalidate();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        #endregion

        //Events
        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            numericUpDown1.ForeColor = ForeColor;
            Invalidate();
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

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
    }
}
