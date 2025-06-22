namespace BTL.Views.StudentForm
{
    partial class Student_Scoreboard
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
            lbl_Semester = new Label();
            pnlList = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_Semester
            // 
            lbl_Semester.BackColor = Color.Gainsboro;
            lbl_Semester.Cursor = Cursors.Hand;
            lbl_Semester.Dock = DockStyle.Top;
            lbl_Semester.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Semester.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_Semester.Location = new Point(20, 3);
            lbl_Semester.Name = "lbl_Semester";
            lbl_Semester.Padding = new Padding(15, 0, 0, 0);
            lbl_Semester.Size = new Size(860, 40);
            lbl_Semester.TabIndex = 0;
            lbl_Semester.Text = "label1";
            lbl_Semester.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Semester.Click += lblSemester_Click;
            lbl_Semester.Paint += lbl_Semester_Paint;
            // 
            // pnlList
            // 
            pnlList.AutoSize = true;
            pnlList.Dock = DockStyle.Top;
            pnlList.Location = new Point(20, 43);
            pnlList.Name = "pnlList";
            pnlList.Padding = new Padding(5, 0, 5, 0);
            pnlList.Size = new Size(860, 0);
            pnlList.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(20, 43);
            label1.Name = "label1";
            label1.Size = new Size(860, 45);
            label1.TabIndex = 2;
            label1.Text = "Không có học phần nào trong học kỳ này";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Student_Scoreboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(pnlList);
            Controls.Add(lbl_Semester);
            ForeColor = Color.DimGray;
            Name = "Student_Scoreboard";
            Padding = new Padding(20, 3, 20, 0);
            Size = new Size(900, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Semester;
        private Panel pnlList;
        private Label label1;
    }
}
