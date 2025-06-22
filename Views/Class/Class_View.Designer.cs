namespace BTL.Views.Class
{
    partial class Class_View
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            btnEdit = new CustomControls.CustomButton();
            btnDelete = new CustomControls.CustomButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            cmb_Semester = new CustomControls.CustomComboBox();
            customButton1 = new CustomControls.CustomButton();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            cmb_Course = new CustomControls.CustomComboBox();
            btnCourseCatAdd = new CustomControls.CustomButton();
            label1 = new Label();
            txt_Name = new CustomControls.CustomTextBox();
            label6 = new Label();
            txt_ID = new CustomControls.CustomTextBox();
            label8 = new Label();
            customPanel1 = new CustomControls.CustomPanel();
            pnlScroll = new Panel();
            dgvList = new DataGridView();
            panel4 = new CustomControls.CustomPanel();
            pnlHeaderText = new TableLayoutPanel();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            customPanel1.SuspendLayout();
            pnlScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            panel4.SuspendLayout();
            pnlHeaderText.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(customPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1210, 621);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(789, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(418, 615);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_Name);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_ID);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(398, 595);
            panel2.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Bottom;
            splitContainer1.Location = new Point(10, 525);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnEdit);
            splitContainer1.Panel1.Padding = new Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnDelete);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(378, 60);
            splitContainer1.SplitterDistance = 185;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 43;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gray;
            btnEdit.BorderColor = Color.PaleVioletRed;
            btnEdit.BorderRadius = 8;
            btnEdit.BorderSize = 0;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderColor = Color.Gray;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEdit.IconColor = Color.Black;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.Location = new Point(10, 10);
            btnEdit.Margin = new Padding(10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(165, 40);
            btnEdit.TabIndex = 1;
            btnEdit.TabStop = false;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Gray;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 8;
            btnDelete.BorderSize = 0;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = Color.Gray;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(10, 10);
            btnDelete.Margin = new Padding(10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 40);
            btnDelete.TabIndex = 2;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(cmb_Semester, 0, 0);
            tableLayoutPanel4.Controls.Add(customButton1, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(10, 273);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(378, 35);
            tableLayoutPanel4.TabIndex = 42;
            // 
            // cmb_Semester
            // 
            cmb_Semester.BackColor = Color.White;
            cmb_Semester.BorderColor = Color.Gray;
            cmb_Semester.BorderSize = 2;
            cmb_Semester.Dock = DockStyle.Top;
            cmb_Semester.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Semester.Font = new Font("Segoe UI", 10F);
            cmb_Semester.ForeColor = Color.DimGray;
            cmb_Semester.IconColor = Color.Gray;
            cmb_Semester.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Semester.ListTextColor = Color.DimGray;
            cmb_Semester.Location = new Point(0, 0);
            cmb_Semester.Margin = new Padding(0);
            cmb_Semester.MinimumSize = new Size(200, 30);
            cmb_Semester.Name = "cmb_Semester";
            cmb_Semester.Padding = new Padding(0, 0, 0, 2);
            cmb_Semester.Size = new Size(333, 35);
            cmb_Semester.TabIndex = 21;
            cmb_Semester.Texts = "";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Gray;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 5;
            customButton1.BorderSize = 0;
            customButton1.Dock = DockStyle.Fill;
            customButton1.FlatAppearance.BorderColor = Color.Gray;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            customButton1.IconColor = Color.White;
            customButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            customButton1.IconSize = 22;
            customButton1.Location = new Point(346, 3);
            customButton1.Margin = new Padding(13, 3, 3, 3);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(29, 29);
            customButton1.TabIndex = 22;
            customButton1.TabStop = false;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += SemesterAdd_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(10, 233);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(378, 40);
            label2.TabIndex = 41;
            label2.Text = "Học kỳ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(cmb_Course, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCourseCatAdd, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(10, 198);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(378, 35);
            tableLayoutPanel3.TabIndex = 40;
            // 
            // cmb_Course
            // 
            cmb_Course.BackColor = Color.White;
            cmb_Course.BorderColor = Color.Gray;
            cmb_Course.BorderSize = 2;
            cmb_Course.Dock = DockStyle.Top;
            cmb_Course.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Course.Font = new Font("Segoe UI", 10F);
            cmb_Course.ForeColor = Color.DimGray;
            cmb_Course.IconColor = Color.Gray;
            cmb_Course.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Course.ListTextColor = Color.DimGray;
            cmb_Course.Location = new Point(0, 0);
            cmb_Course.Margin = new Padding(0);
            cmb_Course.MinimumSize = new Size(200, 30);
            cmb_Course.Name = "cmb_Course";
            cmb_Course.Padding = new Padding(0, 0, 0, 2);
            cmb_Course.Size = new Size(333, 35);
            cmb_Course.TabIndex = 21;
            cmb_Course.Texts = "";
            // 
            // btnCourseCatAdd
            // 
            btnCourseCatAdd.BackColor = Color.Gray;
            btnCourseCatAdd.BorderColor = Color.PaleVioletRed;
            btnCourseCatAdd.BorderRadius = 5;
            btnCourseCatAdd.BorderSize = 0;
            btnCourseCatAdd.Dock = DockStyle.Fill;
            btnCourseCatAdd.FlatAppearance.BorderColor = Color.Gray;
            btnCourseCatAdd.FlatAppearance.BorderSize = 0;
            btnCourseCatAdd.FlatStyle = FlatStyle.Flat;
            btnCourseCatAdd.ForeColor = Color.White;
            btnCourseCatAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnCourseCatAdd.IconColor = Color.White;
            btnCourseCatAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCourseCatAdd.IconSize = 22;
            btnCourseCatAdd.Location = new Point(346, 3);
            btnCourseCatAdd.Margin = new Padding(13, 3, 3, 3);
            btnCourseCatAdd.Name = "btnCourseCatAdd";
            btnCourseCatAdd.Size = new Size(29, 29);
            btnCourseCatAdd.TabIndex = 22;
            btnCourseCatAdd.TabStop = false;
            btnCourseCatAdd.UseVisualStyleBackColor = false;
            btnCourseCatAdd.Click += BtnCourseCatAdd_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(10, 158);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(378, 40);
            label1.TabIndex = 39;
            label1.Text = "Học phần";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            txt_Name.BackColor = Color.White;
            txt_Name.BorderColor = Color.Gray;
            txt_Name.BorderFocusColor = Color.Blue;
            txt_Name.BorderRadius = 8;
            txt_Name.BorderSize = 2;
            txt_Name.Dock = DockStyle.Top;
            txt_Name.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Name.ForeColor = Color.DimGray;
            txt_Name.Location = new Point(10, 124);
            txt_Name.Margin = new Padding(4);
            txt_Name.Multiline = false;
            txt_Name.Name = "txt_Name";
            txt_Name.Padding = new Padding(7);
            txt_Name.PasswordChar = false;
            txt_Name.PlaceholderColor = Color.DimGray;
            txt_Name.PlaceholderText = "";
            txt_Name.Size = new Size(378, 34);
            txt_Name.TabIndex = 38;
            txt_Name.TextAlign = HorizontalAlignment.Left;
            txt_Name.Texts = "";
            txt_Name.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(10, 84);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 10, 0, 0);
            label6.Size = new Size(378, 40);
            label6.TabIndex = 24;
            label6.Text = "Tên lớp";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_ID
            // 
            txt_ID.BackColor = SystemColors.Window;
            txt_ID.BorderColor = Color.Gray;
            txt_ID.BorderFocusColor = Color.Blue;
            txt_ID.BorderRadius = 8;
            txt_ID.BorderSize = 2;
            txt_ID.Dock = DockStyle.Top;
            txt_ID.Enabled = false;
            txt_ID.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ID.ForeColor = Color.DimGray;
            txt_ID.Location = new Point(10, 50);
            txt_ID.Margin = new Padding(4);
            txt_ID.Multiline = false;
            txt_ID.Name = "txt_ID";
            txt_ID.Padding = new Padding(7);
            txt_ID.PasswordChar = false;
            txt_ID.PlaceholderColor = Color.DimGray;
            txt_ID.PlaceholderText = "";
            txt_ID.Size = new Size(378, 34);
            txt_ID.TabIndex = 46;
            txt_ID.TextAlign = HorizontalAlignment.Left;
            txt_ID.Texts = "";
            txt_ID.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(10, 10);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 10, 0, 0);
            label8.Size = new Size(378, 40);
            label8.TabIndex = 44;
            label8.Text = "Mã lớp";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // customPanel1
            // 
            customPanel1.BackColor1 = Color.White;
            customPanel1.BackColor2 = Color.White;
            customPanel1.BorderColor = Color.Gray;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(pnlScroll);
            customPanel1.Controls.Add(panel4);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.GradientAngle = 20F;
            customPanel1.Location = new Point(3, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(10);
            customPanel1.Radius = new Padding(20);
            customPanel1.Size = new Size(780, 615);
            customPanel1.TabIndex = 2;
            // 
            // pnlScroll
            // 
            pnlScroll.AutoScroll = true;
            pnlScroll.BackColor = Color.White;
            pnlScroll.Controls.Add(dgvList);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(10, 60);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Padding = new Padding(15, 0, 15, 0);
            pnlScroll.Size = new Size(760, 545);
            pnlScroll.TabIndex = 10;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AllowUserToResizeColumns = false;
            dgvList.AllowUserToResizeRows = false;
            dgvList.BackgroundColor = Color.White;
            dgvList.BorderStyle = BorderStyle.None;
            dgvList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(15, 0);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvList.RowHeadersVisible = false;
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 40;
            dgvList.ScrollBars = ScrollBars.Vertical;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(730, 545);
            dgvList.TabIndex = 0;
            dgvList.CellClick += DgvList_CellClick;
            dgvList.SizeChanged += DgvList_SizeChanged;
            // 
            // panel4
            // 
            panel4.BackColor1 = Color.Silver;
            panel4.BackColor2 = Color.Silver;
            panel4.BorderColor = Color.Black;
            panel4.BorderSize = 0;
            panel4.Controls.Add(pnlHeaderText);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = Color.FromArgb(64, 64, 64);
            panel4.GradientAngle = 20F;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 5, 15, 5);
            panel4.Radius = new Padding(15);
            panel4.Size = new Size(760, 50);
            panel4.TabIndex = 9;
            // 
            // pnlHeaderText
            // 
            pnlHeaderText.BackColor = Color.Transparent;
            pnlHeaderText.ColumnCount = 4;
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9981289F));
            pnlHeaderText.Controls.Add(label7, 0, 0);
            pnlHeaderText.Controls.Add(label5, 3, 0);
            pnlHeaderText.Controls.Add(label3, 1, 0);
            pnlHeaderText.Controls.Add(label4, 2, 0);
            pnlHeaderText.Dock = DockStyle.Fill;
            pnlHeaderText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderText.Location = new Point(15, 5);
            pnlHeaderText.Margin = new Padding(0);
            pnlHeaderText.Name = "pnlHeaderText";
            pnlHeaderText.RowCount = 1;
            pnlHeaderText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeaderText.Size = new Size(730, 40);
            pnlHeaderText.TabIndex = 0;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(176, 40);
            label7.TabIndex = 6;
            label7.Text = "Mã lớp học phần";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(549, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 40);
            label5.TabIndex = 5;
            label5.Text = "Học kỳ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(185, 0);
            label3.Name = "label3";
            label3.Size = new Size(176, 40);
            label3.TabIndex = 4;
            label3.Text = "Tên lớp học phần";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(367, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 40);
            label4.TabIndex = 2;
            label4.Text = "Học phần";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Class_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "Class_View";
            Size = new Size(1210, 621);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            pnlScroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            panel4.ResumeLayout(false);
            pnlHeaderText.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private CustomControls.CustomButton btnDelete;
        private CustomControls.CustomButton btnEdit;
        private CustomControls.CustomPanel customPanel1;
        private Panel pnlScroll;
        private DataGridView dgvList;
        private CustomControls.CustomPanel panel4;
        private TableLayoutPanel pnlHeaderText;
        private Label label3;
        private Label label4;
        private Label label6;
        private CustomControls.CustomTextBox txt_Name;
        private TableLayoutPanel tableLayoutPanel4;
        private CustomControls.CustomComboBox cmb_Semester;
        private CustomControls.CustomButton customButton1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.CustomComboBox cmb_Course;
        private CustomControls.CustomButton btnCourseCatAdd;
        private Label label1;
        private SplitContainer splitContainer1;
        private Label label7;
        private Label label5;
        private Label label8;
        private CustomControls.CustomTextBox txt_ID;
    }
}
