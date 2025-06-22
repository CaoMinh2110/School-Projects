namespace BTL.Views.StudentForm
{
    partial class Student_Infor
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
            panel7 = new Panel();
            btn_Delete = new CustomControls.CustomButton();
            btn_Edit = new CustomControls.CustomButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            txt_Note = new CustomControls.CustomTextBox();
            label8 = new Label();
            txt_Address = new CustomControls.CustomTextBox();
            label10 = new Label();
            txt_Cohort = new CustomControls.CustomTextBox();
            label11 = new Label();
            cmb_Major = new CustomControls.CustomComboBox();
            label16 = new Label();
            panel3 = new Panel();
            txt_Email = new CustomControls.CustomTextBox();
            label6 = new Label();
            txt_Phone = new CustomControls.CustomTextBox();
            label5 = new Label();
            txt_Identity = new CustomControls.CustomTextBox();
            label3 = new Label();
            splitContainer2 = new SplitContainer();
            dpBirth = new CustomControls.CustomDatePicker();
            label4 = new Label();
            cmb_Gender = new CustomControls.CustomComboBox();
            label7 = new Label();
            splitContainer1 = new SplitContainer();
            txt_LastName = new CustomControls.CustomTextBox();
            label1 = new Label();
            txt_FirstName = new CustomControls.CustomTextBox();
            label2 = new Label();
            txt_Code = new CustomControls.CustomTextBox();
            label9 = new Label();
            customPictureBox1 = new CustomControls.CustomPictureBox();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Controls.Add(btn_Delete);
            panel7.Controls.Add(btn_Edit);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 533);
            panel7.Name = "panel7";
            panel7.Size = new Size(1247, 67);
            panel7.TabIndex = 1;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Top;
            btn_Delete.BackColor = Color.Gray;
            btn_Delete.BorderColor = Color.PaleVioletRed;
            btn_Delete.BorderRadius = 10;
            btn_Delete.BorderSize = 0;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.FlatAppearance.BorderColor = Color.Gray;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btn_Delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Delete.IconColor = Color.Black;
            btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Delete.Location = new Point(658, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(280, 64);
            btn_Delete.TabIndex = 4;
            btn_Delete.TabStop = false;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += BtnDelete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Anchor = AnchorStyles.Top;
            btn_Edit.BackColor = Color.Gray;
            btn_Edit.BorderColor = Color.PaleVioletRed;
            btn_Edit.BorderRadius = 10;
            btn_Edit.BorderSize = 0;
            btn_Edit.Cursor = Cursors.Hand;
            btn_Edit.Enabled = false;
            btn_Edit.FlatAppearance.BorderColor = Color.Gray;
            btn_Edit.FlatAppearance.BorderSize = 0;
            btn_Edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Edit.FlatStyle = FlatStyle.Flat;
            btn_Edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Edit.ForeColor = Color.White;
            btn_Edit.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Edit.IconColor = Color.Black;
            btn_Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Edit.Location = new Point(309, 0);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(280, 64);
            btn_Edit.TabIndex = 3;
            btn_Edit.TabStop = false;
            btn_Edit.Text = "Update";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += BtnEdit_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 533);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(customPictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(13, 0);
            tableLayoutPanel1.MinimumSize = new Size(1220, 500);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1220, 508);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.Controls.Add(txt_Note);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_Address);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txt_Cohort);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cmb_Major);
            panel2.Controls.Add(label16);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(740, 20);
            panel2.Margin = new Padding(20);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 452);
            panel2.TabIndex = 4;
            // 
            // txt_Note
            // 
            txt_Note.BackColor = SystemColors.Window;
            txt_Note.BorderColor = Color.Gray;
            txt_Note.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Note.BorderRadius = 8;
            txt_Note.BorderSize = 2;
            txt_Note.Dock = DockStyle.Top;
            txt_Note.Font = new Font("Segoe UI", 9.5F);
            txt_Note.ForeColor = Color.DimGray;
            txt_Note.Location = new Point(0, 345);
            txt_Note.Margin = new Padding(4);
            txt_Note.Multiline = true;
            txt_Note.Name = "txt_Note";
            txt_Note.Padding = new Padding(7);
            txt_Note.PasswordChar = false;
            txt_Note.PlaceholderColor = Color.DarkGray;
            txt_Note.PlaceholderText = "";
            txt_Note.Size = new Size(460, 107);
            txt_Note.TabIndex = 29;
            txt_Note.TextAlign = HorizontalAlignment.Left;
            txt_Note.Texts = "";
            txt_Note.UnderlinedStyle = false;
            txt_Note._TextChanged += InputChanged;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(0, 305);
            label8.Name = "label8";
            label8.Size = new Size(460, 40);
            label8.TabIndex = 28;
            label8.Text = "Ghi chú";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_Address
            // 
            txt_Address.BackColor = SystemColors.Window;
            txt_Address.BorderColor = Color.Gray;
            txt_Address.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Address.BorderRadius = 8;
            txt_Address.BorderSize = 2;
            txt_Address.Dock = DockStyle.Top;
            txt_Address.Font = new Font("Segoe UI", 9.5F);
            txt_Address.ForeColor = Color.DimGray;
            txt_Address.Location = new Point(0, 193);
            txt_Address.Margin = new Padding(4);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Padding = new Padding(7);
            txt_Address.PasswordChar = false;
            txt_Address.PlaceholderColor = Color.DarkGray;
            txt_Address.PlaceholderText = "";
            txt_Address.Size = new Size(460, 112);
            txt_Address.TabIndex = 27;
            txt_Address.TextAlign = HorizontalAlignment.Left;
            txt_Address.Texts = "";
            txt_Address.UnderlinedStyle = false;
            txt_Address._TextChanged += InputChanged;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.Location = new Point(0, 153);
            label10.Name = "label10";
            label10.Size = new Size(460, 40);
            label10.TabIndex = 26;
            label10.Text = "Địa chỉ";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_Cohort
            // 
            txt_Cohort.BackColor = SystemColors.Window;
            txt_Cohort.BorderColor = Color.Gray;
            txt_Cohort.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Cohort.BorderRadius = 8;
            txt_Cohort.BorderSize = 2;
            txt_Cohort.Dock = DockStyle.Top;
            txt_Cohort.Font = new Font("Segoe UI", 9.5F);
            txt_Cohort.ForeColor = Color.DimGray;
            txt_Cohort.Location = new Point(0, 118);
            txt_Cohort.Margin = new Padding(4);
            txt_Cohort.Multiline = false;
            txt_Cohort.Name = "txt_Cohort";
            txt_Cohort.Padding = new Padding(7);
            txt_Cohort.PasswordChar = false;
            txt_Cohort.PlaceholderColor = Color.DarkGray;
            txt_Cohort.PlaceholderText = "";
            txt_Cohort.Size = new Size(460, 35);
            txt_Cohort.TabIndex = 25;
            txt_Cohort.TextAlign = HorizontalAlignment.Left;
            txt_Cohort.Texts = "";
            txt_Cohort.UnderlinedStyle = false;
            txt_Cohort._TextChanged += InputChanged;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(0, 78);
            label11.Name = "label11";
            label11.Size = new Size(460, 40);
            label11.TabIndex = 24;
            label11.Text = "*Khoá học";
            label11.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmb_Major
            // 
            cmb_Major.BackColor = Color.White;
            cmb_Major.BorderColor = Color.Gray;
            cmb_Major.BorderSize = 2;
            cmb_Major.Dock = DockStyle.Top;
            cmb_Major.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Major.Font = new Font("Segoe UI", 10F);
            cmb_Major.ForeColor = Color.DimGray;
            cmb_Major.IconColor = Color.Gray;
            cmb_Major.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Major.ListTextColor = Color.DimGray;
            cmb_Major.Location = new Point(0, 40);
            cmb_Major.MinimumSize = new Size(200, 30);
            cmb_Major.Name = "cmb_Major";
            cmb_Major.Padding = new Padding(0, 0, 0, 2);
            cmb_Major.Size = new Size(460, 38);
            cmb_Major.TabIndex = 30;
            cmb_Major.Texts = "";
            cmb_Major.OnSelectedIndexChanged += InputChanged;
            // 
            // label16
            // 
            label16.Dock = DockStyle.Top;
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(460, 40);
            label16.TabIndex = 20;
            label16.Text = "*Chuyên ngành";
            label16.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(txt_Email);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txt_Phone);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txt_Identity);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(splitContainer2);
            panel3.Controls.Add(splitContainer1);
            panel3.Controls.Add(txt_Code);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(240, 20);
            panel3.Margin = new Padding(20);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 452);
            panel3.TabIndex = 3;
            // 
            // txt_Email
            // 
            txt_Email.BackColor = SystemColors.Window;
            txt_Email.BorderColor = Color.Gray;
            txt_Email.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Email.BorderRadius = 8;
            txt_Email.BorderSize = 2;
            txt_Email.Dock = DockStyle.Top;
            txt_Email.Font = new Font("Segoe UI", 9.5F);
            txt_Email.ForeColor = Color.DimGray;
            txt_Email.Location = new Point(0, 417);
            txt_Email.Margin = new Padding(4);
            txt_Email.Multiline = false;
            txt_Email.Name = "txt_Email";
            txt_Email.Padding = new Padding(7);
            txt_Email.PasswordChar = false;
            txt_Email.PlaceholderColor = Color.DarkGray;
            txt_Email.PlaceholderText = "";
            txt_Email.Size = new Size(460, 35);
            txt_Email.TabIndex = 29;
            txt_Email.TextAlign = HorizontalAlignment.Left;
            txt_Email.Texts = "";
            txt_Email.UnderlinedStyle = false;
            txt_Email._TextChanged += InputChanged;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 377);
            label6.Name = "label6";
            label6.Size = new Size(460, 40);
            label6.TabIndex = 28;
            label6.Text = "*Email";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_Phone
            // 
            txt_Phone.BackColor = SystemColors.Window;
            txt_Phone.BorderColor = Color.Gray;
            txt_Phone.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Phone.BorderRadius = 8;
            txt_Phone.BorderSize = 2;
            txt_Phone.Dock = DockStyle.Top;
            txt_Phone.Font = new Font("Segoe UI", 9.5F);
            txt_Phone.ForeColor = Color.DimGray;
            txt_Phone.Location = new Point(0, 342);
            txt_Phone.Margin = new Padding(4);
            txt_Phone.Multiline = false;
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Padding = new Padding(7);
            txt_Phone.PasswordChar = false;
            txt_Phone.PlaceholderColor = Color.DarkGray;
            txt_Phone.PlaceholderText = "";
            txt_Phone.Size = new Size(460, 35);
            txt_Phone.TabIndex = 27;
            txt_Phone.TextAlign = HorizontalAlignment.Left;
            txt_Phone.Texts = "";
            txt_Phone.UnderlinedStyle = false;
            txt_Phone._TextChanged += InputChanged;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 302);
            label5.Name = "label5";
            label5.Size = new Size(460, 40);
            label5.TabIndex = 26;
            label5.Text = "*Số điện thoại";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_Identity
            // 
            txt_Identity.BackColor = SystemColors.Window;
            txt_Identity.BorderColor = Color.Gray;
            txt_Identity.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Identity.BorderRadius = 8;
            txt_Identity.BorderSize = 2;
            txt_Identity.Dock = DockStyle.Top;
            txt_Identity.Font = new Font("Segoe UI", 9.5F);
            txt_Identity.ForeColor = Color.DimGray;
            txt_Identity.Location = new Point(0, 267);
            txt_Identity.Margin = new Padding(4);
            txt_Identity.Multiline = false;
            txt_Identity.Name = "txt_Identity";
            txt_Identity.Padding = new Padding(7);
            txt_Identity.PasswordChar = false;
            txt_Identity.PlaceholderColor = Color.DarkGray;
            txt_Identity.PlaceholderText = "";
            txt_Identity.Size = new Size(460, 35);
            txt_Identity.TabIndex = 25;
            txt_Identity.TextAlign = HorizontalAlignment.Left;
            txt_Identity.Texts = "";
            txt_Identity.UnderlinedStyle = false;
            txt_Identity._TextChanged += InputChanged;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 227);
            label3.Name = "label3";
            label3.Size = new Size(460, 40);
            label3.TabIndex = 24;
            label3.Text = "*Căn cước công dân";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Top;
            splitContainer2.Location = new Point(0, 153);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dpBirth);
            splitContainer2.Panel1.Controls.Add(label4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(cmb_Gender);
            splitContainer2.Panel2.Controls.Add(label7);
            splitContainer2.Size = new Size(460, 74);
            splitContainer2.SplitterDistance = 220;
            splitContainer2.SplitterWidth = 20;
            splitContainer2.TabIndex = 31;
            // 
            // dpBirth
            // 
            dpBirth.BorderColor = Color.Gray;
            dpBirth.BorderRadius = 8;
            dpBirth.BorderSize = 2;
            dpBirth.Dock = DockStyle.Fill;
            dpBirth.Font = new Font("Segoe UI", 9.5F);
            dpBirth.Format = DateTimePickerFormat.Short;
            dpBirth.Location = new Point(0, 40);
            dpBirth.MinimumSize = new Size(0, 35);
            dpBirth.Name = "dpBirth";
            dpBirth.Size = new Size(220, 35);
            dpBirth.SkinColor = Color.White;
            dpBirth.TabIndex = 11;
            dpBirth.TextColor = Color.Gray;
            dpBirth.ValueChanged += InputChanged;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(220, 40);
            label4.TabIndex = 10;
            label4.Text = "Ngày sinh";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmb_Gender
            // 
            cmb_Gender.BackColor = Color.White;
            cmb_Gender.BorderColor = Color.Gray;
            cmb_Gender.BorderSize = 2;
            cmb_Gender.Dock = DockStyle.Fill;
            cmb_Gender.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_Gender.Font = new Font("Segoe UI", 10F);
            cmb_Gender.ForeColor = Color.DimGray;
            cmb_Gender.IconColor = Color.Gray;
            cmb_Gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmb_Gender.ListBackColor = Color.FromArgb(230, 228, 245);
            cmb_Gender.ListTextColor = Color.DimGray;
            cmb_Gender.Location = new Point(0, 40);
            cmb_Gender.MinimumSize = new Size(200, 30);
            cmb_Gender.Name = "cmb_Gender";
            cmb_Gender.Padding = new Padding(0, 0, 0, 2);
            cmb_Gender.Size = new Size(220, 34);
            cmb_Gender.TabIndex = 11;
            cmb_Gender.Texts = "";
            cmb_Gender.OnSelectedIndexChanged += InputChanged;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(220, 40);
            label7.TabIndex = 10;
            label7.Text = "Giới tính";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 75);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txt_LastName);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txt_FirstName);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(460, 78);
            splitContainer1.SplitterDistance = 220;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 30;
            // 
            // txt_LastName
            // 
            txt_LastName.BackColor = SystemColors.Window;
            txt_LastName.BorderColor = Color.Gray;
            txt_LastName.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_LastName.BorderRadius = 8;
            txt_LastName.BorderSize = 2;
            txt_LastName.Dock = DockStyle.Top;
            txt_LastName.Font = new Font("Segoe UI", 9.5F);
            txt_LastName.ForeColor = Color.DimGray;
            txt_LastName.Location = new Point(0, 40);
            txt_LastName.Margin = new Padding(4);
            txt_LastName.Multiline = false;
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Padding = new Padding(7);
            txt_LastName.PasswordChar = false;
            txt_LastName.PlaceholderColor = Color.DarkGray;
            txt_LastName.PlaceholderText = "";
            txt_LastName.Size = new Size(220, 35);
            txt_LastName.TabIndex = 11;
            txt_LastName.TextAlign = HorizontalAlignment.Left;
            txt_LastName.Texts = "";
            txt_LastName.UnderlinedStyle = false;
            txt_LastName._TextChanged += InputChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 40);
            label1.TabIndex = 10;
            label1.Text = "Họ đệm";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_FirstName
            // 
            txt_FirstName.BackColor = SystemColors.Window;
            txt_FirstName.BorderColor = Color.Gray;
            txt_FirstName.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_FirstName.BorderRadius = 8;
            txt_FirstName.BorderSize = 2;
            txt_FirstName.Dock = DockStyle.Top;
            txt_FirstName.Font = new Font("Segoe UI", 9.5F);
            txt_FirstName.ForeColor = Color.DimGray;
            txt_FirstName.Location = new Point(0, 40);
            txt_FirstName.Margin = new Padding(4);
            txt_FirstName.Multiline = false;
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Padding = new Padding(7);
            txt_FirstName.PasswordChar = false;
            txt_FirstName.PlaceholderColor = Color.DarkGray;
            txt_FirstName.PlaceholderText = "";
            txt_FirstName.Size = new Size(220, 35);
            txt_FirstName.TabIndex = 11;
            txt_FirstName.TextAlign = HorizontalAlignment.Left;
            txt_FirstName.Texts = "";
            txt_FirstName.UnderlinedStyle = false;
            txt_FirstName._TextChanged += InputChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 40);
            label2.TabIndex = 10;
            label2.Text = "*Tên";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txt_Code
            // 
            txt_Code.BackColor = SystemColors.Window;
            txt_Code.BorderColor = Color.Gray;
            txt_Code.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txt_Code.BorderRadius = 8;
            txt_Code.BorderSize = 2;
            txt_Code.Dock = DockStyle.Top;
            txt_Code.Enabled = false;
            txt_Code.Font = new Font("Segoe UI", 9.5F);
            txt_Code.ForeColor = Color.DimGray;
            txt_Code.Location = new Point(0, 40);
            txt_Code.Margin = new Padding(4);
            txt_Code.Multiline = false;
            txt_Code.Name = "txt_Code";
            txt_Code.Padding = new Padding(7);
            txt_Code.PasswordChar = false;
            txt_Code.PlaceholderColor = Color.DarkGray;
            txt_Code.PlaceholderText = "";
            txt_Code.Size = new Size(460, 35);
            txt_Code.TabIndex = 21;
            txt_Code.TextAlign = HorizontalAlignment.Left;
            txt_Code.Texts = "";
            txt_Code.UnderlinedStyle = false;
            txt_Code._TextChanged += InputChanged;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(460, 40);
            label9.TabIndex = 20;
            label9.Text = "*Mã sinh viên";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // customPictureBox1
            // 
            customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            customPictureBox1.BorderColor1 = Color.RoyalBlue;
            customPictureBox1.BorderColor2 = Color.HotPink;
            customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            customPictureBox1.BorderSize = 2;
            customPictureBox1.Dock = DockStyle.Fill;
            customPictureBox1.GradientAngle = 50F;
            customPictureBox1.Location = new Point(0, 50);
            customPictureBox1.Margin = new Padding(0, 50, 20, 0);
            customPictureBox1.MaximumSize = new Size(200, 0);
            customPictureBox1.MinimumSize = new Size(200, 0);
            customPictureBox1.Name = "customPictureBox1";
            customPictureBox1.Size = new Size(200, 200);
            customPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            customPictureBox1.TabIndex = 2;
            customPictureBox1.TabStop = false;
            // 
            // Student_Infor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel7);
            Name = "Student_Infor";
            Size = new Size(1247, 600);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private CustomControls.CustomButton btn_Delete;
        private CustomControls.CustomButton btn_Edit;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private CustomControls.CustomTextBox txt_Note;
        private Label label8;
        private CustomControls.CustomTextBox txt_Address;
        private Label label10;
        private CustomControls.CustomTextBox txt_Cohort;
        private Label label11;
        private Label label16;
        private Panel panel3;
        private CustomControls.CustomTextBox txt_Email;
        private Label label6;
        private CustomControls.CustomTextBox txt_Phone;
        private Label label5;
        private CustomControls.CustomTextBox txt_Identity;
        private Label label3;
        private CustomControls.CustomTextBox txt_Code;
        private Label label9;
        private CustomControls.CustomPictureBox customPictureBox1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label4;
        private CustomControls.CustomComboBox cmb_Gender;
        private Label label7;
        private CustomControls.CustomTextBox txt_LastName;
        private Label label1;
        private CustomControls.CustomTextBox txt_FirstName;
        private Label label2;
        private CustomControls.CustomComboBox cmb_Major;
        private CustomControls.CustomDatePicker dpBirth;
    }
}
