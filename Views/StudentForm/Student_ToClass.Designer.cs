namespace BTL.Views.StudentForm
{
    partial class Student_ToClass
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Submit = new CustomControls.CustomButton();
            btn_Exit = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            cmb_Classes = new CustomControls.CustomComboBox();
            label1 = new Label();
            cmb_Course = new CustomControls.CustomComboBox();
            label13 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btn_Submit, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_Exit, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(400, 400);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += panelContainer_Paint;
            // 
            // btn_Submit
            // 
            btn_Submit.BackColor = Color.Gray;
            btn_Submit.BorderColor = Color.PaleVioletRed;
            btn_Submit.BorderRadius = 8;
            btn_Submit.BorderSize = 0;
            btn_Submit.Dock = DockStyle.Bottom;
            btn_Submit.FlatAppearance.BorderColor = Color.Gray;
            btn_Submit.FlatAppearance.BorderSize = 0;
            btn_Submit.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 90, 255);
            btn_Submit.FlatStyle = FlatStyle.Flat;
            btn_Submit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Submit.ForeColor = Color.White;
            btn_Submit.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Submit.IconColor = Color.Black;
            btn_Submit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Submit.Location = new Point(30, 310);
            btn_Submit.Margin = new Padding(0);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(340, 60);
            btn_Submit.TabIndex = 67;
            btn_Submit.TabStop = false;
            btn_Submit.Text = "Xác nhận";
            btn_Submit.UseVisualStyleBackColor = false;
            btn_Submit.Click += Btn_Submit_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.BackColor = SystemColors.Control;
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.Dock = DockStyle.Right;
            btn_Exit.FlatAppearance.BorderColor = SystemColors.Control;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_Exit.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.IconChar = FontAwesome.Sharp.IconChar.X;
            btn_Exit.IconColor = Color.DimGray;
            btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_Exit.IconSize = 30;
            btn_Exit.Location = new Point(331, 33);
            btn_Exit.MaximumSize = new Size(36, 36);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(36, 36);
            btn_Exit.TabIndex = 13;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += Btn_Exit_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(cmb_Classes);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmb_Course);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(33, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 150);
            panel2.TabIndex = 14;
            // 
            // cmb_Classes
            // 
            cmb_Classes.BackColor = SystemColors.Control;
            cmb_Classes.BorderColor = Color.Gray;
            cmb_Classes.BorderSize = 2;
            cmb_Classes.Dock = DockStyle.Top;
            cmb_Classes.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Classes.Font = new Font("Segoe UI", 10F);
            cmb_Classes.ForeColor = Color.Gray;
            cmb_Classes.IconColor = Color.Gray;
            cmb_Classes.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Classes.ListTextColor = Color.DimGray;
            cmb_Classes.Location = new Point(0, 115);
            cmb_Classes.Margin = new Padding(0);
            cmb_Classes.MinimumSize = new Size(200, 30);
            cmb_Classes.Name = "cmb_Classes";
            cmb_Classes.Padding = new Padding(0, 0, 0, 2);
            cmb_Classes.Size = new Size(334, 35);
            cmb_Classes.TabIndex = 66;
            cmb_Classes.Texts = "";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(0, 75);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(334, 40);
            label1.TabIndex = 64;
            label1.Text = "Chọn lớp học";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_Course
            // 
            cmb_Course.BackColor = SystemColors.Control;
            cmb_Course.BorderColor = Color.Gray;
            cmb_Course.BorderSize = 2;
            cmb_Course.Dock = DockStyle.Top;
            cmb_Course.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Course.Font = new Font("Segoe UI", 10F);
            cmb_Course.ForeColor = Color.Gray;
            cmb_Course.IconColor = Color.Gray;
            cmb_Course.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Course.ListTextColor = Color.DimGray;
            cmb_Course.Location = new Point(0, 40);
            cmb_Course.Margin = new Padding(0);
            cmb_Course.MinimumSize = new Size(200, 30);
            cmb_Course.Name = "cmb_Course";
            cmb_Course.Padding = new Padding(0, 0, 0, 2);
            cmb_Course.Size = new Size(334, 35);
            cmb_Course.TabIndex = 65;
            cmb_Course.Texts = "";
            cmb_Course.OnSelectedIndexChanged += Cmb_Course_OnSelectedIndexChanged;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Top;
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 10, 0, 0);
            label13.Size = new Size(334, 40);
            label13.TabIndex = 50;
            label13.Text = "Chọn học phần";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Student_ToClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 400);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_ToClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_ToClass";
            Activated += Class_Add_Activated;
            ResizeEnd += Class_Add_ResizeEnd;
            SizeChanged += Class_Add_SizeChanged;
            Paint += Class_Add_Paint;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CustomButton btn_Submit;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private Panel panel2;
        private Label label13;
        private Label label1;
        private CustomControls.CustomComboBox cmb_Classes;
        private CustomControls.CustomComboBox cmb_Course;
    }
}