﻿namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuChi));
            dgvThongtin = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThongtin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvThongtin
            // 
            dgvThongtin.BackgroundColor = SystemColors.ActiveBorder;
            dgvThongtin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongtin.Location = new Point(11, 164);
            dgvThongtin.Margin = new Padding(4);
            dgvThongtin.Name = "dgvThongtin";
            dgvThongtin.RowHeadersWidth = 51;
            dgvThongtin.RowTemplate.Height = 29;
            dgvThongtin.Size = new Size(796, 295);
            dgvThongtin.TabIndex = 54;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(170, 160, 160);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 30);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(337, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 49;
            label1.Text = "THU CHI";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmThuChi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 160, 160);
            ClientSize = new Size(820, 660);
            Controls.Add(dgvThongtin);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThuChi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thu Chi";
            ((System.ComponentModel.ISupportInitialize)dgvThongtin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThongtin;
        private PictureBox pictureBox1;
        private Label label1;
    }
}