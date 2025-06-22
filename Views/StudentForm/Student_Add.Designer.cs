namespace BTL.Views.StudentForm
{
    partial class Student_Add
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
            panelContainer = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            cbxMajor = new CustomControls.CustomComboBox();
            txtNote = new CustomControls.CustomTextBox();
            label14 = new Label();
            txtCohort = new CustomControls.CustomTextBox();
            label10 = new Label();
            label7 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            dpBirth = new CustomControls.CustomDatePicker();
            txtIdentity = new CustomControls.CustomTextBox();
            label13 = new Label();
            txtAddress = new CustomControls.CustomTextBox();
            label12 = new Label();
            txtEmail = new CustomControls.CustomTextBox();
            label3 = new Label();
            txtPhone = new CustomControls.CustomTextBox();
            label4 = new Label();
            label11 = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            cbxGender = new CustomControls.CustomComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            txtName = new CustomControls.CustomTextBox();
            label2 = new Label();
            txtId = new CustomControls.CustomTextBox();
            label5 = new Label();
            customPictureBox1 = new CustomControls.CustomPictureBox();
            pnlButton = new Panel();
            btnAdd = new CustomControls.CustomButton();
            panelContainer.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).BeginInit();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.Control;
            panelContainer.Controls.Add(tableLayoutPanel2);
            panelContainer.Controls.Add(tableLayoutPanel3);
            panelContainer.Controls.Add(pnlButton);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(30);
            panelContainer.Size = new Size(850, 700);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint;
            panelContainer.MouseDown += panelTitleBar_MouseDown;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(30, 210);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(790, 396);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbxMajor);
            panel3.Controls.Add(txtNote);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtCohort);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.Gray;
            panel3.Location = new Point(395, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 396);
            panel3.TabIndex = 1;
            // 
            // cbxMajor
            // 
            cbxMajor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxMajor.BackColor = SystemColors.Control;
            cbxMajor.BorderColor = Color.Gray;
            cbxMajor.BorderSize = 2;
            cbxMajor.DropDownStyle = ComboBoxStyle.DropDown;
            cbxMajor.Font = new Font("Segoe UI", 9F);
            cbxMajor.ForeColor = Color.Gray;
            cbxMajor.IconColor = Color.Gray;
            cbxMajor.ListBackColor = SystemColors.Control;
            cbxMajor.ListTextColor = Color.Gray;
            cbxMajor.Location = new Point(126, 73);
            cbxMajor.MinimumSize = new Size(200, 30);
            cbxMajor.Name = "cbxMajor";
            cbxMajor.Padding = new Padding(0, 0, 0, 2);
            cbxMajor.Size = new Size(236, 35);
            cbxMajor.TabIndex = 20;
            cbxMajor.Tag = "MajorID";
            cbxMajor.Texts = "";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.BackColor = Color.White;
            txtNote.BorderColor = Color.Gray;
            txtNote.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtNote.BorderRadius = 8;
            txtNote.BorderSize = 2;
            txtNote.Font = new Font("Segoe UI", 9F);
            txtNote.ForeColor = Color.FromArgb(27, 90, 255);
            txtNote.Location = new Point(126, 193);
            txtNote.Margin = new Padding(4);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Padding = new Padding(7);
            txtNote.PasswordChar = false;
            txtNote.PlaceholderColor = Color.Gray;
            txtNote.PlaceholderText = "";
            txtNote.Size = new Size(236, 154);
            txtNote.TabIndex = 22;
            txtNote.Tag = "Note";
            txtNote.TextAlign = HorizontalAlignment.Left;
            txtNote.Texts = "";
            txtNote.UnderlinedStyle = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 199);
            label14.Name = "label14";
            label14.Size = new Size(73, 23);
            label14.TabIndex = 7;
            label14.Text = "Ghi chú:";
            // 
            // txtCohort
            // 
            txtCohort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCohort.BackColor = Color.White;
            txtCohort.BorderColor = Color.Gray;
            txtCohort.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtCohort.BorderRadius = 8;
            txtCohort.BorderSize = 2;
            txtCohort.Font = new Font("Segoe UI", 9F);
            txtCohort.ForeColor = Color.FromArgb(27, 90, 255);
            txtCohort.Location = new Point(126, 133);
            txtCohort.Margin = new Padding(4);
            txtCohort.Multiline = false;
            txtCohort.Name = "txtCohort";
            txtCohort.Padding = new Padding(7);
            txtCohort.PasswordChar = false;
            txtCohort.PlaceholderColor = Color.Gray;
            txtCohort.PlaceholderText = "";
            txtCohort.Size = new Size(236, 34);
            txtCohort.TabIndex = 21;
            txtCohort.Tag = "Cohort";
            txtCohort.TextAlign = HorizontalAlignment.Left;
            txtCohort.Texts = "";
            txtCohort.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 139);
            label10.Name = "label10";
            label10.Size = new Size(86, 23);
            label10.TabIndex = 5;
            label10.Text = "Khoá học:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 79);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 3;
            label7.Text = "Ngành học:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(10, 10);
            label9.Name = "label9";
            label9.Size = new Size(255, 38);
            label9.TabIndex = 0;
            label9.Text = "Thông tin học vấn";
            // 
            // panel1
            // 
            panel1.Controls.Add(dpBirth);
            panel1.Controls.Add(txtIdentity);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Gray;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 396);
            panel1.TabIndex = 0;
            // 
            // dpBirth
            // 
            dpBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dpBirth.BorderColor = Color.Gray;
            dpBirth.BorderRadius = 8;
            dpBirth.BorderSize = 2;
            dpBirth.Font = new Font("Segoe UI", 9.5F);
            dpBirth.Format = DateTimePickerFormat.Short;
            dpBirth.Location = new Point(124, 71);
            dpBirth.MinimumSize = new Size(0, 35);
            dpBirth.Name = "dpBirth";
            dpBirth.Size = new Size(237, 35);
            dpBirth.SkinColor = Color.White;
            dpBirth.TabIndex = 16;
            dpBirth.TextColor = Color.Gray;
            // 
            // txtIdentity
            // 
            txtIdentity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdentity.BackColor = Color.White;
            txtIdentity.BorderColor = Color.Gray;
            txtIdentity.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtIdentity.BorderRadius = 8;
            txtIdentity.BorderSize = 2;
            txtIdentity.Font = new Font("Segoe UI", 9F);
            txtIdentity.ForeColor = Color.FromArgb(27, 90, 255);
            txtIdentity.Location = new Point(125, 313);
            txtIdentity.Margin = new Padding(4);
            txtIdentity.Multiline = false;
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Padding = new Padding(7);
            txtIdentity.PasswordChar = false;
            txtIdentity.PlaceholderColor = Color.Gray;
            txtIdentity.PlaceholderText = "";
            txtIdentity.Size = new Size(236, 34);
            txtIdentity.TabIndex = 14;
            txtIdentity.Tag = "IdentityNumber";
            txtIdentity.TextAlign = HorizontalAlignment.Left;
            txtIdentity.Texts = "";
            txtIdentity.UnderlinedStyle = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 319);
            label13.Name = "label13";
            label13.Size = new Size(68, 23);
            label13.TabIndex = 15;
            label13.Text = "*CDDD:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BackColor = Color.White;
            txtAddress.BorderColor = Color.Gray;
            txtAddress.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtAddress.BorderRadius = 8;
            txtAddress.BorderSize = 2;
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.ForeColor = Color.FromArgb(27, 90, 255);
            txtAddress.Location = new Point(125, 253);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.Padding = new Padding(7);
            txtAddress.PasswordChar = false;
            txtAddress.PlaceholderColor = Color.Gray;
            txtAddress.PlaceholderText = "";
            txtAddress.Size = new Size(236, 34);
            txtAddress.TabIndex = 13;
            txtAddress.Tag = "Address";
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.Texts = "";
            txtAddress.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 259);
            label12.Name = "label12";
            label12.Size = new Size(66, 23);
            label12.TabIndex = 13;
            label12.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.BorderColor = Color.Gray;
            txtEmail.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtEmail.BorderRadius = 8;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.ForeColor = Color.FromArgb(27, 90, 255);
            txtEmail.Location = new Point(125, 193);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.Gray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(236, 34);
            txtEmail.TabIndex = 12;
            txtEmail.Tag = "Email";
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 199);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 11;
            label3.Text = "*Email:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.BackColor = Color.White;
            txtPhone.BorderColor = Color.Gray;
            txtPhone.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtPhone.BorderRadius = 8;
            txtPhone.BorderSize = 2;
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.ForeColor = Color.FromArgb(27, 90, 255);
            txtPhone.Location = new Point(125, 133);
            txtPhone.Margin = new Padding(4);
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(7);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.Gray;
            txtPhone.PlaceholderText = "";
            txtPhone.Size = new Size(236, 34);
            txtPhone.TabIndex = 11;
            txtPhone.Tag = "Phone";
            txtPhone.TextAlign = HorizontalAlignment.Left;
            txtPhone.Texts = "";
            txtPhone.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 139);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 9;
            label4.Text = "*Số ĐT:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 79);
            label11.Name = "label11";
            label11.Size = new Size(97, 23);
            label11.TabIndex = 7;
            label11.Text = "*Ngày sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel2, 1, 0);
            tableLayoutPanel3.Controls.Add(customPictureBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(30, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(790, 180);
            tableLayoutPanel3.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxGender);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Gray;
            panel2.Location = new Point(200, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 180);
            panel2.TabIndex = 1;
            // 
            // cbxGender
            // 
            cbxGender.BackColor = SystemColors.Control;
            cbxGender.BorderColor = Color.Gray;
            cbxGender.BorderSize = 2;
            cbxGender.DropDownStyle = ComboBoxStyle.DropDown;
            cbxGender.Font = new Font("Segoe UI", 9F);
            cbxGender.ForeColor = Color.Gray;
            cbxGender.IconColor = Color.Gray;
            cbxGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbxGender.ListBackColor = SystemColors.Control;
            cbxGender.ListTextColor = Color.Gray;
            cbxGender.Location = new Point(195, 119);
            cbxGender.MinimumSize = new Size(200, 30);
            cbxGender.Name = "cbxGender";
            cbxGender.Padding = new Padding(0, 0, 0, 2);
            cbxGender.Size = new Size(220, 35);
            cbxGender.TabIndex = 3;
            cbxGender.Tag = "Gender";
            cbxGender.Texts = "";
            // 
            // iconButton1
            // 
            iconButton1.AutoSize = true;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderColor = SystemColors.Control;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            iconButton1.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.DimGray;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(554, 0);
            iconButton1.MaximumSize = new Size(36, 36);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(36, 36);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += BtnExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 125);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 5;
            label6.Text = "Giới tính:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderColor = Color.Gray;
            txtName.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtName.BorderRadius = 8;
            txtName.BorderSize = 2;
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.ForeColor = Color.FromArgb(27, 90, 255);
            txtName.Location = new Point(195, 70);
            txtName.Margin = new Padding(4);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(13, 7, 7, 7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.Gray;
            txtName.PlaceholderText = "";
            txtName.Size = new Size(220, 34);
            txtName.TabIndex = 2;
            txtName.Tag = "Name";
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.Texts = "";
            txtName.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 76);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 3;
            label2.Text = "*Họ tên:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderColor = Color.Gray;
            txtId.BorderFocusColor = Color.FromArgb(27, 90, 255);
            txtId.BorderRadius = 8;
            txtId.BorderSize = 2;
            txtId.Font = new Font("Segoe UI", 9F);
            txtId.ForeColor = Color.FromArgb(27, 90, 255);
            txtId.Location = new Point(195, 21);
            txtId.Margin = new Padding(4);
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.Padding = new Padding(13, 7, 7, 7);
            txtId.PasswordChar = false;
            txtId.PlaceholderColor = Color.Gray;
            txtId.PlaceholderText = "";
            txtId.Size = new Size(220, 34);
            txtId.TabIndex = 1;
            txtId.Tag = "Id";
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.Texts = "";
            txtId.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 27);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 1;
            label5.Text = "*Mã SV:";
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
            customPictureBox1.Location = new Point(20, 0);
            customPictureBox1.Margin = new Padding(20, 0, 20, 0);
            customPictureBox1.Name = "customPictureBox1";
            customPictureBox1.Size = new Size(160, 160);
            customPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            customPictureBox1.TabIndex = 0;
            customPictureBox1.TabStop = false;
            // 
            // pnlButton
            // 
            pnlButton.Controls.Add(btnAdd);
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlButton.ForeColor = Color.White;
            pnlButton.Location = new Point(30, 606);
            pnlButton.Name = "pnlButton";
            pnlButton.Padding = new Padding(90, 0, 90, 0);
            pnlButton.Size = new Size(790, 64);
            pnlButton.TabIndex = 22;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 10;
            btnAdd.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderColor = Color.Gray;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 90, 255);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 90, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(90, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(610, 64);
            btnAdd.TabIndex = 0;
            btnAdd.TabStop = false;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // Student_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 700);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student_Add";
            Activated += Student_Add_Activated;
            ResizeEnd += Student_Add_ResizeEnd;
            SizeChanged += Student_Add_SizeChanged;
            Paint += Student_Add_Paint;
            panelContainer.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).EndInit();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private CustomControls.CustomComboBox cbxMajor;
        private CustomControls.CustomTextBox txtNote;
        private Label label14;
        private CustomControls.CustomTextBox txtCohort;
        private Label label10;
        private Label label7;
        private Label label9;
        private Panel panel1;
        private CustomControls.CustomTextBox txtIdentity;
        private Label label13;
        private CustomControls.CustomTextBox txtAddress;
        private Label label12;
        private CustomControls.CustomTextBox txtEmail;
        private Label label3;
        private CustomControls.CustomTextBox txtPhone;
        private Label label4;
        private Label label11;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private CustomControls.CustomComboBox cbxGender;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label6;
        private CustomControls.CustomTextBox txtName;
        private Label label2;
        private CustomControls.CustomTextBox txtId;
        private Label label5;
        private CustomControls.CustomPictureBox customPictureBox1;
        private Panel pnlButton;
        private CustomControls.CustomButton btnAdd;
        private CustomControls.CustomDatePicker dpBirth;
    }
}