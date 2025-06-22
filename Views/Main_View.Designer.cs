using BTL.CustomControls;

namespace BTL.Views
{
    partial class Main_View
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
            components = new System.ComponentModel.Container();
            customPanel1 = new CustomPanel();
            pnlChildForm = new CustomPanel();
            panel2 = new Panel();
            pnlButton = new FlowLayoutPanel();
            btnGeneral = new CustomButton();
            btnStudent = new CustomButton();
            btnClass = new CustomButton();
            btnScoreboard = new CustomButton();
            btnDeletedList = new CustomButton();
            btn_Settings = new CustomButton();
            label1 = new Label();
            panel1 = new Panel();
            customPictureBox1 = new CustomPictureBox();
            btnNoficate = new CustomButton();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            customPanel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlButton.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(54, 0, 51);
            customPanel1.BackColor1 = Color.FromArgb(54, 0, 51);
            customPanel1.BackColor2 = Color.Cyan;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderSize = 0;
            customPanel1.Controls.Add(pnlChildForm);
            customPanel1.Controls.Add(panel2);
            customPanel1.Controls.Add(panel1);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.GradientAngle = 70F;
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Radius = new Padding(0);
            customPanel1.Size = new Size(1382, 803);
            customPanel1.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            pnlChildForm.BackColor = Color.White;
            pnlChildForm.BackColor1 = Color.White;
            pnlChildForm.BackColor2 = Color.White;
            pnlChildForm.BorderColor = Color.Black;
            pnlChildForm.BorderSize = 0;
            pnlChildForm.Dock = DockStyle.Fill;
            pnlChildForm.GradientAngle = 20F;
            pnlChildForm.Location = new Point(100, 100);
            pnlChildForm.Margin = new Padding(0);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Padding = new Padding(5);
            pnlChildForm.Radius = new Padding(80, 0, 0, 0);
            pnlChildForm.Size = new Size(1282, 703);
            pnlChildForm.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pnlButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 703);
            panel2.TabIndex = 1;
            // 
            // pnlButton
            // 
            pnlButton.AutoSize = true;
            pnlButton.Controls.Add(btnGeneral);
            pnlButton.Controls.Add(btnStudent);
            pnlButton.Controls.Add(btnClass);
            pnlButton.Controls.Add(btnScoreboard);
            pnlButton.Controls.Add(btnDeletedList);
            pnlButton.Controls.Add(btn_Settings);
            pnlButton.FlowDirection = FlowDirection.TopDown;
            pnlButton.Location = new Point(20, 70);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(60, 615);
            pnlButton.TabIndex = 1;
            // 
            // btnGeneral
            // 
            btnGeneral.BackColor = Color.Transparent;
            btnGeneral.BorderColor = Color.FromArgb(54, 0, 51);
            btnGeneral.BorderRadius = 25;
            btnGeneral.BorderSize = 0;
            btnGeneral.FlatAppearance.BorderColor = Color.White;
            btnGeneral.FlatAppearance.BorderSize = 0;
            btnGeneral.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGeneral.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGeneral.FlatStyle = FlatStyle.Flat;
            btnGeneral.ForeColor = Color.White;
            btnGeneral.IconChar = FontAwesome.Sharp.IconChar.TriangleCircleSquare;
            btnGeneral.IconColor = Color.LightCoral;
            btnGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGeneral.IconSize = 30;
            btnGeneral.Location = new Point(5, 5);
            btnGeneral.Margin = new Padding(5);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(50, 50);
            btnGeneral.TabIndex = 0;
            btnGeneral.TabStop = false;
            btnGeneral.Tag = "Quản lý chung";
            btnGeneral.UseVisualStyleBackColor = false;
            btnGeneral.Click += BtnGeneral_Click;
            btnGeneral.MouseEnter += BtnStudent_MouseEnter;
            btnGeneral.MouseLeave += BtnStudent_MouseLeave;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.BorderColor = Color.PaleVioletRed;
            btnStudent.BorderRadius = 25;
            btnStudent.BorderSize = 0;
            btnStudent.FlatAppearance.BorderColor = Color.White;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStudent.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.ForeColor = Color.White;
            btnStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            btnStudent.IconColor = Color.LightCoral;
            btnStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudent.IconSize = 30;
            btnStudent.Location = new Point(5, 65);
            btnStudent.Margin = new Padding(5);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(50, 50);
            btnStudent.TabIndex = 1;
            btnStudent.TabStop = false;
            btnStudent.Tag = "Quản lý sinh viên";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += BtnStudent_Click;
            btnStudent.MouseEnter += BtnStudent_MouseEnter;
            btnStudent.MouseLeave += BtnStudent_MouseLeave;
            // 
            // btnClass
            // 
            btnClass.BackColor = Color.Transparent;
            btnClass.BorderColor = Color.PaleVioletRed;
            btnClass.BorderRadius = 25;
            btnClass.BorderSize = 0;
            btnClass.FlatAppearance.BorderColor = Color.White;
            btnClass.FlatAppearance.BorderSize = 0;
            btnClass.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClass.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClass.FlatStyle = FlatStyle.Flat;
            btnClass.ForeColor = Color.White;
            btnClass.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            btnClass.IconColor = Color.LightCoral;
            btnClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClass.IconSize = 35;
            btnClass.Location = new Point(5, 125);
            btnClass.Margin = new Padding(5);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(50, 50);
            btnClass.TabIndex = 2;
            btnClass.TabStop = false;
            btnClass.Tag = "Quản lý lớp học";
            btnClass.UseVisualStyleBackColor = false;
            btnClass.Click += BtnClass_Click;
            btnClass.MouseEnter += BtnStudent_MouseEnter;
            btnClass.MouseLeave += BtnStudent_MouseLeave;
            // 
            // btnScoreboard
            // 
            btnScoreboard.BackColor = Color.Transparent;
            btnScoreboard.BorderColor = Color.PaleVioletRed;
            btnScoreboard.BorderRadius = 25;
            btnScoreboard.BorderSize = 0;
            btnScoreboard.FlatAppearance.BorderColor = Color.White;
            btnScoreboard.FlatAppearance.BorderSize = 0;
            btnScoreboard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnScoreboard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnScoreboard.FlatStyle = FlatStyle.Flat;
            btnScoreboard.ForeColor = Color.White;
            btnScoreboard.IconChar = FontAwesome.Sharp.IconChar.FileClipboard;
            btnScoreboard.IconColor = Color.LightCoral;
            btnScoreboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScoreboard.IconSize = 35;
            btnScoreboard.Location = new Point(5, 185);
            btnScoreboard.Margin = new Padding(5);
            btnScoreboard.Name = "btnScoreboard";
            btnScoreboard.Size = new Size(50, 50);
            btnScoreboard.TabIndex = 5;
            btnScoreboard.TabStop = false;
            btnScoreboard.Tag = "Quản lý điểm số";
            btnScoreboard.UseVisualStyleBackColor = false;
            btnScoreboard.Click += BtnScoreboard_Click;
            btnScoreboard.MouseEnter += BtnStudent_MouseEnter;
            btnScoreboard.MouseLeave += BtnStudent_MouseLeave;
            // 
            // btnDeletedList
            // 
            btnDeletedList.BackColor = Color.Transparent;
            btnDeletedList.BorderColor = Color.PaleVioletRed;
            btnDeletedList.BorderRadius = 25;
            btnDeletedList.BorderSize = 0;
            btnDeletedList.FlatAppearance.BorderColor = Color.White;
            btnDeletedList.FlatAppearance.BorderSize = 0;
            btnDeletedList.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDeletedList.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDeletedList.FlatStyle = FlatStyle.Flat;
            btnDeletedList.ForeColor = Color.White;
            btnDeletedList.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnDeletedList.IconColor = Color.LightCoral;
            btnDeletedList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeletedList.IconSize = 30;
            btnDeletedList.Location = new Point(5, 245);
            btnDeletedList.Margin = new Padding(5);
            btnDeletedList.Name = "btnDeletedList";
            btnDeletedList.Size = new Size(50, 50);
            btnDeletedList.TabIndex = 4;
            btnDeletedList.TabStop = false;
            btnDeletedList.Tag = "Quản lý xoá";
            btnDeletedList.UseVisualStyleBackColor = false;
            btnDeletedList.Click += BtnDeletedList_Click;
            btnDeletedList.MouseEnter += BtnStudent_MouseEnter;
            btnDeletedList.MouseLeave += BtnStudent_MouseLeave;
            // 
            // btn_Settings
            // 
            btn_Settings.BackColor = Color.Transparent;
            btn_Settings.BorderColor = Color.PaleVioletRed;
            btn_Settings.BorderRadius = 25;
            btn_Settings.BorderSize = 0;
            btn_Settings.FlatAppearance.BorderColor = Color.White;
            btn_Settings.FlatAppearance.BorderSize = 0;
            btn_Settings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Settings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Settings.FlatStyle = FlatStyle.Flat;
            btn_Settings.ForeColor = Color.White;
            btn_Settings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btn_Settings.IconColor = Color.LightCoral;
            btn_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Settings.IconSize = 30;
            btn_Settings.Location = new Point(5, 305);
            btn_Settings.Margin = new Padding(5);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(50, 50);
            btn_Settings.TabIndex = 6;
            btn_Settings.TabStop = false;
            btn_Settings.Tag = "Cài đặt hệ thống";
            btn_Settings.UseVisualStyleBackColor = false;
            btn_Settings.Click += Btn_Settings_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Helvetica Rounded", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 60);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(customPictureBox1);
            panel1.Controls.Add(btnNoficate);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 100);
            panel1.TabIndex = 0;
            // 
            // customPictureBox1
            // 
            customPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            customPictureBox1.BorderColor1 = SystemColors.HotTrack;
            customPictureBox1.BorderColor2 = Color.Cyan;
            customPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            customPictureBox1.BorderSize = 2;
            customPictureBox1.GradientAngle = 50F;
            customPictureBox1.Location = new Point(1310, 12);
            customPictureBox1.Name = "customPictureBox1";
            customPictureBox1.Size = new Size(60, 60);
            customPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            customPictureBox1.TabIndex = 0;
            customPictureBox1.TabStop = false;
            // 
            // btnNoficate
            // 
            btnNoficate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNoficate.BackColor = Color.Transparent;
            btnNoficate.BorderColor = Color.PaleVioletRed;
            btnNoficate.BorderRadius = 30;
            btnNoficate.BorderSize = 0;
            btnNoficate.FlatAppearance.BorderColor = Color.White;
            btnNoficate.FlatAppearance.BorderSize = 0;
            btnNoficate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNoficate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNoficate.FlatStyle = FlatStyle.Flat;
            btnNoficate.ForeColor = Color.White;
            btnNoficate.IconChar = FontAwesome.Sharp.IconChar.Bell;
            btnNoficate.IconColor = Color.LightCoral;
            btnNoficate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNoficate.IconSize = 30;
            btnNoficate.Location = new Point(1242, 14);
            btnNoficate.Margin = new Padding(5);
            btnNoficate.Name = "btnNoficate";
            btnNoficate.Padding = new Padding(1, 3, 0, 0);
            btnNoficate.Size = new Size(60, 60);
            btnNoficate.TabIndex = 2;
            btnNoficate.TabStop = false;
            btnNoficate.Tag = "Thông báo";
            btnNoficate.UseVisualStyleBackColor = false;
            btnNoficate.MouseEnter += BtnStudent_MouseEnter;
            btnNoficate.MouseLeave += BtnStudent_MouseLeave;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Helvetica Rounded", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(30, 0, 0, 0);
            label2.Size = new Size(344, 100);
            label2.TabIndex = 1;
            label2.Text = "LOGO";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Main_View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1382, 803);
            Controls.Add(customPanel1);
            MinimumSize = new Size(1400, 850);
            Name = "Main_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_View";
            WindowState = FormWindowState.Maximized;
            customPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlButton.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel pnlButton;
        private CustomControls.CustomButton btnGeneral;
        private CustomControls.CustomButton btnStudent;
        private Label label1;
        private CustomControls.CustomButton btnClass;
        private Label label2;
        private CustomControls.CustomPanel customPanel1;
        private CustomControls.CustomPictureBox customPictureBox1;
        private CustomControls.CustomButton btnNoficate;
        private CustomControls.CustomButton btnDeletedList;
        private CustomControls.CustomButton btnScoreboard;
        private CustomControls.CustomPanel pnlChildForm;
        private ToolTip toolTip1;
        private CustomButton btn_Settings;
    }
}