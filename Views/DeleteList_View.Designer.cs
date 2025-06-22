namespace BTL.Views
{
    partial class DeleteList_View
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlTab = new CustomControls.CustomPanel();
            panel3 = new Panel();
            dgvList = new DataGridView();
            customPanel2 = new CustomControls.CustomPanel();
            pnlHeaderText = new TableLayoutPanel();
            lbl_ID = new Label();
            lbl_Name = new Label();
            pnlCoverBorder = new Panel();
            pnlTabBar = new FlowLayoutPanel();
            btn_Major = new CustomControls.CustomButton();
            btn_Semester = new CustomControls.CustomButton();
            btn_Course = new CustomControls.CustomButton();
            btn_CourseCat = new CustomControls.CustomButton();
            btn_Class = new CustomControls.CustomButton();
            btn_Student = new CustomControls.CustomButton();
            tableLayoutPanel1.SuspendLayout();
            pnlTab.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            customPanel2.SuspendLayout();
            pnlHeaderText.SuspendLayout();
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
            label1.Size = new Size(1065, 65);
            label1.TabIndex = 2;
            label1.Text = "Thùng rác";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlTab, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlTabBar, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 95);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1065, 577);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlTab
            // 
            pnlTab.BackColor1 = Color.White;
            pnlTab.BackColor2 = Color.White;
            pnlTab.BorderColor = Color.Gray;
            pnlTab.BorderSize = 2;
            pnlTab.Controls.Add(panel3);
            pnlTab.Controls.Add(customPanel2);
            pnlTab.Controls.Add(pnlCoverBorder);
            pnlTab.Dock = DockStyle.Fill;
            pnlTab.GradientAngle = 20F;
            pnlTab.Location = new Point(200, 0);
            pnlTab.Margin = new Padding(0);
            pnlTab.Name = "pnlTab";
            pnlTab.Padding = new Padding(15);
            pnlTab.Radius = new Padding(20);
            pnlTab.Size = new Size(865, 577);
            pnlTab.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvList);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(15, 65);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15, 0, 15, 0);
            panel3.Size = new Size(835, 497);
            panel3.TabIndex = 248;
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
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(805, 497);
            dgvList.TabIndex = 0;
            dgvList.ColumnAdded += dgvList_ColumnAdded;
            dgvList.SizeChanged += DgvList_SizeChanged;
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
            customPanel2.Location = new Point(15, 15);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(15, 5, 15, 5);
            customPanel2.Radius = new Padding(15);
            customPanel2.Size = new Size(835, 50);
            customPanel2.TabIndex = 247;
            // 
            // pnlHeaderText
            // 
            pnlHeaderText.BackColor = Color.Transparent;
            pnlHeaderText.ColumnCount = 2;
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlHeaderText.Controls.Add(lbl_ID, 0, 0);
            pnlHeaderText.Controls.Add(lbl_Name, 1, 0);
            pnlHeaderText.Dock = DockStyle.Fill;
            pnlHeaderText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderText.Location = new Point(15, 5);
            pnlHeaderText.Margin = new Padding(0);
            pnlHeaderText.Name = "pnlHeaderText";
            pnlHeaderText.RowCount = 1;
            pnlHeaderText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeaderText.Size = new Size(805, 40);
            pnlHeaderText.TabIndex = 0;
            // 
            // lbl_ID
            // 
            lbl_ID.Dock = DockStyle.Fill;
            lbl_ID.Location = new Point(3, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(396, 40);
            lbl_ID.TabIndex = 4;
            lbl_ID.Text = "Mã ngành";
            lbl_ID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Name
            // 
            lbl_Name.Dock = DockStyle.Fill;
            lbl_Name.Location = new Point(405, 0);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(397, 40);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Tên ngành";
            lbl_Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlCoverBorder
            // 
            pnlCoverBorder.Location = new Point(0, 33);
            pnlCoverBorder.Name = "pnlCoverBorder";
            pnlCoverBorder.Size = new Size(5, 48);
            pnlCoverBorder.TabIndex = 246;
            // 
            // pnlTabBar
            // 
            pnlTabBar.BackColor = Color.White;
            pnlTabBar.Controls.Add(btn_Major);
            pnlTabBar.Controls.Add(btn_Semester);
            pnlTabBar.Controls.Add(btn_Course);
            pnlTabBar.Controls.Add(btn_CourseCat);
            pnlTabBar.Controls.Add(btn_Class);
            pnlTabBar.Controls.Add(btn_Student);
            pnlTabBar.Dock = DockStyle.Fill;
            pnlTabBar.FlowDirection = FlowDirection.TopDown;
            pnlTabBar.Location = new Point(0, 0);
            pnlTabBar.Margin = new Padding(0);
            pnlTabBar.Name = "pnlTabBar";
            pnlTabBar.Padding = new Padding(0, 30, 0, 0);
            pnlTabBar.Size = new Size(200, 577);
            pnlTabBar.TabIndex = 0;
            // 
            // btn_Major
            // 
            btn_Major.BackColor = Color.White;
            btn_Major.BorderColor = Color.Gray;
            btn_Major.BorderRadius = 10;
            btn_Major.BorderSize = 2;
            btn_Major.FlatAppearance.BorderColor = Color.White;
            btn_Major.FlatAppearance.BorderSize = 0;
            btn_Major.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Major.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Major.FlatStyle = FlatStyle.Flat;
            btn_Major.ForeColor = Color.Gray;
            btn_Major.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Major.IconColor = Color.Black;
            btn_Major.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Major.Location = new Point(0, 30);
            btn_Major.Margin = new Padding(0, 0, 3, 3);
            btn_Major.Name = "btn_Major";
            btn_Major.Padding = new Padding(25, 0, 0, 0);
            btn_Major.Size = new Size(207, 55);
            btn_Major.TabIndex = 1;
            btn_Major.TabStop = false;
            btn_Major.Tag = "2";
            btn_Major.Text = "Ngành học";
            btn_Major.TextAlign = ContentAlignment.MiddleLeft;
            btn_Major.UseVisualStyleBackColor = false;
            btn_Major.Click += Btn_Major_Click;
            // 
            // btn_Semester
            // 
            btn_Semester.BackColor = Color.White;
            btn_Semester.BorderColor = Color.Gray;
            btn_Semester.BorderRadius = 10;
            btn_Semester.BorderSize = 2;
            btn_Semester.FlatAppearance.BorderColor = Color.White;
            btn_Semester.FlatAppearance.BorderSize = 0;
            btn_Semester.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Semester.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Semester.FlatStyle = FlatStyle.Flat;
            btn_Semester.ForeColor = Color.Gray;
            btn_Semester.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Semester.IconColor = Color.Black;
            btn_Semester.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Semester.Location = new Point(0, 88);
            btn_Semester.Margin = new Padding(0, 0, 3, 3);
            btn_Semester.Name = "btn_Semester";
            btn_Semester.Padding = new Padding(25, 0, 0, 0);
            btn_Semester.Size = new Size(207, 55);
            btn_Semester.TabIndex = 2;
            btn_Semester.TabStop = false;
            btn_Semester.Tag = "2";
            btn_Semester.Text = "Học kỳ";
            btn_Semester.TextAlign = ContentAlignment.MiddleLeft;
            btn_Semester.UseVisualStyleBackColor = false;
            btn_Semester.Click += btn_Semester_Click;
            // 
            // btn_Course
            // 
            btn_Course.BackColor = Color.White;
            btn_Course.BorderColor = Color.Gray;
            btn_Course.BorderRadius = 10;
            btn_Course.BorderSize = 2;
            btn_Course.FlatAppearance.BorderColor = Color.White;
            btn_Course.FlatAppearance.BorderSize = 0;
            btn_Course.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Course.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Course.FlatStyle = FlatStyle.Flat;
            btn_Course.ForeColor = Color.Gray;
            btn_Course.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Course.IconColor = Color.Black;
            btn_Course.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Course.Location = new Point(0, 146);
            btn_Course.Margin = new Padding(0, 0, 3, 3);
            btn_Course.Name = "btn_Course";
            btn_Course.Padding = new Padding(25, 0, 0, 0);
            btn_Course.Size = new Size(207, 55);
            btn_Course.TabIndex = 3;
            btn_Course.TabStop = false;
            btn_Course.Tag = "2";
            btn_Course.Text = "Học phần";
            btn_Course.TextAlign = ContentAlignment.MiddleLeft;
            btn_Course.UseVisualStyleBackColor = false;
            btn_Course.Click += btn_Course_Click;
            // 
            // btn_CourseCat
            // 
            btn_CourseCat.BackColor = Color.White;
            btn_CourseCat.BorderColor = Color.Gray;
            btn_CourseCat.BorderRadius = 10;
            btn_CourseCat.BorderSize = 2;
            btn_CourseCat.FlatAppearance.BorderColor = Color.White;
            btn_CourseCat.FlatAppearance.BorderSize = 0;
            btn_CourseCat.FlatAppearance.MouseDownBackColor = Color.White;
            btn_CourseCat.FlatAppearance.MouseOverBackColor = Color.White;
            btn_CourseCat.FlatStyle = FlatStyle.Flat;
            btn_CourseCat.ForeColor = Color.Gray;
            btn_CourseCat.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_CourseCat.IconColor = Color.Black;
            btn_CourseCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CourseCat.Location = new Point(0, 204);
            btn_CourseCat.Margin = new Padding(0, 0, 3, 3);
            btn_CourseCat.Name = "btn_CourseCat";
            btn_CourseCat.Padding = new Padding(25, 0, 0, 0);
            btn_CourseCat.Size = new Size(207, 55);
            btn_CourseCat.TabIndex = 4;
            btn_CourseCat.TabStop = false;
            btn_CourseCat.Tag = "2";
            btn_CourseCat.Text = "Nhóm học phần";
            btn_CourseCat.TextAlign = ContentAlignment.MiddleLeft;
            btn_CourseCat.UseVisualStyleBackColor = false;
            btn_CourseCat.Click += btn_CourseCat_Click;
            // 
            // btn_Class
            // 
            btn_Class.BackColor = Color.White;
            btn_Class.BorderColor = Color.Gray;
            btn_Class.BorderRadius = 10;
            btn_Class.BorderSize = 2;
            btn_Class.FlatAppearance.BorderColor = Color.White;
            btn_Class.FlatAppearance.BorderSize = 0;
            btn_Class.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Class.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Class.FlatStyle = FlatStyle.Flat;
            btn_Class.ForeColor = Color.Gray;
            btn_Class.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Class.IconColor = Color.Black;
            btn_Class.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Class.Location = new Point(0, 262);
            btn_Class.Margin = new Padding(0, 0, 3, 3);
            btn_Class.Name = "btn_Class";
            btn_Class.Padding = new Padding(25, 0, 0, 0);
            btn_Class.Size = new Size(207, 55);
            btn_Class.TabIndex = 5;
            btn_Class.TabStop = false;
            btn_Class.Tag = "2";
            btn_Class.Text = "Lớp học";
            btn_Class.TextAlign = ContentAlignment.MiddleLeft;
            btn_Class.UseVisualStyleBackColor = false;
            btn_Class.Click += btn_Class_Click;
            // 
            // btn_Student
            // 
            btn_Student.BackColor = Color.White;
            btn_Student.BorderColor = Color.Gray;
            btn_Student.BorderRadius = 10;
            btn_Student.BorderSize = 2;
            btn_Student.FlatAppearance.BorderColor = Color.White;
            btn_Student.FlatAppearance.BorderSize = 0;
            btn_Student.FlatAppearance.MouseDownBackColor = Color.White;
            btn_Student.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Student.FlatStyle = FlatStyle.Flat;
            btn_Student.ForeColor = Color.Gray;
            btn_Student.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Student.IconColor = Color.Black;
            btn_Student.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Student.Location = new Point(0, 320);
            btn_Student.Margin = new Padding(0, 0, 3, 3);
            btn_Student.Name = "btn_Student";
            btn_Student.Padding = new Padding(25, 0, 0, 0);
            btn_Student.Size = new Size(207, 55);
            btn_Student.TabIndex = 6;
            btn_Student.TabStop = false;
            btn_Student.Tag = "2";
            btn_Student.Text = "Sinh viên";
            btn_Student.TextAlign = ContentAlignment.MiddleLeft;
            btn_Student.UseVisualStyleBackColor = false;
            btn_Student.Click += btn_Student_Click;
            // 
            // DeleteList_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "DeleteList_View";
            Padding = new Padding(30);
            Size = new Size(1125, 702);
            tableLayoutPanel1.ResumeLayout(false);
            pnlTab.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            customPanel2.ResumeLayout(false);
            pnlHeaderText.ResumeLayout(false);
            pnlTabBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel pnlTabBar;
        private CustomControls.CustomButton btn_Major;
        private CustomControls.CustomButton btn_Semester;
        private CustomControls.CustomButton btn_Course;
        private CustomControls.CustomButton btn_CourseCat;
        private CustomControls.CustomButton btn_Class;
        private CustomControls.CustomButton btn_Student;
        private CustomControls.CustomPanel pnlTab;
        private Panel pnlCoverBorder;
        private Panel panel3;
        private DataGridView dgvList;
        private CustomControls.CustomPanel customPanel2;
        private TableLayoutPanel pnlHeaderText;
        private Label lbl_ID;
        private Label lbl_Name;
    }
}
