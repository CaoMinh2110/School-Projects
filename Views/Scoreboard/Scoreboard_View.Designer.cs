namespace BTL.Views.Scoreboard
{
    partial class Scoreboard_View
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
            pnlBody = new CustomControls.CustomPanel();
            splitContainer3 = new SplitContainer();
            customPanel2 = new CustomControls.CustomPanel();
            pnlHeaderText = new TableLayoutPanel();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            splitContainer2 = new SplitContainer();
            label7 = new Label();
            pnlProcessScore = new TableLayoutPanel();
            label4 = new Label();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlScroll = new Panel();
            pnlList = new Panel();
            pnlHeader = new Panel();
            btn_Save = new CustomControls.CustomButton();
            cmb_Class = new CustomControls.CustomComboBox();
            label9 = new Label();
            cmb_Course = new CustomControls.CustomComboBox();
            label10 = new Label();
            txtSearch = new CustomControls.CustomTextBox();
            label8 = new Label();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            customPanel2.SuspendLayout();
            pnlHeaderText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlScroll.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBody
            // 
            pnlBody.BackColor1 = Color.White;
            pnlBody.BackColor2 = Color.White;
            pnlBody.BorderColor = Color.Gray;
            pnlBody.BorderSize = 2;
            pnlBody.Controls.Add(splitContainer3);
            pnlBody.Controls.Add(pnlHeader);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.GradientAngle = 20F;
            pnlBody.Location = new Point(30, 95);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(10);
            pnlBody.Radius = new Padding(20);
            pnlBody.Size = new Size(1240, 475);
            pnlBody.TabIndex = 11;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(10, 75);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(customPanel2);
            splitContainer3.Panel1MinSize = 100;
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(pnlScroll);
            splitContainer3.Size = new Size(1220, 390);
            splitContainer3.SplitterDistance = 100;
            splitContainer3.SplitterWidth = 1;
            splitContainer3.TabIndex = 12;
            // 
            // customPanel2
            // 
            customPanel2.BackColor1 = Color.Silver;
            customPanel2.BackColor2 = Color.Silver;
            customPanel2.BorderColor = Color.Gray;
            customPanel2.BorderSize = 1;
            customPanel2.Controls.Add(pnlHeaderText);
            customPanel2.Dock = DockStyle.Top;
            customPanel2.ForeColor = Color.FromArgb(64, 64, 64);
            customPanel2.GradientAngle = 20F;
            customPanel2.Location = new Point(0, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(15, 2, 22, 2);
            customPanel2.Radius = new Padding(15);
            customPanel2.Size = new Size(1220, 100);
            customPanel2.TabIndex = 10;
            // 
            // pnlHeaderText
            // 
            pnlHeaderText.BackColor = Color.Gray;
            pnlHeaderText.ColumnCount = 11;
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            pnlHeaderText.Controls.Add(label18, 10, 0);
            pnlHeaderText.Controls.Add(label17, 2, 0);
            pnlHeaderText.Controls.Add(label16, 8, 0);
            pnlHeaderText.Controls.Add(label15, 9, 0);
            pnlHeaderText.Controls.Add(label14, 7, 0);
            pnlHeaderText.Controls.Add(label13, 6, 0);
            pnlHeaderText.Controls.Add(label12, 5, 0);
            pnlHeaderText.Controls.Add(label11, 3, 0);
            pnlHeaderText.Controls.Add(splitContainer2, 4, 0);
            pnlHeaderText.Controls.Add(label4, 0, 0);
            pnlHeaderText.Controls.Add(splitContainer1, 1, 0);
            pnlHeaderText.Dock = DockStyle.Fill;
            pnlHeaderText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderText.Location = new Point(15, 2);
            pnlHeaderText.Margin = new Padding(0);
            pnlHeaderText.Name = "pnlHeaderText";
            pnlHeaderText.RowCount = 1;
            pnlHeaderText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeaderText.Size = new Size(1183, 96);
            pnlHeaderText.TabIndex = 0;
            // 
            // label18
            // 
            label18.BackColor = Color.Silver;
            label18.Dock = DockStyle.Fill;
            label18.Location = new Point(1133, 0);
            label18.Margin = new Padding(0, 0, 1, 0);
            label18.Name = "label18";
            label18.Size = new Size(49, 96);
            label18.TabIndex = 19;
            label18.Text = "Đạt";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = Color.Silver;
            label17.Dock = DockStyle.Fill;
            label17.Location = new Point(550, 0);
            label17.Margin = new Padding(0, 0, 1, 0);
            label17.Name = "label17";
            label17.Size = new Size(79, 96);
            label17.TabIndex = 18;
            label17.Text = "Số buổi nghỉ";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = Color.Silver;
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(973, 0);
            label16.Margin = new Padding(0, 0, 1, 0);
            label16.Name = "label16";
            label16.Size = new Size(79, 96);
            label16.TabIndex = 17;
            label16.Text = "Điểm thi";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = Color.Silver;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(1053, 0);
            label15.Margin = new Padding(0, 0, 1, 0);
            label15.Name = "label15";
            label15.Size = new Size(79, 96);
            label15.TabIndex = 16;
            label15.Text = "Điểm\r\ntổng kết";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = Color.Silver;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(893, 0);
            label14.Margin = new Padding(0, 0, 1, 0);
            label14.Name = "label14";
            label14.Size = new Size(79, 96);
            label14.TabIndex = 15;
            label14.Text = "Lần thi thứ";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = Color.Silver;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(813, 0);
            label13.Margin = new Padding(0, 0, 1, 0);
            label13.Name = "label13";
            label13.Size = new Size(79, 96);
            label13.TabIndex = 14;
            label13.Text = "Số đã\r\nlần thi";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.Silver;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(763, 0);
            label12.Margin = new Padding(0, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 96);
            label12.TabIndex = 13;
            label12.Text = "Được dự thi";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.Silver;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(630, 0);
            label11.Margin = new Padding(0, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(79, 96);
            label11.TabIndex = 12;
            label11.Text = "Chuyên cần";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.Gray;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(710, 0);
            splitContainer2.Margin = new Padding(0, 0, 1, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Silver;
            splitContainer2.Panel1.Controls.Add(label7);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.Silver;
            splitContainer2.Panel2.Controls.Add(pnlProcessScore);
            splitContainer2.Size = new Size(52, 96);
            splitContainer2.SplitterDistance = 45;
            splitContainer2.SplitterWidth = 1;
            splitContainer2.TabIndex = 11;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 45);
            label7.TabIndex = 10;
            label7.Text = "Điểm quá trình";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlProcessScore
            // 
            pnlProcessScore.BackColor = Color.Gray;
            pnlProcessScore.ColumnCount = 1;
            pnlProcessScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlProcessScore.Dock = DockStyle.Fill;
            pnlProcessScore.Location = new Point(0, 0);
            pnlProcessScore.Name = "pnlProcessScore";
            pnlProcessScore.RowCount = 1;
            pnlProcessScore.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlProcessScore.Size = new Size(52, 50);
            pnlProcessScore.TabIndex = 0;
            // 
            // label4
            // 
            label4.BackColor = Color.Silver;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(1, 0);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 96);
            label4.TabIndex = 8;
            label4.Text = "STT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Gray;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(50, 0);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Gray;
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Padding = new Padding(0, 0, 1, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Silver;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(500, 96);
            splitContainer1.SplitterDistance = 45;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(499, 45);
            label1.TabIndex = 9;
            label1.Text = "Thông tin sinh viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Gray;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(500, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.BackColor = Color.Silver;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(400, 0);
            label6.Margin = new Padding(0, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 50);
            label6.TabIndex = 12;
            label6.Text = "Giới tính";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Silver;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(300, 0);
            label5.Margin = new Padding(0, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 50);
            label5.TabIndex = 11;
            label5.Text = "Tên";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Silver;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(120, 0);
            label3.Margin = new Padding(0, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 50);
            label3.TabIndex = 10;
            label3.Text = "Họ đệm";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Silver;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 50);
            label2.TabIndex = 9;
            label2.Text = "Mã sinh viên";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlScroll
            // 
            pnlScroll.AutoScroll = true;
            pnlScroll.Controls.Add(pnlList);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(0, 0);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Size = new Size(1220, 289);
            pnlScroll.TabIndex = 11;
            // 
            // pnlList
            // 
            pnlList.AutoSize = true;
            pnlList.Dock = DockStyle.Top;
            pnlList.Location = new Point(0, 0);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(1220, 0);
            pnlList.TabIndex = 0;
            pnlList.SizeChanged += PnlList_SizeChanged;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btn_Save);
            pnlHeader.Controls.Add(cmb_Class);
            pnlHeader.Controls.Add(label9);
            pnlHeader.Controls.Add(cmb_Course);
            pnlHeader.Controls.Add(label10);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(10, 10);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 0, 15);
            pnlHeader.Size = new Size(1220, 65);
            pnlHeader.TabIndex = 13;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(27, 90, 255);
            btn_Save.BorderColor = Color.FromArgb(27, 90, 255);
            btn_Save.BorderRadius = 25;
            btn_Save.BorderSize = 0;
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.Dock = DockStyle.Right;
            btn_Save.FlatAppearance.BorderColor = Color.FromArgb(27, 90, 255);
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Save.ForeColor = Color.White;
            btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            btn_Save.IconColor = Color.White;
            btn_Save.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btn_Save.IconSize = 30;
            btn_Save.Location = new Point(1100, 0);
            btn_Save.Name = "btn_Save";
            btn_Save.Padding = new Padding(0, 0, 5, 0);
            btn_Save.Size = new Size(120, 50);
            btn_Save.TabIndex = 14;
            btn_Save.TabStop = false;
            btn_Save.Text = "Save";
            btn_Save.TextAlign = ContentAlignment.MiddleRight;
            btn_Save.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += Btn_Save_Click;
            // 
            // cmb_Class
            // 
            cmb_Class.BackColor = Color.White;
            cmb_Class.BorderColor = Color.Gray;
            cmb_Class.BorderSize = 2;
            cmb_Class.Dock = DockStyle.Left;
            cmb_Class.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Class.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Class.ForeColor = Color.DimGray;
            cmb_Class.IconColor = Color.Gray;
            cmb_Class.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Class.ListTextColor = Color.DimGray;
            cmb_Class.Location = new Point(782, 0);
            cmb_Class.MinimumSize = new Size(200, 30);
            cmb_Class.Name = "cmb_Class";
            cmb_Class.Padding = new Padding(0, 0, 0, 2);
            cmb_Class.Size = new Size(220, 50);
            cmb_Class.TabIndex = 12;
            cmb_Class.Texts = "";
            cmb_Class.OnSelectedIndexChanged += CmbClass_OnSelectedIndexChanged;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(682, 0);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 0, 2);
            label9.Size = new Size(100, 50);
            label9.TabIndex = 13;
            label9.Text = "Lớp học:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmb_Course
            // 
            cmb_Course.BackColor = Color.White;
            cmb_Course.BorderColor = Color.Gray;
            cmb_Course.BorderSize = 2;
            cmb_Course.Dock = DockStyle.Left;
            cmb_Course.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Course.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Course.ForeColor = Color.DimGray;
            cmb_Course.IconColor = Color.Gray;
            cmb_Course.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Course.ListTextColor = Color.DimGray;
            cmb_Course.Location = new Point(462, 0);
            cmb_Course.MinimumSize = new Size(200, 30);
            cmb_Course.Name = "cmb_Course";
            cmb_Course.Padding = new Padding(0, 0, 0, 2);
            cmb_Course.Size = new Size(220, 50);
            cmb_Course.TabIndex = 10;
            cmb_Course.Texts = "";
            cmb_Course.OnSelectedIndexChanged += CmbCourse_OnSelectedIndexChanged;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Left;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(362, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 0, 2);
            label10.Size = new Size(100, 50);
            label10.TabIndex = 11;
            label10.Text = "Học phần:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Gainsboro;
            txtSearch.BorderColor = Color.Gray;
            txtSearch.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtSearch.BorderRadius = 25;
            txtSearch.BorderSize = 2;
            txtSearch.Dock = DockStyle.Left;
            txtSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(27, 90, 255);
            txtSearch.Location = new Point(0, 0);
            txtSearch.Margin = new Padding(4);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(15, 15, 9, 9);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceholderColor = Color.Gray;
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(362, 50);
            txtSearch.TabIndex = 2;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.Texts = "";
            txtSearch.UnderlinedStyle = false;
            txtSearch.Enter += TxtSearch_Enter;
            txtSearch.KeyDown += TxtSearch_KeyDown;
            txtSearch.Leave += TxtSearch_Leave;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Helvetica Rounded", 16.2F, FontStyle.Bold);
            label8.Location = new Point(30, 30);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 0, 0, 10);
            label8.Size = new Size(1240, 65);
            label8.TabIndex = 10;
            label8.Text = "Bảng điểm";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Scoreboard_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlBody);
            Controls.Add(label8);
            Name = "Scoreboard_View";
            Padding = new Padding(30);
            Size = new Size(1300, 600);
            pnlBody.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            pnlHeaderText.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlScroll.ResumeLayout(false);
            pnlScroll.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomPanel pnlBody;
        private Label label8;
        private SplitContainer splitContainer3;
        private CustomControls.CustomPanel customPanel2;
        private TableLayoutPanel pnlHeaderText;
        private Label label4;
        private SplitContainer splitContainer1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Panel pnlScroll;
        private Panel pnlList;
        private Panel pnlHeader;
        private CustomControls.CustomComboBox cmb_Class;
        private Label label9;
        private CustomControls.CustomComboBox cmb_Course;
        private Label label10;
        private CustomControls.CustomTextBox txtSearch;
        private Label label13;
        private Label label12;
        private Label label11;
        private SplitContainer splitContainer2;
        private Label label7;
        private TableLayoutPanel pnlProcessScore;
        private Label label15;
        private Label label14;
        private Label label17;
        private Label label16;
        private Label label18;
        private CustomControls.CustomButton btn_Save;
    }
}
