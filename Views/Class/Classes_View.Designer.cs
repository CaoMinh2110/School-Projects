namespace BTL.Views.Class
{
    partial class Classes_View
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTab = new CustomControls.CustomPanel();
            pnlCoverBorder = new Panel();
            panel1 = new Panel();
            btnAdd = new CustomControls.CustomButton();
            pnlTabBar = new FlowLayoutPanel();
            btn_Class = new CustomControls.CustomButton();
            btn_Course = new CustomControls.CustomButton();
            label1 = new Label();
            pnlTab.SuspendLayout();
            panel1.SuspendLayout();
            pnlTabBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTab
            // 
            pnlTab.BackColor1 = Color.White;
            pnlTab.BackColor2 = Color.White;
            pnlTab.BorderColor = Color.Gray;
            pnlTab.BorderSize = 2;
            pnlTab.Controls.Add(pnlCoverBorder);
            pnlTab.Dock = DockStyle.Fill;
            pnlTab.GradientAngle = 20F;
            pnlTab.Location = new Point(30, 145);
            pnlTab.Name = "pnlTab";
            pnlTab.Padding = new Padding(15);
            pnlTab.Radius = new Padding(20);
            pnlTab.Size = new Size(1166, 472);
            pnlTab.TabIndex = 3;
            // 
            // pnlCoverBorder
            // 
            pnlCoverBorder.Location = new Point(380, 0);
            pnlCoverBorder.Name = "pnlCoverBorder";
            pnlCoverBorder.Size = new Size(181, 4);
            pnlCoverBorder.TabIndex = 246;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(pnlTabBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(30, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 50);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(27, 90, 255);
            btnAdd.BorderColor = Color.FromArgb(27, 90, 255);
            btnAdd.BorderRadius = 22;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(27, 90, 255);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAdd.IconSize = 20;
            btnAdd.Location = new Point(1028, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(0, 0, 8, 0);
            btnAdd.Size = new Size(135, 45);
            btnAdd.TabIndex = 2;
            btnAdd.TabStop = false;
            btnAdd.Text = "Add new";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // pnlTabBar
            // 
            pnlTabBar.AutoSize = true;
            pnlTabBar.Controls.Add(btn_Class);
            pnlTabBar.Controls.Add(btn_Course);
            pnlTabBar.Location = new Point(40, 0);
            pnlTabBar.Name = "pnlTabBar";
            pnlTabBar.Size = new Size(382, 61);
            pnlTabBar.TabIndex = 0;
            // 
            // btn_Class
            // 
            btn_Class.BackColor = Color.Transparent;
            btn_Class.BorderColor = Color.Gray;
            btn_Class.BorderRadius = 10;
            btn_Class.BorderSize = 2;
            btn_Class.FlatAppearance.BorderColor = Color.Gray;
            btn_Class.FlatAppearance.BorderSize = 0;
            btn_Class.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Class.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Class.FlatStyle = FlatStyle.Flat;
            btn_Class.ForeColor = Color.Gray;
            btn_Class.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Class.IconColor = Color.Black;
            btn_Class.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Class.Location = new Point(0, 3);
            btn_Class.Margin = new Padding(0, 3, 3, 3);
            btn_Class.Name = "btn_Class";
            btn_Class.Size = new Size(188, 55);
            btn_Class.TabIndex = 0;
            btn_Class.TabStop = false;
            btn_Class.Text = "Lớp học";
            btn_Class.UseVisualStyleBackColor = false;
            btn_Class.Click += Btn_Class_Click;
            // 
            // btn_Course
            // 
            btn_Course.BackColor = Color.Transparent;
            btn_Course.BorderColor = Color.Gray;
            btn_Course.BorderRadius = 10;
            btn_Course.BorderSize = 2;
            btn_Course.FlatAppearance.BorderColor = Color.Gray;
            btn_Course.FlatAppearance.BorderSize = 0;
            btn_Course.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Course.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Course.FlatStyle = FlatStyle.Flat;
            btn_Course.ForeColor = Color.Gray;
            btn_Course.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Course.IconColor = Color.Black;
            btn_Course.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Course.Location = new Point(194, 3);
            btn_Course.Margin = new Padding(3, 3, 0, 3);
            btn_Course.Name = "btn_Course";
            btn_Course.Size = new Size(188, 55);
            btn_Course.TabIndex = 1;
            btn_Course.TabStop = false;
            btn_Course.Text = "Học phần";
            btn_Course.UseVisualStyleBackColor = false;
            btn_Course.Click += Btn_Course_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Helvetica Rounded", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 20);
            label1.Size = new Size(1166, 65);
            label1.TabIndex = 3;
            label1.Text = "Quản lý lớp học";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Classes_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlTab);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Classes_View";
            Padding = new Padding(30);
            Size = new Size(1226, 647);
            pnlTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTabBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel pnlTab;
        private Panel pnlCoverBorder;
        private Panel panel1;
        private FlowLayoutPanel pnlTabBar;
        private CustomControls.CustomButton btn_Class;
        private CustomControls.CustomButton btn_Course;
        private Label label1;
        private CustomControls.CustomButton btnAdd;
    }
}
