namespace BTL.Views
{
    partial class Student_View
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
            pnlTitle = new Panel();
            btnAdd = new CustomControls.CustomButton();
            label1 = new Label();
            pnlBody = new CustomControls.CustomPanel();
            pnlScroll = new Panel();
            pnlList = new Panel();
            customPanel2 = new CustomControls.CustomPanel();
            pnlHeaderText = new TableLayoutPanel();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbAll = new CheckBox();
            label4 = new Label();
            panel3 = new Panel();
            cmbListPage = new ComboBox();
            panel4 = new Panel();
            btnAfterPage = new CustomControls.CustomButton();
            btnPreviousPage = new CustomControls.CustomButton();
            lblPageCount = new Label();
            label3 = new Label();
            btnPageShow = new CustomControls.CustomButton();
            label2 = new Label();
            pnlHeader = new Panel();
            label10 = new Label();
            cmbMajor = new CustomControls.CustomComboBox();
            cmbListAction = new ComboBox();
            btnImport = new CustomControls.CustomButton();
            btnAction = new CustomControls.CustomButton();
            txtSearch = new CustomControls.CustomTextBox();
            pnlTitle.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlScroll.SuspendLayout();
            customPanel2.SuspendLayout();
            pnlHeaderText.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.White;
            pnlTitle.Controls.Add(btnAdd);
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(30, 30);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Padding = new Padding(0, 10, 0, 10);
            pnlTitle.Size = new Size(1090, 65);
            pnlTitle.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(27, 90, 255);
            btnAdd.BorderColor = Color.FromArgb(27, 90, 255);
            btnAdd.BorderRadius = 22;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Dock = DockStyle.Right;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(27, 90, 255);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAdd.IconSize = 20;
            btnAdd.Location = new Point(955, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(0, 0, 8, 0);
            btnAdd.Size = new Size(135, 45);
            btnAdd.TabIndex = 1;
            btnAdd.TabStop = false;
            btnAdd.Text = "Add new";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Helvetica Rounded", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 10);
            label1.Size = new Size(291, 43);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sinh viên";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            pnlBody.BackColor1 = Color.White;
            pnlBody.BackColor2 = Color.White;
            pnlBody.BorderColor = Color.Gray;
            pnlBody.BorderSize = 2;
            pnlBody.Controls.Add(pnlScroll);
            pnlBody.Controls.Add(customPanel2);
            pnlBody.Controls.Add(panel3);
            pnlBody.Controls.Add(pnlHeader);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.GradientAngle = 20F;
            pnlBody.Location = new Point(30, 95);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(10);
            pnlBody.Radius = new Padding(20);
            pnlBody.Size = new Size(1090, 575);
            pnlBody.TabIndex = 1;
            // 
            // pnlScroll
            // 
            pnlScroll.AutoScroll = true;
            pnlScroll.Controls.Add(pnlList);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(10, 125);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Size = new Size(1070, 390);
            pnlScroll.TabIndex = 7;
            // 
            // pnlList
            // 
            pnlList.AutoSize = true;
            pnlList.Dock = DockStyle.Top;
            pnlList.Location = new Point(0, 0);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(1070, 0);
            pnlList.TabIndex = 0;
            pnlList.SizeChanged += PnlList_SizeChanged;
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
            customPanel2.Location = new Point(10, 75);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(15, 5, 0, 5);
            customPanel2.Radius = new Padding(15);
            customPanel2.Size = new Size(1070, 50);
            customPanel2.TabIndex = 6;
            // 
            // pnlHeaderText
            // 
            pnlHeaderText.BackColor = Color.Transparent;
            pnlHeaderText.ColumnCount = 9;
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881613F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            pnlHeaderText.Controls.Add(label11, 4, 0);
            pnlHeaderText.Controls.Add(label9, 6, 0);
            pnlHeaderText.Controls.Add(label8, 5, 0);
            pnlHeaderText.Controls.Add(label7, 4, 0);
            pnlHeaderText.Controls.Add(label6, 3, 0);
            pnlHeaderText.Controls.Add(label5, 2, 0);
            pnlHeaderText.Controls.Add(cbAll, 0, 0);
            pnlHeaderText.Controls.Add(label4, 1, 0);
            pnlHeaderText.Dock = DockStyle.Fill;
            pnlHeaderText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderText.Location = new Point(15, 5);
            pnlHeaderText.Margin = new Padding(0);
            pnlHeaderText.Name = "pnlHeaderText";
            pnlHeaderText.RowCount = 1;
            pnlHeaderText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeaderText.Size = new Size(1055, 40);
            pnlHeaderText.TabIndex = 0;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(443, 0);
            label11.Name = "label11";
            label11.Size = new Size(114, 40);
            label11.TabIndex = 8;
            label11.Text = "Khoá học";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(803, 0);
            label9.Name = "label9";
            label9.Size = new Size(115, 40);
            label9.TabIndex = 7;
            label9.Text = "Số điện thoại";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(683, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 40);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(563, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 40);
            label7.TabIndex = 5;
            label7.Text = "Giới tính";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(323, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 40);
            label6.TabIndex = 4;
            label6.Text = "Mã sinh viên";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(203, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 40);
            label5.TabIndex = 3;
            label5.Text = "Tên";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbAll
            // 
            cbAll.AutoSize = true;
            cbAll.Cursor = Cursors.Hand;
            cbAll.Dock = DockStyle.Fill;
            cbAll.ForeColor = Color.FromArgb(64, 64, 64);
            cbAll.Location = new Point(0, 0);
            cbAll.Margin = new Padding(0);
            cbAll.Name = "cbAll";
            cbAll.Padding = new Padding(10, 0, 0, 0);
            cbAll.Size = new Size(80, 40);
            cbAll.TabIndex = 1;
            cbAll.Text = "ID";
            cbAll.UseVisualStyleBackColor = true;
            cbAll.CheckedChanged += CbAll_CheckedChanged;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(83, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 40);
            label4.TabIndex = 2;
            label4.Text = "Họ đệm";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cmbListPage);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblPageCount);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnPageShow);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 515);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20, 7, 20, 7);
            panel3.Size = new Size(1070, 50);
            panel3.TabIndex = 3;
            // 
            // cmbListPage
            // 
            cmbListPage.FormattingEnabled = true;
            cmbListPage.Items.AddRange(new object[] { "All", "25", "50", "100", "150", "250", "350", "550" });
            cmbListPage.Location = new Point(78, 7);
            cmbListPage.Name = "cmbListPage";
            cmbListPage.Size = new Size(65, 28);
            cmbListPage.TabIndex = 8;
            cmbListPage.Visible = false;
            cmbListPage.SelectedIndexChanged += CmbListPage_SelectedIndexChanged;
            cmbListPage.DropDownClosed += CmbListPage_DropDownClosed;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAfterPage);
            panel4.Controls.Add(btnPreviousPage);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(966, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(84, 36);
            panel4.TabIndex = 7;
            // 
            // btnAfterPage
            // 
            btnAfterPage.BackColor = Color.White;
            btnAfterPage.BorderColor = Color.Gray;
            btnAfterPage.BorderRadius = 18;
            btnAfterPage.BorderSize = 1;
            btnAfterPage.Cursor = Cursors.Hand;
            btnAfterPage.Dock = DockStyle.Right;
            btnAfterPage.FlatAppearance.BorderColor = Color.White;
            btnAfterPage.FlatAppearance.BorderSize = 0;
            btnAfterPage.FlatStyle = FlatStyle.Flat;
            btnAfterPage.ForeColor = Color.White;
            btnAfterPage.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            btnAfterPage.IconColor = Color.FromArgb(64, 64, 64);
            btnAfterPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAfterPage.IconSize = 20;
            btnAfterPage.Location = new Point(48, 0);
            btnAfterPage.Name = "btnAfterPage";
            btnAfterPage.Padding = new Padding(1, 3, 0, 0);
            btnAfterPage.Size = new Size(36, 36);
            btnAfterPage.TabIndex = 7;
            btnAfterPage.TabStop = false;
            btnAfterPage.UseVisualStyleBackColor = false;
            btnAfterPage.Click += BtnAfterPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = Color.White;
            btnPreviousPage.BorderColor = Color.Gray;
            btnPreviousPage.BorderRadius = 18;
            btnPreviousPage.BorderSize = 1;
            btnPreviousPage.Cursor = Cursors.Hand;
            btnPreviousPage.Dock = DockStyle.Left;
            btnPreviousPage.FlatAppearance.BorderColor = Color.White;
            btnPreviousPage.FlatAppearance.BorderSize = 0;
            btnPreviousPage.FlatStyle = FlatStyle.Flat;
            btnPreviousPage.ForeColor = Color.White;
            btnPreviousPage.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnPreviousPage.IconColor = Color.FromArgb(64, 64, 64);
            btnPreviousPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPreviousPage.IconSize = 20;
            btnPreviousPage.Location = new Point(0, 0);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Padding = new Padding(1, 3, 0, 0);
            btnPreviousPage.Size = new Size(36, 36);
            btnPreviousPage.TabIndex = 6;
            btnPreviousPage.TabStop = false;
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += BtnPreviousPage_Click;
            // 
            // lblPageCount
            // 
            lblPageCount.Dock = DockStyle.Left;
            lblPageCount.Font = new Font("Helvetica Rounded", 8.999999F, FontStyle.Bold);
            lblPageCount.ForeColor = Color.FromArgb(64, 64, 64);
            lblPageCount.Location = new Point(235, 7);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Padding = new Padding(20, 0, 0, 0);
            lblPageCount.Size = new Size(190, 36);
            lblPageCount.TabIndex = 4;
            lblPageCount.Text = "per pages";
            lblPageCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Helvetica Rounded", 8.999999F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(143, 7);
            label3.Name = "label3";
            label3.Size = new Size(92, 36);
            label3.TabIndex = 3;
            label3.Text = "per pages";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPageShow
            // 
            btnPageShow.BackColor = Color.White;
            btnPageShow.BorderColor = Color.Black;
            btnPageShow.BorderRadius = 18;
            btnPageShow.BorderSize = 1;
            btnPageShow.Cursor = Cursors.Hand;
            btnPageShow.Dock = DockStyle.Left;
            btnPageShow.FlatAppearance.BorderColor = Color.White;
            btnPageShow.FlatAppearance.BorderSize = 0;
            btnPageShow.FlatStyle = FlatStyle.Flat;
            btnPageShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageShow.ForeColor = Color.FromArgb(64, 64, 64);
            btnPageShow.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            btnPageShow.IconColor = Color.FromArgb(64, 64, 64);
            btnPageShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPageShow.IconSize = 20;
            btnPageShow.Location = new Point(78, 7);
            btnPageShow.Name = "btnPageShow";
            btnPageShow.Size = new Size(65, 36);
            btnPageShow.TabIndex = 2;
            btnPageShow.TabStop = false;
            btnPageShow.Text = "All";
            btnPageShow.TextAlign = ContentAlignment.MiddleRight;
            btnPageShow.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPageShow.UseVisualStyleBackColor = false;
            btnPageShow.TextChanged += BtnPageShow_TextChanged;
            btnPageShow.Click += BtnPageShow_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Helvetica Rounded", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 7);
            label2.Name = "label2";
            label2.Size = new Size(58, 36);
            label2.TabIndex = 1;
            label2.Text = "Show";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(label10);
            pnlHeader.Controls.Add(cmbMajor);
            pnlHeader.Controls.Add(cmbListAction);
            pnlHeader.Controls.Add(btnImport);
            pnlHeader.Controls.Add(btnAction);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(10, 10);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 0, 15);
            pnlHeader.Size = new Size(1070, 65);
            pnlHeader.TabIndex = 1;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Right;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(583, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 0, 5, 4);
            label10.Size = new Size(117, 50);
            label10.TabIndex = 11;
            label10.Text = "Ngành học:";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbMajor
            // 
            cmbMajor.BackColor = Color.White;
            cmbMajor.BorderColor = Color.Gray;
            cmbMajor.BorderSize = 2;
            cmbMajor.Dock = DockStyle.Right;
            cmbMajor.DropDownStyle = ComboBoxStyle.DropDown;
            cmbMajor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMajor.ForeColor = Color.DimGray;
            cmbMajor.IconColor = Color.Gray;
            cmbMajor.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbMajor.ListTextColor = Color.DimGray;
            cmbMajor.Location = new Point(700, 0);
            cmbMajor.MinimumSize = new Size(200, 30);
            cmbMajor.Name = "cmbMajor";
            cmbMajor.Padding = new Padding(0, 0, 0, 2);
            cmbMajor.Size = new Size(240, 50);
            cmbMajor.TabIndex = 10;
            cmbMajor.Texts = "";
            cmbMajor.OnSelectedIndexChanged += CmbMajor_OnSelectedIndexChanged;
            // 
            // cmbListAction
            // 
            cmbListAction.AllowDrop = true;
            cmbListAction.FormattingEnabled = true;
            cmbListAction.ItemHeight = 20;
            cmbListAction.Items.AddRange(new object[] { "Export", "Xoá", "Tạo lớp" });
            cmbListAction.Location = new Point(370, 22);
            cmbListAction.Name = "cmbListAction";
            cmbListAction.Size = new Size(150, 28);
            cmbListAction.TabIndex = 9;
            cmbListAction.TabStop = false;
            cmbListAction.Visible = false;
            cmbListAction.SelectedIndexChanged += CmbListAction_SelectedIndexChanged;
            cmbListAction.DropDownClosed += CmbListAction_DropDownClosed;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.White;
            btnImport.BorderColor = Color.Gray;
            btnImport.BorderRadius = 25;
            btnImport.BorderSize = 0;
            btnImport.Cursor = Cursors.Hand;
            btnImport.Dock = DockStyle.Right;
            btnImport.FlatAppearance.BorderColor = Color.White;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnImport.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnImport.ForeColor = Color.Gray;
            btnImport.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            btnImport.IconColor = Color.Gray;
            btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImport.IconSize = 35;
            btnImport.Location = new Point(940, 0);
            btnImport.Margin = new Padding(0);
            btnImport.Name = "btnImport";
            btnImport.Padding = new Padding(0, 10, 0, 0);
            btnImport.Size = new Size(130, 50);
            btnImport.TabIndex = 0;
            btnImport.TabStop = false;
            btnImport.Text = "Import";
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImport.UseVisualStyleBackColor = false;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.White;
            btnAction.BorderColor = Color.Gray;
            btnAction.BorderRadius = 25;
            btnAction.BorderSize = 2;
            btnAction.Cursor = Cursors.Hand;
            btnAction.FlatAppearance.BorderColor = Color.White;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAction.ForeColor = Color.Gray;
            btnAction.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            btnAction.IconColor = Color.Gray;
            btnAction.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAction.IconSize = 20;
            btnAction.Location = new Point(370, 0);
            btnAction.Margin = new Padding(0);
            btnAction.Name = "btnAction";
            btnAction.Padding = new Padding(0, 0, 5, 0);
            btnAction.Size = new Size(150, 50);
            btnAction.TabIndex = 2;
            btnAction.TabStop = false;
            btnAction.Text = "Selected";
            btnAction.TextAlign = ContentAlignment.MiddleRight;
            btnAction.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Visible = false;
            btnAction.Click += BtnAction_Click;
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
            // Student_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlBody);
            Controls.Add(pnlTitle);
            Name = "Student_View";
            Padding = new Padding(30);
            Size = new Size(1150, 700);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlScroll.ResumeLayout(false);
            pnlScroll.PerformLayout();
            customPanel2.ResumeLayout(false);
            pnlHeaderText.ResumeLayout(false);
            pnlHeaderText.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label label1;
        private CustomControls.CustomPanel pnlBody;
        private CustomControls.CustomButton btnAdd;
        private Panel pnlHeader;
        private Panel panel3;
        private CustomControls.CustomButton btnPageShow;
        private Label label2;
        private Label lblPageCount;
        private Label label3;
        private CustomControls.CustomButton btnPreviousPage;
        private Panel panel4;
        private CustomControls.CustomButton btnAfterPage;
        private CustomControls.CustomTextBox txtSearch;
        private CustomControls.CustomButton btnImport;
        private CustomControls.CustomButton btnAction;
        private Panel pnlScroll;
        private Panel pnlList;
        private CustomControls.CustomPanel customPanel2;
        private TableLayoutPanel pnlHeaderText;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private CheckBox cbAll;
        private Label label4;
        private Label label9;
        private ComboBox cmbListPage;
        private ComboBox cmbListAction;
        private CustomControls.CustomComboBox cmbMajor;
        private Label label10;
        private Label label11;
    }
}