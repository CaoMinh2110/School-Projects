namespace BTL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customPanel1 = new CustomControls.CustomPanel();
            panel1 = new Panel();
            customPictureBox1 = new CustomControls.CustomPictureBox();
            btnNoficate = new CustomControls.CustomButton();
            label2 = new Label();
            customPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor1 = Color.FromArgb(54, 0, 51);
            customPanel1.BackColor2 = Color.FromArgb(11, 135, 147);
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderSize = 0;
            customPanel1.Controls.Add(panel1);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.GradientAngle = 45F;
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Radius = new Padding(0);
            customPanel1.Size = new Size(1130, 811);
            customPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(customPictureBox1);
            panel1.Controls.Add(btnNoficate);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 100);
            panel1.TabIndex = 1;
            // 
            // customPictureBox1
            // 
            customPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            customPictureBox1.BorderColor1 = Color.RoyalBlue;
            customPictureBox1.BorderColor2 = Color.HotPink;
            customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            customPictureBox1.BorderSize = 2;
            customPictureBox1.GradientAngle = 50F;
            customPictureBox1.Location = new Point(2240, 12);
            customPictureBox1.Name = "customPictureBox1";
            customPictureBox1.Size = new Size(60, 60);
            customPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            customPictureBox1.TabIndex = 0;
            customPictureBox1.TabStop = false;
            // 
            // btnNoficate
            // 
            btnNoficate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNoficate.BackColor = Color.Transparent;
            btnNoficate.BorderColor = Color.PaleVioletRed;
            btnNoficate.BorderRadius = 30;
            btnNoficate.BorderSize = 0;
            btnNoficate.FlatAppearance.BorderColor = Color.White;
            btnNoficate.FlatAppearance.BorderSize = 0;
            btnNoficate.FlatStyle = FlatStyle.Flat;
            btnNoficate.ForeColor = Color.White;
            btnNoficate.IconChar = FontAwesome.Sharp.IconChar.Bell;
            btnNoficate.IconColor = Color.Gray;
            btnNoficate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNoficate.IconSize = 30;
            btnNoficate.Location = new Point(945, 14);
            btnNoficate.Margin = new Padding(5);
            btnNoficate.Name = "btnNoficate";
            btnNoficate.Padding = new Padding(1, 3, 0, 0);
            btnNoficate.Size = new Size(60, 60);
            btnNoficate.TabIndex = 2;
            btnNoficate.TabStop = false;
            btnNoficate.Tag = "Thông báo";
            btnNoficate.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Helvetica Rounded", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(30, 0, 0, 0);
            label2.Size = new Size(344, 100);
            label2.TabIndex = 1;
            label2.Text = "GOLO";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1130, 811);
            Controls.Add(customPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            customPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControls.CustomPanel customPanel1;
        private CustomControls.CustomPictureBox customPictureBox1;
        private CustomControls.CustomButton btnNoficate;
        private Label label2;
    }
}
