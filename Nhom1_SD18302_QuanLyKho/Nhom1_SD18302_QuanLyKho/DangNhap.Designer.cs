namespace Nhom1_SD18302_QuanLyKho
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            panel1 = new Panel();
            label1 = new Label();
            lblTenTaiKhoan = new Label();
            lblMatKhau = new Label();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            pictureBox1 = new PictureBox();
            btnDangNhap = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(425, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 455);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 62);
            label1.Name = "label1";
            label1.Size = new Size(168, 35);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenTaiKhoan.Location = new Point(22, 212);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new Size(117, 23);
            lblTenTaiKhoan.TabIndex = 2;
            lblTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(22, 273);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(88, 23);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(145, 208);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(247, 27);
            txtTenTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(145, 269);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(247, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(157, 337);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(108, 38);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(145, 60);
            label2.Name = "label2";
            label2.Size = new Size(115, 35);
            label2.TabIndex = 0;
            label2.Text = "HELLO!!!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 153);
            label3.Name = "label3";
            label3.Size = new Size(336, 23);
            label3.TabIndex = 1;
            label3.Text = "Chào mừng bạn đến với vật liệu xây dựng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(155, 191);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 2;
            label4.Text = "Đông Anh";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangNhap);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenTaiKhoan);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblTenTaiKhoan;
        private Label lblMatKhau;
        private TextBox txtTenTaiKhoan;
        private TextBox txtMatKhau;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDangNhap;
    }
}