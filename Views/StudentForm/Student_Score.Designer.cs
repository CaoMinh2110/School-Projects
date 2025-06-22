namespace BTL.Views.StudentForm
{
    partial class Student_Score
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
            label10 = new Label();
            cmb_Semester = new CustomControls.CustomComboBox();
            customPanel2 = new CustomControls.CustomPanel();
            pnlHeaderText = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pnlList = new Panel();
            panel1.SuspendLayout();
            customPanel2.SuspendLayout();
            pnlHeaderText.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cmb_Semester);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 65);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(630, 19);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 13;
            label10.Text = "Học kỳ:";
            // 
            // cmb_Semester
            // 
            cmb_Semester.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmb_Semester.BackColor = Color.White;
            cmb_Semester.BorderColor = Color.Gray;
            cmb_Semester.BorderSize = 2;
            cmb_Semester.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Semester.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Semester.ForeColor = Color.DimGray;
            cmb_Semester.IconColor = Color.Gray;
            cmb_Semester.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Semester.ListTextColor = Color.DimGray;
            cmb_Semester.Location = new Point(695, 15);
            cmb_Semester.MinimumSize = new Size(200, 30);
            cmb_Semester.Name = "cmb_Semester";
            cmb_Semester.Padding = new Padding(0, 0, 0, 2);
            cmb_Semester.Size = new Size(240, 35);
            cmb_Semester.TabIndex = 12;
            cmb_Semester.Texts = "";
            cmb_Semester.OnSelectedIndexChanged += CmbSemester_OnSelectedIndexChanged;
            // 
            // customPanel2
            // 
            customPanel2.BackColor1 = Color.Silver;
            customPanel2.BackColor2 = Color.Silver;
            customPanel2.BorderColor = Color.Black;
            customPanel2.BorderSize = 0;
            customPanel2.Controls.Add(pnlHeaderText);
            customPanel2.Dock = DockStyle.Top;
            customPanel2.ForeColor = Color.FromArgb(64, 64, 64);
            customPanel2.GradientAngle = 20F;
            customPanel2.Location = new Point(0, 65);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(15, 5, 15, 5);
            customPanel2.Radius = new Padding(15);
            customPanel2.Size = new Size(967, 50);
            customPanel2.TabIndex = 7;
            // 
            // pnlHeaderText
            // 
            pnlHeaderText.BackColor = Color.Transparent;
            pnlHeaderText.ColumnCount = 10;
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlHeaderText.Controls.Add(label3, 6, 0);
            pnlHeaderText.Controls.Add(label2, 9, 0);
            pnlHeaderText.Controls.Add(label1, 0, 0);
            pnlHeaderText.Controls.Add(label11, 5, 0);
            pnlHeaderText.Controls.Add(label9, 8, 0);
            pnlHeaderText.Controls.Add(label8, 7, 0);
            pnlHeaderText.Controls.Add(label7, 4, 0);
            pnlHeaderText.Controls.Add(label6, 3, 0);
            pnlHeaderText.Controls.Add(label5, 2, 0);
            pnlHeaderText.Controls.Add(label4, 1, 0);
            pnlHeaderText.Dock = DockStyle.Fill;
            pnlHeaderText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderText.Location = new Point(15, 5);
            pnlHeaderText.Margin = new Padding(0);
            pnlHeaderText.Name = "pnlHeaderText";
            pnlHeaderText.RowCount = 1;
            pnlHeaderText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeaderText.Size = new Size(937, 40);
            pnlHeaderText.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(561, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 40);
            label3.TabIndex = 11;
            label3.Text = "Được dự thi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(840, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 40);
            label2.TabIndex = 10;
            label2.Text = "Đạt";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 0, 0);
            label1.Size = new Size(87, 40);
            label1.TabIndex = 9;
            label1.Text = "STT";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(468, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 40);
            label11.TabIndex = 8;
            label11.Text = "Điểm quá trình";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(747, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 40);
            label9.TabIndex = 7;
            label9.Text = "Điểm tổng kết";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(654, 0);
            label8.Name = "label8";
            label8.Size = new Size(87, 40);
            label8.TabIndex = 6;
            label8.Text = "Điểm thi";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(375, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 40);
            label7.TabIndex = 5;
            label7.Text = "Chuyên cần";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(282, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 40);
            label6.TabIndex = 4;
            label6.Text = "Số tín chỉ";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(189, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 40);
            label5.TabIndex = 3;
            label5.Text = "Tên học phần";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(96, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 40);
            label4.TabIndex = 2;
            label4.Text = "Mã lớp học phần";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlList
            // 
            pnlList.AutoScroll = true;
            pnlList.Dock = DockStyle.Fill;
            pnlList.Location = new Point(0, 115);
            pnlList.Name = "pnlList";
            pnlList.Padding = new Padding(0, 3, 0, 0);
            pnlList.Size = new Size(967, 485);
            pnlList.TabIndex = 8;
            // 
            // Student_Score
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlList);
            Controls.Add(customPanel2);
            Controls.Add(panel1);
            Name = "Student_Score";
            Size = new Size(967, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            pnlHeaderText.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private CustomControls.CustomComboBox cmb_Semester;
        private CustomControls.CustomPanel customPanel2;
        private TableLayoutPanel pnlHeaderText;
        private Label label1;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel pnlList;
        private Label label2;
        private Label label3;
    }
}
