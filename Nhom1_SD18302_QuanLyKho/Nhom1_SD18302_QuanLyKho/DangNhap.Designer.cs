namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            label1 = new Label();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            pictureBox1 = new PictureBox();
            imgSlide = new PictureBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            btnHidePass = new PictureBox();
            panel1 = new Panel();
            imageList2 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgSlide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHidePass).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 100);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenTaiKhoan.Location = new Point(33, 154);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.PlaceholderText = "Tài khoản:";
            txtTenTaiKhoan.Size = new Size(277, 30);
            txtTenTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(33, 201);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Mật khẩu:";
            txtMatKhau.Size = new Size(277, 30);
            txtMatKhau.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // imgSlide
            // 
            imgSlide.Location = new Point(-2, -2);
            imgSlide.Name = "imgSlide";
            imgSlide.Size = new Size(801, 452);
            imgSlide.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSlide.TabIndex = 3;
            imgSlide.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DarkBlue;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.Location = new Point(219, 348);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Padding = new Padding(5, 0, 5, 0);
            btnDangNhap.Size = new Size(148, 45);
            btnDangNhap.TabIndex = 30;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Maroon;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(414, 348);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(5, 0, 5, 0);
            btnThoat.Size = new Size(148, 45);
            btnThoat.TabIndex = 32;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "img1.jpg");
            imageList1.Images.SetKeyName(1, "img2.jpg");
            imageList1.Images.SetKeyName(2, "img3.jpg");
            imageList1.Images.SetKeyName(3, "img4.jpg");
            imageList1.Images.SetKeyName(4, "img5.jpg");
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(278, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnHidePass
            // 
            btnHidePass.Location = new Point(279, 204);
            btnHidePass.Name = "btnHidePass";
            btnHidePass.Size = new Size(24, 24);
            btnHidePass.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHidePass.TabIndex = 4;
            btnHidePass.TabStop = false;
            btnHidePass.Click += btnHidePass_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtTenTaiKhoan);
            panel1.Controls.Add(btnHidePass);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(219, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 272);
            panel1.TabIndex = 33;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "internet.png");
            imageList2.Images.SetKeyName(1, "uninternet.png");
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(imgSlide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgSlide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHidePass).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtTenTaiKhoan;
        private TextBox txtMatKhau;
        private PictureBox pictureBox1;
        private PictureBox imgSlide;
        private Button btnDangNhap;
        private Button btnThoat;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private PictureBox btnHidePass;
        private Panel panel1;
        private ImageList imageList2;
    }
}