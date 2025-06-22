namespace BTL.Views.Class
{
    partial class Course_Add
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
            btn_Exit = new FontAwesome.Sharp.IconButton();
            pnlContainer = new SplitContainer();
            panel1 = new Panel();
            btn_Next = new FontAwesome.Sharp.IconButton();
            txt_Point = new CustomControls.CustomNumbericUpDown();
            label2 = new Label();
            txt_Absences = new CustomControls.CustomNumbericUpDown();
            label9 = new Label();
            txt_Session = new CustomControls.CustomNumbericUpDown();
            label10 = new Label();
            cmb_CatID = new CustomControls.CustomComboBox();
            label1 = new Label();
            txt_Credit = new CustomControls.CustomNumbericUpDown();
            label11 = new Label();
            txt_Name = new CustomControls.CustomTextBox();
            label12 = new Label();
            txt_Code = new CustomControls.CustomTextBox();
            label13 = new Label();
            label4 = new Label();
            pnlPointList = new Panel();
            panel3 = new Panel();
            btn_AddAssessment = new CustomControls.CustomButton();
            label3 = new Label();
            panel2 = new Panel();
            btn_Back = new FontAwesome.Sharp.IconButton();
            btn_Submit = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlContainer).BeginInit();
            pnlContainer.Panel1.SuspendLayout();
            pnlContainer.Panel2.SuspendLayout();
            pnlContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btn_Exit, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlContainer, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(600, 730);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += panelContainer_Paint;
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
            btn_Exit.Location = new Point(541, 23);
            btn_Exit.MaximumSize = new Size(36, 36);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(36, 36);
            btn_Exit.TabIndex = 11;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += Btn_Exit_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(20, 62);
            pnlContainer.Margin = new Padding(0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Orientation = Orientation.Horizontal;
            // 
            // pnlContainer.Panel1
            // 
            pnlContainer.Panel1.Controls.Add(panel1);
            pnlContainer.Panel1.Controls.Add(txt_Point);
            pnlContainer.Panel1.Controls.Add(label2);
            pnlContainer.Panel1.Controls.Add(txt_Absences);
            pnlContainer.Panel1.Controls.Add(label9);
            pnlContainer.Panel1.Controls.Add(txt_Session);
            pnlContainer.Panel1.Controls.Add(label10);
            pnlContainer.Panel1.Controls.Add(cmb_CatID);
            pnlContainer.Panel1.Controls.Add(label1);
            pnlContainer.Panel1.Controls.Add(txt_Credit);
            pnlContainer.Panel1.Controls.Add(label11);
            pnlContainer.Panel1.Controls.Add(txt_Name);
            pnlContainer.Panel1.Controls.Add(label12);
            pnlContainer.Panel1.Controls.Add(txt_Code);
            pnlContainer.Panel1.Controls.Add(label13);
            pnlContainer.Panel1.Controls.Add(label4);
            pnlContainer.Panel1.ForeColor = Color.DimGray;
            pnlContainer.Panel1MinSize = 0;
            // 
            // pnlContainer.Panel2
            // 
            pnlContainer.Panel2.Controls.Add(pnlPointList);
            pnlContainer.Panel2.Controls.Add(panel3);
            pnlContainer.Panel2.Controls.Add(panel2);
            pnlContainer.Panel2Collapsed = true;
            pnlContainer.Panel2MinSize = 0;
            pnlContainer.Size = new Size(560, 648);
            pnlContainer.SplitterDistance = 615;
            pnlContainer.SplitterWidth = 1;
            pnlContainer.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Next);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 618);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 30);
            panel1.TabIndex = 60;
            // 
            // btn_Next
            // 
            btn_Next.AutoSize = true;
            btn_Next.Cursor = Cursors.Hand;
            btn_Next.Dock = DockStyle.Right;
            btn_Next.FlatAppearance.BorderColor = Color.White;
            btn_Next.FlatAppearance.BorderSize = 0;
            btn_Next.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_Next.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_Next.FlatStyle = FlatStyle.Flat;
            btn_Next.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Next.ForeColor = Color.DimGray;
            btn_Next.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            btn_Next.IconColor = Color.DimGray;
            btn_Next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Next.IconSize = 20;
            btn_Next.Location = new Point(444, 0);
            btn_Next.MaximumSize = new Size(0, 30);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(116, 30);
            btn_Next.TabIndex = 61;
            btn_Next.Text = "Tiếp theo";
            btn_Next.TextAlign = ContentAlignment.MiddleLeft;
            btn_Next.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += Btn_Next_Click;
            // 
            // txt_Point
            // 
            txt_Point.BackColor = SystemColors.Control;
            txt_Point.BorderColor = Color.Gray;
            txt_Point.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Point.BorderRadius = 8;
            txt_Point.BorderSize = 2;
            txt_Point.DecimalPlaces = 0;
            txt_Point.Dock = DockStyle.Top;
            txt_Point.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Point.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Point.Location = new Point(0, 544);
            txt_Point.Margin = new Padding(4);
            txt_Point.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            txt_Point.Minimun = new decimal(new int[] { 0, 0, 0, 0 });
            txt_Point.Name = "txt_Point";
            txt_Point.Padding = new Padding(7);
            txt_Point.Size = new Size(560, 37);
            txt_Point.TabIndex = 59;
            txt_Point.TextAlign = HorizontalAlignment.Left;
            txt_Point.Texts = "4";
            txt_Point.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 504);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(560, 40);
            label2.TabIndex = 58;
            label2.Text = "Điểm qua môn";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Absences
            // 
            txt_Absences.BackColor = SystemColors.Control;
            txt_Absences.BorderColor = Color.Gray;
            txt_Absences.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Absences.BorderRadius = 8;
            txt_Absences.BorderSize = 2;
            txt_Absences.DecimalPlaces = 0;
            txt_Absences.Dock = DockStyle.Top;
            txt_Absences.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Absences.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Absences.Location = new Point(0, 467);
            txt_Absences.Margin = new Padding(4);
            txt_Absences.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            txt_Absences.Minimun = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Absences.Name = "txt_Absences";
            txt_Absences.Padding = new Padding(7);
            txt_Absences.Size = new Size(560, 37);
            txt_Absences.TabIndex = 57;
            txt_Absences.TextAlign = HorizontalAlignment.Left;
            txt_Absences.Texts = "1";
            txt_Absences.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(0, 427);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 10, 0, 0);
            label9.Size = new Size(560, 40);
            label9.TabIndex = 56;
            label9.Text = "Số buổi vắng tối đa";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Session
            // 
            txt_Session.BackColor = SystemColors.Control;
            txt_Session.BorderColor = Color.Gray;
            txt_Session.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Session.BorderRadius = 8;
            txt_Session.BorderSize = 2;
            txt_Session.DecimalPlaces = 0;
            txt_Session.Dock = DockStyle.Top;
            txt_Session.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Session.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Session.Location = new Point(0, 390);
            txt_Session.Margin = new Padding(4);
            txt_Session.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            txt_Session.Minimun = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Session.Name = "txt_Session";
            txt_Session.Padding = new Padding(7);
            txt_Session.Size = new Size(560, 37);
            txt_Session.TabIndex = 55;
            txt_Session.TextAlign = HorizontalAlignment.Left;
            txt_Session.Texts = "1";
            txt_Session.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(0, 350);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 10, 0, 0);
            label10.Size = new Size(560, 40);
            label10.TabIndex = 54;
            label10.Text = "Tổng số tiết";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_CatID
            // 
            cmb_CatID.BackColor = SystemColors.Control;
            cmb_CatID.BorderColor = Color.Gray;
            cmb_CatID.BorderSize = 2;
            cmb_CatID.Dock = DockStyle.Top;
            cmb_CatID.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_CatID.Font = new Font("Segoe UI", 10F);
            cmb_CatID.ForeColor = Color.DimGray;
            cmb_CatID.IconColor = Color.DimGray;
            cmb_CatID.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_CatID.ListTextColor = Color.DimGray;
            cmb_CatID.Location = new Point(0, 315);
            cmb_CatID.Margin = new Padding(0);
            cmb_CatID.MinimumSize = new Size(200, 30);
            cmb_CatID.Name = "cmb_CatID";
            cmb_CatID.Padding = new Padding(0, 0, 0, 2);
            cmb_CatID.Size = new Size(560, 35);
            cmb_CatID.TabIndex = 61;
            cmb_CatID.Texts = "";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 275);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(560, 40);
            label1.TabIndex = 46;
            label1.Text = "Nhóm học phần";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Credit
            // 
            txt_Credit.BackColor = SystemColors.Control;
            txt_Credit.BorderColor = Color.Gray;
            txt_Credit.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Credit.BorderRadius = 8;
            txt_Credit.BorderSize = 2;
            txt_Credit.DecimalPlaces = 0;
            txt_Credit.Dock = DockStyle.Top;
            txt_Credit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Credit.Increament = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Credit.Location = new Point(0, 238);
            txt_Credit.Margin = new Padding(4);
            txt_Credit.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            txt_Credit.Minimun = new decimal(new int[] { 1, 0, 0, 0 });
            txt_Credit.Name = "txt_Credit";
            txt_Credit.Padding = new Padding(7);
            txt_Credit.Size = new Size(560, 37);
            txt_Credit.TabIndex = 53;
            txt_Credit.TextAlign = HorizontalAlignment.Left;
            txt_Credit.Texts = "1";
            txt_Credit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Dock = DockStyle.Top;
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(0, 198);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 10, 0, 0);
            label11.Size = new Size(560, 40);
            label11.TabIndex = 52;
            label11.Text = "Số tín chỉ";
            label11.TextAlign = ContentAlignment.MiddleLeft;
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
            txt_Name.Location = new Point(0, 164);
            txt_Name.Margin = new Padding(4);
            txt_Name.Multiline = false;
            txt_Name.Name = "txt_Name";
            txt_Name.Padding = new Padding(7);
            txt_Name.PasswordChar = false;
            txt_Name.PlaceholderColor = Color.DimGray;
            txt_Name.PlaceholderText = "";
            txt_Name.Size = new Size(560, 34);
            txt_Name.TabIndex = 51;
            txt_Name.TextAlign = HorizontalAlignment.Left;
            txt_Name.Texts = "";
            txt_Name.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Top;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(0, 124);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 10, 0, 0);
            label12.Size = new Size(560, 40);
            label12.TabIndex = 50;
            label12.Text = "Tên học phần";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Code
            // 
            txt_Code.BackColor = SystemColors.Control;
            txt_Code.BorderColor = Color.Gray;
            txt_Code.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Code.BorderRadius = 8;
            txt_Code.BorderSize = 2;
            txt_Code.Dock = DockStyle.Top;
            txt_Code.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Code.ForeColor = Color.DimGray;
            txt_Code.Location = new Point(0, 90);
            txt_Code.Margin = new Padding(4);
            txt_Code.Multiline = false;
            txt_Code.Name = "txt_Code";
            txt_Code.Padding = new Padding(7);
            txt_Code.PasswordChar = false;
            txt_Code.PlaceholderColor = Color.DimGray;
            txt_Code.PlaceholderText = "";
            txt_Code.Size = new Size(560, 34);
            txt_Code.TabIndex = 49;
            txt_Code.TextAlign = HorizontalAlignment.Left;
            txt_Code.Texts = "";
            txt_Code.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Top;
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(0, 50);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 10, 0, 0);
            label13.Size = new Size(560, 40);
            label13.TabIndex = 48;
            label13.Text = "Mã học phần";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(560, 50);
            label4.TabIndex = 62;
            label4.Text = "Nhập thông tin môn học";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPointList
            // 
            pnlPointList.AutoScroll = true;
            pnlPointList.Dock = DockStyle.Fill;
            pnlPointList.Location = new Point(0, 60);
            pnlPointList.Name = "pnlPointList";
            pnlPointList.Size = new Size(560, 0);
            pnlPointList.TabIndex = 63;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_AddAssessment);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 10, 0, 10);
            panel3.Size = new Size(560, 60);
            panel3.TabIndex = 62;
            // 
            // btn_AddAssessment
            // 
            btn_AddAssessment.BackColor = Color.Gray;
            btn_AddAssessment.BorderColor = Color.PaleVioletRed;
            btn_AddAssessment.BorderRadius = 5;
            btn_AddAssessment.BorderSize = 0;
            btn_AddAssessment.Dock = DockStyle.Right;
            btn_AddAssessment.FlatAppearance.BorderColor = Color.Gray;
            btn_AddAssessment.FlatAppearance.BorderSize = 0;
            btn_AddAssessment.FlatStyle = FlatStyle.Flat;
            btn_AddAssessment.ForeColor = Color.White;
            btn_AddAssessment.IconChar = FontAwesome.Sharp.IconChar.Add;
            btn_AddAssessment.IconColor = Color.White;
            btn_AddAssessment.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btn_AddAssessment.IconSize = 22;
            btn_AddAssessment.Location = new Point(520, 10);
            btn_AddAssessment.Margin = new Padding(13, 3, 3, 3);
            btn_AddAssessment.Name = "btn_AddAssessment";
            btn_AddAssessment.Size = new Size(40, 40);
            btn_AddAssessment.TabIndex = 23;
            btn_AddAssessment.TabStop = false;
            btn_AddAssessment.UseVisualStyleBackColor = false;
            btn_AddAssessment.Click += Btn_AddAssessment_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 10);
            label3.Name = "label3";
            label3.Size = new Size(231, 40);
            label3.TabIndex = 0;
            label3.Text = "Nhập đầu điểm";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Back);
            panel2.Controls.Add(btn_Submit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 30);
            panel2.TabIndex = 61;
            // 
            // btn_Back
            // 
            btn_Back.AutoSize = true;
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.Dock = DockStyle.Left;
            btn_Back.FlatAppearance.BorderColor = Color.White;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_Back.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Back.ForeColor = Color.DimGray;
            btn_Back.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btn_Back.IconColor = Color.DimGray;
            btn_Back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Back.IconSize = 20;
            btn_Back.Location = new Point(0, 0);
            btn_Back.MaximumSize = new Size(0, 30);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(107, 30);
            btn_Back.TabIndex = 62;
            btn_Back.Text = "Quay lại";
            btn_Back.TextAlign = ContentAlignment.MiddleLeft;
            btn_Back.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += Btn_Back_Click;
            // 
            // btn_Submit
            // 
            btn_Submit.AutoSize = true;
            btn_Submit.Cursor = Cursors.Hand;
            btn_Submit.Dock = DockStyle.Right;
            btn_Submit.FlatAppearance.BorderColor = Color.White;
            btn_Submit.FlatAppearance.BorderSize = 0;
            btn_Submit.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btn_Submit.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btn_Submit.FlatStyle = FlatStyle.Flat;
            btn_Submit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Submit.ForeColor = Color.DimGray;
            btn_Submit.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            btn_Submit.IconColor = Color.DimGray;
            btn_Submit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Submit.IconSize = 20;
            btn_Submit.Location = new Point(447, 0);
            btn_Submit.MaximumSize = new Size(0, 30);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(113, 30);
            btn_Submit.TabIndex = 61;
            btn_Submit.Text = "Xác nhận";
            btn_Submit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Submit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += Btn_Submit_Click;
            // 
            // Course_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 730);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Course_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course_Add";
            Activated += Course_Add_Activated;
            Deactivate += Btn_Exit_Click;
            ResizeEnd += Course_Add_ResizeEnd;
            SizeChanged += Course_Add_SizeChanged;
            Paint += Course_Add_Paint;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlContainer.Panel1.ResumeLayout(false);
            pnlContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlContainer).EndInit();
            pnlContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer pnlContainer;
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
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Next;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btn_Back;
        private FontAwesome.Sharp.IconButton btn_Submit;
        private Panel panel3;
        private Label label3;
        private CustomControls.CustomButton btn_AddAssessment;
        private Label label4;
        private Panel pnlPointList;
        private CustomControls.CustomComboBox cmb_CatID;
        private FontAwesome.Sharp.IconButton btn_Exit;
    }
}