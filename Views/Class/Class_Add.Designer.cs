namespace BTL.Views.Class
{
    partial class Class_Add
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
            btnAdd = new CustomControls.CustomButton();
            btn_Exit = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            cmb_Semester = new CustomControls.CustomComboBox();
            label2 = new Label();
            cmb_Course = new CustomControls.CustomComboBox();
            label1 = new Label();
            txt_Name = new CustomControls.CustomTextBox();
            label13 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_Exit, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(30);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(600, 500);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += panelContainer_Paint;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 8;
            btnAdd.BorderSize = 0;
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.FlatAppearance.BorderColor = Color.Gray;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 90, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(30, 410);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(540, 60);
            btnAdd.TabIndex = 67;
            btnAdd.TabStop = false;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Btn_Add_Click;
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
            btn_Exit.Location = new Point(531, 33);
            btn_Exit.MaximumSize = new Size(36, 36);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(36, 36);
            btn_Exit.TabIndex = 13;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += Btn_Exit_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(cmb_Semester);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmb_Course);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(33, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 227);
            panel1.TabIndex = 14;
            // 
            // cmb_Semester
            // 
            cmb_Semester.BackColor = SystemColors.Control;
            cmb_Semester.BorderColor = Color.Gray;
            cmb_Semester.BorderSize = 2;
            cmb_Semester.Dock = DockStyle.Top;
            cmb_Semester.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Semester.Font = new Font("Segoe UI", 10F);
            cmb_Semester.ForeColor = Color.Gray;
            cmb_Semester.IconColor = Color.Gray;
            cmb_Semester.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Semester.ListTextColor = Color.DimGray;
            cmb_Semester.Location = new Point(0, 192);
            cmb_Semester.Margin = new Padding(0);
            cmb_Semester.MinimumSize = new Size(200, 30);
            cmb_Semester.Name = "cmb_Semester";
            cmb_Semester.Padding = new Padding(0, 0, 0, 2);
            cmb_Semester.Size = new Size(534, 35);
            cmb_Semester.TabIndex = 64;
            cmb_Semester.Texts = "";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 152);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(534, 40);
            label2.TabIndex = 65;
            label2.Text = "Mã học kì";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            cmb_Course.Location = new Point(0, 117);
            cmb_Course.Margin = new Padding(0);
            cmb_Course.MinimumSize = new Size(200, 30);
            cmb_Course.Name = "cmb_Course";
            cmb_Course.Padding = new Padding(0, 0, 0, 2);
            cmb_Course.Size = new Size(534, 35);
            cmb_Course.TabIndex = 62;
            cmb_Course.Texts = "";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 77);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(534, 40);
            label1.TabIndex = 63;
            label1.Text = "Chọn học phần";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            txt_Name.BackColor = SystemColors.Control;
            txt_Name.BorderColor = Color.Gray;
            txt_Name.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Name.BorderRadius = 8;
            txt_Name.BorderSize = 2;
            txt_Name.Dock = DockStyle.Top;
            txt_Name.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Name.ForeColor = Color.DimGray;
            txt_Name.Location = new Point(0, 40);
            txt_Name.Margin = new Padding(4);
            txt_Name.Multiline = false;
            txt_Name.Name = "txt_Name";
            txt_Name.Padding = new Padding(7);
            txt_Name.PasswordChar = false;
            txt_Name.PlaceholderColor = Color.DarkGray;
            txt_Name.PlaceholderText = "";
            txt_Name.Size = new Size(534, 37);
            txt_Name.TabIndex = 51;
            txt_Name.TextAlign = HorizontalAlignment.Left;
            txt_Name.Texts = "";
            txt_Name.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Top;
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 10, 0, 0);
            label13.Size = new Size(534, 40);
            label13.TabIndex = 50;
            label13.Text = "Tên lớp học";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Class_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(600, 500);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Class_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class_Add";
            Activated += Class_Add_Activated;
            ResizeEnd += Class_Add_ResizeEnd;
            SizeChanged += Class_Add_SizeChanged;
            Paint += Class_Add_Paint;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private Panel panel1;
        private CustomControls.CustomTextBox txt_Name;
        private Label label13;
        private CustomControls.CustomComboBox cmb_Semester;
        private Label label2;
        private CustomControls.CustomComboBox cmb_Course;
        private Label label1;
        private CustomControls.CustomButton btnAdd;
    }
}