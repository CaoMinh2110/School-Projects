namespace BTL.Views
{
    partial class Course_View
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
            customPanel1 = new CustomControls.CustomPanel();
            pnlScroll = new Panel();
            dgvList = new DataGridView();
            panel4 = new CustomControls.CustomPanel();
            pnlHeaderText = new TableLayoutPanel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txt_Point = new CustomControls.CustomNumbericUpDown();
            label2 = new Label();
            txt_Absences = new CustomControls.CustomNumbericUpDown();
            label9 = new Label();
            txt_Session = new CustomControls.CustomNumbericUpDown();
            label10 = new Label();
            txt_Credit = new CustomControls.CustomNumbericUpDown();
            label11 = new Label();
            txt_Name = new CustomControls.CustomTextBox();
            label12 = new Label();
            txt_Code = new CustomControls.CustomTextBox();
            label13 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            cmb_CatID = new CustomControls.CustomComboBox();
            btnCourseCatAdd = new CustomControls.CustomButton();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            btnEdit = new CustomControls.CustomButton();
            btnDelete = new CustomControls.CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            customPanel1.SuspendLayout();
            pnlScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            panel4.SuspendLayout();
            pnlHeaderText.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            customPanel1.Size = new Size(745, 699);
            customPanel1.TabIndex = 2;
            // 
            // pnlScroll
            // 
            pnlScroll.BackColor = Color.White;
            pnlScroll.Controls.Add(dgvList);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(10, 60);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Padding = new Padding(15, 0, 15, 0);
            pnlScroll.Size = new Size(725, 629);
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
            dgvList.Size = new Size(695, 629);
            dgvList.TabIndex = 0;
            dgvList.CellClick += DgvList_CellClick;
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
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
            panel4.Size = new Size(725, 50);
            panel4.TabIndex = 9;
            // 
            // pnlHeaderText
            // 
            pnlHeaderText.BackColor = Color.Transparent;
            pnlHeaderText.ColumnCount = 6;
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1881142F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0065975F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2013216F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2013216F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2013216F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2013226F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlHeaderText.Controls.Add(label8, 5, 0);
            pnlHeaderText.Controls.Add(label7, 4, 0);
            pnlHeaderText.Controls.Add(label6, 3, 0);
            pnlHeaderText.Controls.Add(label3, 0, 0);
            pnlHeaderText.Controls.Add(label5, 2, 0);
            pnlHeaderText.Controls.Add(label4, 1, 0);
            pnlHeaderText.Dock = DockStyle.Fill;
            pnlHeaderText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderText.Location = new Point(15, 5);
            pnlHeaderText.Margin = new Padding(0);
            pnlHeaderText.Name = "pnlHeaderText";
            pnlHeaderText.RowCount = 1;
            pnlHeaderText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeaderText.Size = new Size(695, 40);
            pnlHeaderText.TabIndex = 0;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(603, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 40);
            label8.TabIndex = 7;
            label8.Text = "Điểm qua môn";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(512, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 40);
            label7.TabIndex = 6;
            label7.Text = "Số buổi vắng \r\ntối đa";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(421, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 40);
            label6.TabIndex = 5;
            label6.Text = "Số tiết";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 40);
            label3.TabIndex = 4;
            label3.Text = "Mã học phần";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(330, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 40);
            label5.TabIndex = 3;
            label5.Text = "Số tín chỉ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(122, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 40);
            label4.TabIndex = 2;
            label4.Text = "Tên học phần";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(754, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(399, 699);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(txt_Point);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_Absences);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txt_Session);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txt_Credit);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txt_Name);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txt_Code);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 639);
            panel2.TabIndex = 3;
            // 
            // txt_Point
            // 
            txt_Point.BackColor = SystemColors.Window;
            txt_Point.BorderColor = Color.Gray;
            txt_Point.BorderFocusColor = Color.Blue;
            txt_Point.BorderRadius = 8;
            txt_Point.BorderSize = 2;
            txt_Point.DecimalPlaces = 2;
            txt_Point.Dock = DockStyle.Top;
            txt_Point.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Point.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Point.Location = new Point(0, 494);
            txt_Point.Margin = new Padding(4);
            txt_Point.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txt_Point.Minimun = new decimal(new int[] { 0, 0, 0, 0 });
            txt_Point.Name = "txt_Point";
            txt_Point.Padding = new Padding(7);
            txt_Point.Size = new Size(379, 37);
            txt_Point.TabIndex = 45;
            txt_Point.TextAlign = HorizontalAlignment.Left;
            txt_Point.Texts = "";
            txt_Point.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 454);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(379, 40);
            label2.TabIndex = 44;
            label2.Text = "Điểm qua môn";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Absences
            // 
            txt_Absences.BackColor = SystemColors.Window;
            txt_Absences.BorderColor = Color.Gray;
            txt_Absences.BorderFocusColor = Color.Blue;
            txt_Absences.BorderRadius = 8;
            txt_Absences.BorderSize = 2;
            txt_Absences.DecimalPlaces = 0;
            txt_Absences.Dock = DockStyle.Top;
            txt_Absences.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Absences.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Absences.Location = new Point(0, 417);
            txt_Absences.Margin = new Padding(4);
            txt_Absences.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            txt_Absences.Minimun = new decimal(new int[] { 0, 0, 0, 0 });
            txt_Absences.Name = "txt_Absences";
            txt_Absences.Padding = new Padding(7);
            txt_Absences.Size = new Size(379, 37);
            txt_Absences.TabIndex = 43;
            txt_Absences.TextAlign = HorizontalAlignment.Left;
            txt_Absences.Texts = "";
            txt_Absences.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(0, 377);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 10, 0, 0);
            label9.Size = new Size(379, 40);
            label9.TabIndex = 42;
            label9.Text = "Số buổi vắng tối đa";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Session
            // 
            txt_Session.BackColor = SystemColors.Window;
            txt_Session.BorderColor = Color.Gray;
            txt_Session.BorderFocusColor = Color.Blue;
            txt_Session.BorderRadius = 8;
            txt_Session.BorderSize = 2;
            txt_Session.DecimalPlaces = 0;
            txt_Session.Dock = DockStyle.Top;
            txt_Session.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Session.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Session.Location = new Point(0, 340);
            txt_Session.Margin = new Padding(4);
            txt_Session.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            txt_Session.Minimun = new decimal(new int[] { 0, 0, 0, 0 });
            txt_Session.Name = "txt_Session";
            txt_Session.Padding = new Padding(7);
            txt_Session.Size = new Size(379, 37);
            txt_Session.TabIndex = 41;
            txt_Session.TextAlign = HorizontalAlignment.Left;
            txt_Session.Texts = "";
            txt_Session.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(0, 300);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 10, 0, 0);
            label10.Size = new Size(379, 40);
            label10.TabIndex = 40;
            label10.Text = "Số tiết";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Credit
            // 
            txt_Credit.BackColor = SystemColors.Window;
            txt_Credit.BorderColor = Color.Gray;
            txt_Credit.BorderFocusColor = Color.Blue;
            txt_Credit.BorderRadius = 8;
            txt_Credit.BorderSize = 2;
            txt_Credit.DecimalPlaces = 0;
            txt_Credit.Dock = DockStyle.Top;
            txt_Credit.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Credit.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Credit.Location = new Point(0, 263);
            txt_Credit.Margin = new Padding(4);
            txt_Credit.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txt_Credit.Minimun = new decimal(new int[] { 0, 0, 0, 0 });
            txt_Credit.Name = "txt_Credit";
            txt_Credit.Padding = new Padding(7);
            txt_Credit.Size = new Size(379, 37);
            txt_Credit.TabIndex = 39;
            txt_Credit.TextAlign = HorizontalAlignment.Left;
            txt_Credit.Texts = "";
            txt_Credit.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Dock = DockStyle.Top;
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(0, 223);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 10, 0, 0);
            label11.Size = new Size(379, 40);
            label11.TabIndex = 38;
            label11.Text = "Số tín chỉ";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            txt_Name.BackColor = SystemColors.Window;
            txt_Name.BorderColor = Color.Gray;
            txt_Name.BorderFocusColor = Color.Blue;
            txt_Name.BorderRadius = 8;
            txt_Name.BorderSize = 2;
            txt_Name.Dock = DockStyle.Top;
            txt_Name.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Name.ForeColor = Color.DimGray;
            txt_Name.Location = new Point(0, 189);
            txt_Name.Margin = new Padding(4);
            txt_Name.Multiline = false;
            txt_Name.Name = "txt_Name";
            txt_Name.Padding = new Padding(7);
            txt_Name.PasswordChar = false;
            txt_Name.PlaceholderColor = Color.DimGray;
            txt_Name.PlaceholderText = "";
            txt_Name.Size = new Size(379, 34);
            txt_Name.TabIndex = 37;
            txt_Name.TextAlign = HorizontalAlignment.Left;
            txt_Name.Texts = "";
            txt_Name.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Top;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(0, 149);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 10, 0, 0);
            label12.Size = new Size(379, 40);
            label12.TabIndex = 36;
            label12.Text = "Tên học phần";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Code
            // 
            txt_Code.BackColor = SystemColors.Window;
            txt_Code.BorderColor = Color.Gray;
            txt_Code.BorderFocusColor = Color.Blue;
            txt_Code.BorderRadius = 8;
            txt_Code.BorderSize = 2;
            txt_Code.Dock = DockStyle.Top;
            txt_Code.Enabled = false;
            txt_Code.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Code.ForeColor = Color.DimGray;
            txt_Code.Location = new Point(0, 115);
            txt_Code.Margin = new Padding(4);
            txt_Code.Multiline = false;
            txt_Code.Name = "txt_Code";
            txt_Code.Padding = new Padding(7);
            txt_Code.PasswordChar = false;
            txt_Code.PlaceholderColor = Color.DimGray;
            txt_Code.PlaceholderText = "";
            txt_Code.Size = new Size(379, 34);
            txt_Code.TabIndex = 35;
            txt_Code.TextAlign = HorizontalAlignment.Left;
            txt_Code.Texts = "";
            txt_Code.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Top;
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(0, 75);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 10, 0, 0);
            label13.Size = new Size(379, 40);
            label13.TabIndex = 34;
            label13.Text = "Mã học phần";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(cmb_CatID, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCourseCatAdd, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 40);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(379, 35);
            tableLayoutPanel3.TabIndex = 21;
            // 
            // cmb_CatID
            // 
            cmb_CatID.BackColor = Color.White;
            cmb_CatID.BorderColor = Color.Gray;
            cmb_CatID.BorderSize = 2;
            cmb_CatID.Dock = DockStyle.Top;
            cmb_CatID.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_CatID.Font = new Font("Segoe UI", 10F);
            cmb_CatID.ForeColor = Color.Gray;
            cmb_CatID.IconColor = Color.Gray;
            cmb_CatID.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_CatID.ListTextColor = Color.DimGray;
            cmb_CatID.Location = new Point(0, 0);
            cmb_CatID.Margin = new Padding(0);
            cmb_CatID.MinimumSize = new Size(200, 30);
            cmb_CatID.Name = "cmb_CatID";
            cmb_CatID.Padding = new Padding(0, 0, 0, 2);
            cmb_CatID.Size = new Size(334, 35);
            cmb_CatID.TabIndex = 21;
            cmb_CatID.Texts = "";
            cmb_CatID.OnSelectedIndexChanged += CmbCatID_OnSelectedChanged;
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
            btnCourseCatAdd.Location = new Point(347, 3);
            btnCourseCatAdd.Margin = new Padding(13, 3, 3, 3);
            btnCourseCatAdd.Name = "btnCourseCatAdd";
            btnCourseCatAdd.Size = new Size(29, 29);
            btnCourseCatAdd.TabIndex = 22;
            btnCourseCatAdd.TabStop = false;
            btnCourseCatAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(379, 40);
            label1.TabIndex = 20;
            label1.Text = "Nhóm học phần";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Bottom;
            splitContainer1.Location = new Point(10, 639);
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
            splitContainer1.Size = new Size(379, 60);
            splitContainer1.SplitterDistance = 186;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 4;
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
            btnEdit.Size = new Size(166, 40);
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
            btnDelete.Click += btnDelete_Click;
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
            tableLayoutPanel1.Size = new Size(1156, 705);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Course_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Course_View";
            Size = new Size(1156, 705);
            customPanel1.ResumeLayout(false);
            pnlScroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            panel4.ResumeLayout(false);
            pnlHeaderText.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel customPanel1;
        private Panel pnlScroll;
        private DataGridView dgvList;
        private CustomControls.CustomPanel panel4;
        private TableLayoutPanel pnlHeaderText;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private CustomControls.CustomNumbericUpDown txt_Point;
        private Label label2;
        private CustomControls.CustomNumbericUpDown txt_Absences;
        private Label label9;
        private CustomControls.CustomNumbericUpDown txt_Session;
        private Label label10;
        private CustomControls.CustomNumbericUpDown txt_Credit;
        private Label label11;
        private CustomControls.CustomTextBox txt_Name;
        private Label label12;
        private CustomControls.CustomTextBox txt_Code;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.CustomComboBox cmb_CatID;
        private CustomControls.CustomButton btnCourseCatAdd;
        private Label label1;
        private CustomControls.CustomButton btnDelete;
        private CustomControls.CustomButton btnEdit;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
    }
}
