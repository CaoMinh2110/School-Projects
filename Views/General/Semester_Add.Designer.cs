namespace BTL.Views.General
{
    partial class Semester_Add
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
            txt_Year = new CustomControls.CustomNumbericUpDown();
            label2 = new Label();
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
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += PanelContainer_Paint;
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
            btnAdd.Location = new Point(30, 310);
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
            panel1.Controls.Add(txt_Year);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(33, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 151);
            panel1.TabIndex = 14;
            // 
            // txt_Year
            // 
            txt_Year.BackColor = SystemColors.Control;
            txt_Year.BorderColor = Color.Gray;
            txt_Year.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Year.BorderRadius = 8;
            txt_Year.BorderSize = 2;
            txt_Year.DecimalPlaces = 0;
            txt_Year.Dock = DockStyle.Top;
            txt_Year.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Year.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Year.Location = new Point(0, 114);
            txt_Year.Margin = new Padding(4);
            txt_Year.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            txt_Year.Minimun = new decimal(new int[] { 1000, 0, 0, 0 });
            txt_Year.Name = "txt_Year";
            txt_Year.Padding = new Padding(7);
            txt_Year.Size = new Size(534, 37);
            txt_Year.TabIndex = 64;
            txt_Year.TextAlign = HorizontalAlignment.Left;
            txt_Year.Texts = "1000";
            txt_Year.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 74);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(534, 40);
            label2.TabIndex = 63;
            label2.Text = "Năm học";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            txt_Name.Size = new Size(534, 34);
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
            label13.Text = "Tên học kỳ";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Semester_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Semester_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Semester_Add";
            Activated += SemesterAdd_Activated;
            ResizeEnd += SemesterAdd_ResizeEnd;
            SizeChanged += SemesterAdd_SizeChanged;
            Paint += SemesterAdd_Paint;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CustomButton btnAdd;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private Panel panel1;
        private Label label2;
        private CustomControls.CustomTextBox txt_Name;
        private Label label13;
        private CustomControls.CustomNumbericUpDown txt_Year;
    }
}