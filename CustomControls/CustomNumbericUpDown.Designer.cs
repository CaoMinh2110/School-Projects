namespace BTL.CustomControls
{
    partial class CustomNumbericUpDown
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
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(7, 7);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(236, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.Click += numericUpDown1_Click;
            numericUpDown1.Enter += numericUpDown1_Enter;
            numericUpDown1.KeyDown += numericUpDown1_KeyDown;
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
            numericUpDown1.Leave += numericUpDown1_Leave;
            // 
            // CustomNumbericUpDown
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(numericUpDown1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DimGray;
            Margin = new Padding(4);
            Name = "CustomNumbericUpDown";
            Padding = new Padding(7);
            Size = new Size(250, 37);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion;
        private NumericUpDown numericUpDown1;
    }
}
