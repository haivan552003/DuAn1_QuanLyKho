namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(170, 160, 160);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 40);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(71, 72, 83);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(180, 613);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}