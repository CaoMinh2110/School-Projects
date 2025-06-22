namespace BTL.Views.Class
{
    partial class AssessmentTypes_Detail
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
            btn_Save = new CustomControls.CustomButton();
            panel1 = new Panel();
            pnlPointList = new Panel();
            panel3 = new Panel();
            btn_AddAssessment = new CustomControls.CustomButton();
            label3 = new Label();
            btn_Exit = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btn_Save, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_Exit, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(600, 730);
            tableLayoutPanel1.TabIndex = 10;
            tableLayoutPanel1.Paint += PanelContainer_Paint;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.Gray;
            btn_Save.BorderColor = Color.PaleVioletRed;
            btn_Save.BorderRadius = 8;
            btn_Save.BorderSize = 0;
            btn_Save.Dock = DockStyle.Fill;
            btn_Save.FlatAppearance.BorderColor = Color.Gray;
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 90, 255);
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_Save.ForeColor = Color.White;
            btn_Save.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_Save.IconColor = Color.Black;
            btn_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Save.Location = new Point(100, 650);
            btn_Save.Margin = new Padding(80, 0, 80, 0);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(400, 60);
            btn_Save.TabIndex = 13;
            btn_Save.TabStop = false;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += BtnSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlPointList);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(20, 62);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 588);
            panel1.TabIndex = 12;
            // 
            // pnlPointList
            // 
            pnlPointList.AutoSize = true;
            pnlPointList.Dock = DockStyle.Fill;
            pnlPointList.Location = new Point(0, 60);
            pnlPointList.Name = "pnlPointList";
            pnlPointList.Size = new Size(560, 528);
            pnlPointList.TabIndex = 65;
            pnlPointList.ControlAdded += PnlPointList_ControlAdded;
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
            panel3.TabIndex = 64;
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
            label3.Text = "Các đầu điểm";
            label3.TextAlign = ContentAlignment.MiddleLeft;
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
            // AssessmentTypes_Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 730);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssessmentTypes_Detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssessmentTypes_Detail";
            Activated += AssessmentTypesDetail_Activated;
            ResizeEnd += AssessmentTypesDetail_ResizeEnd;
            SizeChanged += AssessmentTypesDetail_SizeChanged;
            Paint += AssessmentTypesDetail_Paint;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private Panel panel1;
        private Panel panel3;
        private CustomControls.CustomButton btn_AddAssessment;
        private Label label3;
        private CustomControls.CustomButton btn_Save;
        private Panel pnlPointList;
    }
}