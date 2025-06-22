namespace BTL.Views
{
    partial class CourseCategories_View
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
            txt_Name = new CustomControls.CustomTextBox();
            label2 = new Label();
            txt_ID = new CustomControls.CustomTextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDelete = new CustomControls.CustomButton();
            btnEdit = new CustomControls.CustomButton();
            btnAdd = new CustomControls.CustomButton();
            customPanel1 = new CustomControls.CustomPanel();
            panel3 = new Panel();
            dgvList = new DataGridView();
            customPanel2 = new CustomControls.CustomPanel();
            pnlHeaderText = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            customPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            customPanel2.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(929, 512);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_ID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(606, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(320, 506);
            panel1.TabIndex = 1;
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
            txt_Name.Location = new Point(10, 114);
            txt_Name.Margin = new Padding(4);
            txt_Name.Multiline = false;
            txt_Name.Name = "txt_Name";
            txt_Name.Padding = new Padding(7);
            txt_Name.PasswordChar = false;
            txt_Name.PlaceholderColor = Color.DimGray;
            txt_Name.PlaceholderText = "";
            txt_Name.Size = new Size(300, 34);
            txt_Name.TabIndex = 6;
            txt_Name.TextAlign = HorizontalAlignment.Left;
            txt_Name.Texts = "";
            txt_Name.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(300, 40);
            label2.TabIndex = 5;
            label2.Text = "Tên nhóm học phần";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            txt_ID.Location = new Point(10, 40);
            txt_ID.Margin = new Padding(4);
            txt_ID.Multiline = false;
            txt_ID.Name = "txt_ID";
            txt_ID.Padding = new Padding(7);
            txt_ID.PasswordChar = false;
            txt_ID.PlaceholderColor = Color.DimGray;
            txt_ID.PlaceholderText = "";
            txt_ID.Size = new Size(300, 34);
            txt_ID.TabIndex = 4;
            txt_ID.TextAlign = HorizontalAlignment.Left;
            txt_ID.Texts = "";
            txt_ID.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(10, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(300, 40);
            label1.TabIndex = 3;
            label1.Text = "Mã nhóm học phần";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3344421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3311119F));
            tableLayoutPanel2.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel2.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(10, 446);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(300, 60);
            tableLayoutPanel2.TabIndex = 2;
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
            btnDelete.Location = new Point(210, 10);
            btnDelete.Margin = new Padding(10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 40);
            btnDelete.TabIndex = 2;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
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
            btnEdit.Location = new Point(110, 10);
            btnEdit.Margin = new Padding(10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 40);
            btnEdit.TabIndex = 1;
            btnEdit.TabStop = false;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gray;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 8;
            btnAdd.BorderSize = 0;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderColor = Color.Gray;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 90, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(10, 10);
            btnAdd.Margin = new Padding(10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 40);
            btnAdd.TabIndex = 0;
            btnAdd.TabStop = false;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor1 = Color.White;
            customPanel1.BackColor2 = Color.White;
            customPanel1.BorderColor = Color.Gray;
            customPanel1.BorderSize = 2;
            customPanel1.Controls.Add(panel3);
            customPanel1.Controls.Add(customPanel2);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.GradientAngle = 20F;
            customPanel1.Location = new Point(3, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(10);
            customPanel1.Radius = new Padding(20);
            customPanel1.Size = new Size(597, 506);
            customPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvList);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 60);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15, 0, 15, 0);
            panel3.Size = new Size(577, 436);
            panel3.TabIndex = 10;
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
            dgvList.Size = new Size(547, 436);
            dgvList.TabIndex = 0;
            dgvList.CellClick += DgvList_CellClick;
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
            customPanel2.Location = new Point(10, 10);
            customPanel2.Name = "customPanel2";
            customPanel2.Padding = new Padding(15, 5, 15, 5);
            customPanel2.Radius = new Padding(15);
            customPanel2.Size = new Size(577, 50);
            customPanel2.TabIndex = 9;
            // 
            // pnlHeaderText
            // 
            pnlHeaderText.BackColor = Color.Transparent;
            pnlHeaderText.ColumnCount = 2;
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlHeaderText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlHeaderText.Controls.Add(label3, 0, 0);
            pnlHeaderText.Controls.Add(label4, 1, 0);
            pnlHeaderText.Dock = DockStyle.Fill;
            pnlHeaderText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlHeaderText.Location = new Point(15, 5);
            pnlHeaderText.Margin = new Padding(0);
            pnlHeaderText.Name = "pnlHeaderText";
            pnlHeaderText.RowCount = 1;
            pnlHeaderText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeaderText.Size = new Size(547, 40);
            pnlHeaderText.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(267, 40);
            label3.TabIndex = 4;
            label3.Text = "Mã nhóm học phần";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(276, 0);
            label4.Name = "label4";
            label4.Size = new Size(268, 40);
            label4.TabIndex = 2;
            label4.Text = "Tên nhóm học phần";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CourseCategories_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CourseCategories_View";
            Size = new Size(929, 512);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            customPanel2.ResumeLayout(false);
            pnlHeaderText.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private CustomControls.CustomTextBox txt_Name;
        private Label label2;
        private CustomControls.CustomTextBox txt_ID;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.CustomButton btnDelete;
        private CustomControls.CustomButton btnEdit;
        private CustomControls.CustomButton btnAdd;
        private CustomControls.CustomPanel customPanel1;
        private Panel panel3;
        private DataGridView dgvList;
        private CustomControls.CustomPanel customPanel2;
        private TableLayoutPanel pnlHeaderText;
        private Label label3;
        private Label label4;
    }
}
