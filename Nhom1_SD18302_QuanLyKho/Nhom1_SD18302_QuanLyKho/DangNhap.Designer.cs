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
            panel2 = new Panel();
            label1 = new Label();
            lblTenTaiKhoan = new Label();
            lblMatKhau = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenTaiKhoan);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblMatKhau);
            panel1.Controls.Add(lblTenTaiKhoan);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 402);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(424, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 399);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 31);
            label1.Name = "label1";
            label1.Size = new Size(168, 35);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenTaiKhoan.Location = new Point(12, 171);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new Size(116, 23);
            lblTenTaiKhoan.TabIndex = 0;
            lblTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(12, 222);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 23);
            lblMatKhau.TabIndex = 0;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(153, 45);
            label4.Name = "label4";
            label4.Size = new Size(115, 35);
            label4.TabIndex = 0;
            label4.Text = "HELLO!!!";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 91);
            label5.Name = "label5";
            label5.Size = new Size(346, 33);
            label5.TabIndex = 0;
            label5.Text = "Chào mừng bạn đến với vật liệu xây dựng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(159, 134);
            label6.Name = "label6";
            label6.Size = new Size(109, 33);
            label6.TabIndex = 0;
            label6.Text = "Đông Anh";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(140, 167);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(225, 27);
            txtTenTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(140, 218);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(225, 27);
            txtMatKhau.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(134, 179, 209);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(130, 273);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 181);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblMatKhau;
        private Label lblTenTaiKhoan;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox txtMatKhau;
        private TextBox txtTenTaiKhoan;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox2;
    }
}