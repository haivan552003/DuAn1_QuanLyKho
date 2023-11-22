namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmInPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInPhieuXuat));
            btnIn = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            lblChucVu = new Label();
            lblTen = new Label();
            lblNgay = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(134, 179, 209);
            btnIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIn.ForeColor = Color.White;
            btnIn.Image = (Image)resources.GetObject("btnIn.Image");
            btnIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnIn.Location = new Point(570, 12);
            btnIn.Name = "btnIn";
            btnIn.Padding = new Padding(10, 0, 20, 0);
            btnIn.Size = new Size(100, 45);
            btnIn.TabIndex = 8;
            btnIn.Text = "In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lblChucVu);
            panel1.Controls.Add(lblTen);
            panel1.Controls.Add(lblNgay);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 780);
            panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(624, 444);
            dataGridView1.TabIndex = 3;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblChucVu.Location = new Point(94, 102);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(22, 23);
            lblChucVu.TabIndex = 2;
            lblChucVu.Text = "...";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTen.Location = new Point(116, 78);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(22, 23);
            lblTen.TabIndex = 2;
            lblTen.Text = "...";
            lblTen.Click += label4_Click;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgay.Location = new Point(453, 40);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(22, 23);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(445, 586);
            label7.Name = "label7";
            label7.Size = new Size(137, 23);
            label7.TabIndex = 2;
            label7.Text = "Người viết phiếu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 102);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 2;
            label5.Text = "Chức vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 78);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 2;
            label3.Text = "Người xuất:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(393, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 2;
            label2.Text = "Ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(445, 13);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 1;
            label1.Text = "PHIẾU XUẤT HÀNG";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmInPhieuXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 171, 184);
            ClientSize = new Size(682, 853);
            Controls.Add(panel1);
            Controls.Add(btnIn);
            Name = "frmInPhieuXuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "In Phiếu Xuất";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIn;
        private Panel panel1;
        private Label lblNgay;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label lblChucVu;
        private Label lblTen;
        private Label label7;
        private Label label5;
        private Label label3;
    }
}