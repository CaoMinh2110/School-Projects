namespace BTL.Views.StudentForm
{
    partial class Student_Detail
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
            panel1 = new Panel();
            btn_Exit = new FontAwesome.Sharp.IconButton();
            pnlTab = new CustomControls.CustomPanel();
            pnlCoverBorder = new Panel();
            panel2 = new Panel();
            pnlTabBar = new FlowLayoutPanel();
            btn_Infor = new CustomControls.CustomButton();
            btn_Score = new CustomControls.CustomButton();
            panel1.SuspendLayout();
            pnlTab.SuspendLayout();
            panel2.SuspendLayout();
            pnlTabBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 10);
            panel1.Size = new Size(1240, 65);
            panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.Dock = DockStyle.Left;
            btn_Exit.FlatAppearance.BorderColor = Color.White;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Exit.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("Helvetica Rounded", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btn_Exit.IconColor = Color.Black;
            btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Exit.IconSize = 35;
            btn_Exit.Location = new Point(0, 10);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Padding = new Padding(0, 0, 0, 10);
            btn_Exit.Size = new Size(336, 45);
            btn_Exit.TabIndex = 0;
            btn_Exit.Text = "Danh sách sinh viên";
            btn_Exit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += Btn_Exit_Click;
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
            pnlTab.Location = new Point(15, 65);
            pnlTab.Name = "pnlTab";
            pnlTab.Padding = new Padding(15);
            pnlTab.Radius = new Padding(20);
            pnlTab.Size = new Size(1210, 460);
            pnlTab.TabIndex = 3;
            // 
            // pnlCoverBorder
            // 
            pnlCoverBorder.Location = new Point(33, 0);
            pnlCoverBorder.Name = "pnlCoverBorder";
            pnlCoverBorder.Size = new Size(181, 4);
            pnlCoverBorder.TabIndex = 246;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlTabBar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(1210, 50);
            panel2.TabIndex = 0;
            // 
            // pnlTabBar
            // 
            pnlTabBar.AutoSize = true;
            pnlTabBar.Controls.Add(btn_Infor);
            pnlTabBar.Controls.Add(btn_Score);
            pnlTabBar.Location = new Point(40, 0);
            pnlTabBar.Name = "pnlTabBar";
            pnlTabBar.Size = new Size(382, 61);
            pnlTabBar.TabIndex = 0;
            // 
            // btn_Infor
            // 
            btn_Infor.BackColor = Color.Transparent;
            btn_Infor.BorderColor = Color.Gray;
            btn_Infor.BorderRadius = 10;
            btn_Infor.BorderSize = 2;
            btn_Infor.FlatAppearance.BorderColor = Color.Gray;
            btn_Infor.FlatAppearance.BorderSize = 0;
            btn_Infor.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Infor.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Infor.FlatStyle = FlatStyle.Flat;
            btn_Infor.ForeColor = Color.Gray;
            btn_Infor.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Infor.IconColor = Color.Black;
            btn_Infor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Infor.Location = new Point(0, 3);
            btn_Infor.Margin = new Padding(0, 3, 3, 3);
            btn_Infor.Name = "btn_Infor";
            btn_Infor.Size = new Size(188, 55);
            btn_Infor.TabIndex = 0;
            btn_Infor.TabStop = false;
            btn_Infor.Tag = "2";
            btn_Infor.Text = "Thông tin cá nhân";
            btn_Infor.UseVisualStyleBackColor = false;
            btn_Infor.Click += Btn_Infor_Click;
            // 
            // btn_Score
            // 
            btn_Score.BackColor = Color.Transparent;
            btn_Score.BorderColor = Color.Gray;
            btn_Score.BorderRadius = 10;
            btn_Score.BorderSize = 2;
            btn_Score.FlatAppearance.BorderColor = Color.Gray;
            btn_Score.FlatAppearance.BorderSize = 0;
            btn_Score.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Score.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Score.FlatStyle = FlatStyle.Flat;
            btn_Score.ForeColor = Color.Gray;
            btn_Score.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Score.IconColor = Color.Black;
            btn_Score.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Score.Location = new Point(194, 3);
            btn_Score.Margin = new Padding(3, 3, 0, 3);
            btn_Score.Name = "btn_Score";
            btn_Score.Size = new Size(188, 55);
            btn_Score.TabIndex = 1;
            btn_Score.TabStop = false;
            btn_Score.Tag = "3";
            btn_Score.Text = "Bảng điểm";
            btn_Score.UseVisualStyleBackColor = false;
            btn_Score.Click += Btn_Score_Click;
            // 
            // Student_Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlTab);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Student_Detail";
            Padding = new Padding(30);
            Size = new Size(1300, 665);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlTab.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTabBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControls.CustomPanel pnlTab;
        private Panel pnlCoverBorder;
        private Panel panel2;
        private FlowLayoutPanel pnlTabBar;
        private CustomControls.CustomButton btn_Infor;
        private CustomControls.CustomButton btn_Score;
        private FontAwesome.Sharp.IconButton btn_Exit;
    }
}
