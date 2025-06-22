namespace BTL.Views
{
    partial class General_View
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pnlTab = new CustomControls.CustomPanel();
            pnlCoverBorder = new Panel();
            panel1 = new Panel();
            pnlTabBar = new FlowLayoutPanel();
            btnCourseCat = new CustomControls.CustomButton();
            btnMajors = new CustomControls.CustomButton();
            btnSemester = new CustomControls.CustomButton();
            pnlTab.SuspendLayout();
            panel1.SuspendLayout();
            pnlTabBar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Helvetica Rounded", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 20);
            label1.Size = new Size(1208, 65);
            label1.TabIndex = 1;
            label1.Text = "Quản lý chung";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            pnlTab.BackColor1 = Color.White;
            pnlTab.BackColor2 = Color.White;
            pnlTab.BorderColor = Color.Gray;
            pnlTab.BorderSize = 2;
            pnlTab.Controls.Add(pnlCoverBorder);
            pnlTab.Dock = DockStyle.Fill;
            pnlTab.GradientAngle = 20F;
            pnlTab.Location = new Point(0, 50);
            pnlTab.Name = "pnlTab";
            pnlTab.Padding = new Padding(15);
            pnlTab.Radius = new Padding(20);
            pnlTab.Size = new Size(1208, 525);
            pnlTab.TabIndex = 3;
            // 
            // pnlCoverBorder
            // 
            pnlCoverBorder.Location = new Point(305, 0);
            pnlCoverBorder.Name = "pnlCoverBorder";
            pnlCoverBorder.Size = new Size(181, 4);
            pnlCoverBorder.TabIndex = 246;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlTabBar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 50);
            panel1.TabIndex = 0;
            // 
            // pnlTabBar
            // 
            pnlTabBar.AutoSize = true;
            pnlTabBar.Controls.Add(btnCourseCat);
            pnlTabBar.Controls.Add(btnMajors);
            pnlTabBar.Controls.Add(btnSemester);
            pnlTabBar.Location = new Point(40, 0);
            pnlTabBar.Name = "pnlTabBar";
            pnlTabBar.Size = new Size(576, 61);
            pnlTabBar.TabIndex = 0;
            // 
            // btnCourseCat
            // 
            btnCourseCat.BackColor = Color.Transparent;
            btnCourseCat.BorderColor = Color.Gray;
            btnCourseCat.BorderRadius = 10;
            btnCourseCat.BorderSize = 2;
            btnCourseCat.FlatAppearance.BorderColor = Color.Gray;
            btnCourseCat.FlatAppearance.BorderSize = 0;
            btnCourseCat.FlatAppearance.MouseDownBackColor = Color.White;
            btnCourseCat.FlatAppearance.MouseOverBackColor = Color.White;
            btnCourseCat.FlatStyle = FlatStyle.Flat;
            btnCourseCat.ForeColor = Color.Gray;
            btnCourseCat.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCourseCat.IconColor = Color.Black;
            btnCourseCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCourseCat.Location = new Point(0, 3);
            btnCourseCat.Margin = new Padding(0, 3, 3, 3);
            btnCourseCat.Name = "btnCourseCat";
            btnCourseCat.Size = new Size(188, 55);
            btnCourseCat.TabIndex = 0;
            btnCourseCat.TabStop = false;
            btnCourseCat.Tag = "2";
            btnCourseCat.Text = "Nhóm học phần";
            btnCourseCat.UseVisualStyleBackColor = false;
            btnCourseCat.Click += BtnCourse_Click;
            // 
            // btnMajors
            // 
            btnMajors.BackColor = Color.Transparent;
            btnMajors.BorderColor = Color.Gray;
            btnMajors.BorderRadius = 10;
            btnMajors.BorderSize = 2;
            btnMajors.FlatAppearance.BorderColor = Color.Gray;
            btnMajors.FlatAppearance.BorderSize = 0;
            btnMajors.FlatAppearance.MouseDownBackColor = Color.White;
            btnMajors.FlatAppearance.MouseOverBackColor = Color.White;
            btnMajors.FlatStyle = FlatStyle.Flat;
            btnMajors.ForeColor = Color.Gray;
            btnMajors.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMajors.IconColor = Color.Black;
            btnMajors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMajors.Location = new Point(194, 3);
            btnMajors.Name = "btnMajors";
            btnMajors.Size = new Size(188, 55);
            btnMajors.TabIndex = 1;
            btnMajors.TabStop = false;
            btnMajors.Tag = "3";
            btnMajors.Text = "Ngành học";
            btnMajors.UseVisualStyleBackColor = false;
            btnMajors.Click += BtnMajors_Click;
            // 
            // btnSemester
            // 
            btnSemester.BackColor = Color.Transparent;
            btnSemester.BorderColor = Color.Gray;
            btnSemester.BorderRadius = 10;
            btnSemester.BorderSize = 2;
            btnSemester.FlatAppearance.BorderColor = Color.Gray;
            btnSemester.FlatAppearance.BorderSize = 0;
            btnSemester.FlatAppearance.MouseDownBackColor = Color.White;
            btnSemester.FlatAppearance.MouseOverBackColor = Color.White;
            btnSemester.FlatStyle = FlatStyle.Flat;
            btnSemester.ForeColor = Color.Gray;
            btnSemester.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSemester.IconColor = Color.Black;
            btnSemester.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSemester.Location = new Point(388, 3);
            btnSemester.Margin = new Padding(3, 3, 0, 3);
            btnSemester.Name = "btnSemester";
            btnSemester.Size = new Size(188, 55);
            btnSemester.TabIndex = 2;
            btnSemester.TabStop = false;
            btnSemester.Tag = "3";
            btnSemester.Text = "Học kỳ";
            btnSemester.UseVisualStyleBackColor = false;
            btnSemester.Click += BtnSemester_Click;
            // 
            // General_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlTab);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "General_View";
            Padding = new Padding(30);
            Size = new Size(1268, 700);
            pnlTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTabBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CustomControls.CustomPanel pnlTab;
        private Panel panel1;
        private FlowLayoutPanel pnlTabBar;
        private Panel pnlCoverBorder;
        private CustomControls.CustomButton btnCourseCat;
        private CustomControls.CustomButton btnMajors;
        private CustomControls.CustomButton btnSemester;
    }
}