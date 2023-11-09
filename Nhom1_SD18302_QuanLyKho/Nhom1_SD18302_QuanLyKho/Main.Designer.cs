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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClose = new PictureBox();
            btnMaxSize = new PictureBox();
            btnMinSize = new PictureBox();
            imgMenu = new PictureBox();
            pnSidebar = new FlowLayoutPanel();
            pnNguoiDung = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnTrangChu = new Panel();
            button7 = new Button();
            pnNhanvien = new Panel();
            button1 = new Button();
            pnSanpham = new Panel();
            button2 = new Button();
            pnKhachhang = new Panel();
            button3 = new Button();
            pnNhacungcap = new Panel();
            button4 = new Button();
            pnMenuMini = new Panel();
            button10 = new Button();
            button9 = new Button();
            btnThongKe = new Button();
            pnHoadon = new Panel();
            button5 = new Button();
            pnDangxuat = new Panel();
            button8 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            pnMenu = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaxSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMenu).BeginInit();
            pnSidebar.SuspendLayout();
            pnNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnTrangChu.SuspendLayout();
            pnNhanvien.SuspendLayout();
            pnSanpham.SuspendLayout();
            pnKhachhang.SuspendLayout();
            pnNhacungcap.SuspendLayout();
            pnMenuMini.SuspendLayout();
            pnHoadon.SuspendLayout();
            pnDangxuat.SuspendLayout();
            pnMenu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Controls.Add(btnClose, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMaxSize, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMinSize, 0, 0);
            tableLayoutPanel1.Location = new Point(902, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(95, 34);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(65, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 8;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaxSize
            // 
            btnMaxSize.Image = (Image)resources.GetObject("btnMaxSize.Image");
            btnMaxSize.Location = new Point(34, 3);
            btnMaxSize.Name = "btnMaxSize";
            btnMaxSize.Size = new Size(24, 24);
            btnMaxSize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaxSize.TabIndex = 7;
            btnMaxSize.TabStop = false;
            btnMaxSize.Click += btnMaxSize_Click;
            // 
            // btnMinSize
            // 
            btnMinSize.Image = (Image)resources.GetObject("btnMinSize.Image");
            btnMinSize.Location = new Point(3, 3);
            btnMinSize.Name = "btnMinSize";
            btnMinSize.Size = new Size(24, 24);
            btnMinSize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinSize.TabIndex = 6;
            btnMinSize.TabStop = false;
            btnMinSize.Click += btnMinSize_Click;
            // 
            // imgMenu
            // 
            imgMenu.Image = (Image)resources.GetObject("imgMenu.Image");
            imgMenu.Location = new Point(3, 3);
            imgMenu.Name = "imgMenu";
            imgMenu.Size = new Size(29, 34);
            imgMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMenu.TabIndex = 5;
            imgMenu.TabStop = false;
            imgMenu.Click += imgMenu_Click;
            // 
            // pnSidebar
            // 
            pnSidebar.BackColor = Color.FromArgb(71, 72, 83);
            pnSidebar.Controls.Add(pnNguoiDung);
            pnSidebar.Controls.Add(pnTrangChu);
            pnSidebar.Controls.Add(pnNhanvien);
            pnSidebar.Controls.Add(pnSanpham);
            pnSidebar.Controls.Add(pnKhachhang);
            pnSidebar.Controls.Add(pnNhacungcap);
            pnSidebar.Controls.Add(pnMenuMini);
            pnSidebar.Controls.Add(pnHoadon);
            pnSidebar.Controls.Add(pnDangxuat);
            pnSidebar.Dock = DockStyle.Left;
            pnSidebar.Location = new Point(0, 40);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(180, 660);
            pnSidebar.TabIndex = 1;
            // 
            // pnNguoiDung
            // 
            pnNguoiDung.Controls.Add(linkLabel1);
            pnNguoiDung.Controls.Add(label1);
            pnNguoiDung.Controls.Add(pictureBox1);
            pnNguoiDung.Dock = DockStyle.Top;
            pnNguoiDung.Location = new Point(3, 3);
            pnNguoiDung.Name = "pnNguoiDung";
            pnNguoiDung.Size = new Size(180, 180);
            pnNguoiDung.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(33, 144);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 117);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "tên người dùng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnTrangChu
            // 
            pnTrangChu.Controls.Add(button7);
            pnTrangChu.Location = new Point(3, 189);
            pnTrangChu.Name = "pnTrangChu";
            pnTrangChu.Size = new Size(180, 40);
            pnTrangChu.TabIndex = 3;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(71, 72, 83);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(170, 160, 160);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(180, 30);
            button7.TabIndex = 0;
            button7.Text = "        Trang chủ";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // pnNhanvien
            // 
            pnNhanvien.Controls.Add(button1);
            pnNhanvien.Location = new Point(3, 235);
            pnNhanvien.Name = "pnNhanvien";
            pnNhanvien.Size = new Size(180, 40);
            pnNhanvien.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(71, 72, 83);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(170, 160, 160);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(180, 30);
            button1.TabIndex = 0;
            button1.Text = "        Nhân viên";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // pnSanpham
            // 
            pnSanpham.Controls.Add(button2);
            pnSanpham.Location = new Point(3, 281);
            pnSanpham.Name = "pnSanpham";
            pnSanpham.Size = new Size(180, 40);
            pnSanpham.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(71, 72, 83);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(170, 160, 160);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(180, 30);
            button2.TabIndex = 0;
            button2.Text = "        Sản Phẩm";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pnKhachhang
            // 
            pnKhachhang.Controls.Add(button3);
            pnKhachhang.Location = new Point(3, 327);
            pnKhachhang.Name = "pnKhachhang";
            pnKhachhang.Size = new Size(180, 40);
            pnKhachhang.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(71, 72, 83);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(170, 160, 160);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(180, 30);
            button3.TabIndex = 0;
            button3.Text = "        Khách hàng";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // pnNhacungcap
            // 
            pnNhacungcap.Controls.Add(button4);
            pnNhacungcap.Location = new Point(3, 373);
            pnNhacungcap.Name = "pnNhacungcap";
            pnNhacungcap.Size = new Size(180, 40);
            pnNhacungcap.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(71, 72, 83);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(170, 160, 160);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(180, 30);
            button4.TabIndex = 0;
            button4.Text = "        Nhà cung cấp";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // pnMenuMini
            // 
            pnMenuMini.Controls.Add(button10);
            pnMenuMini.Controls.Add(button9);
            pnMenuMini.Controls.Add(btnThongKe);
            pnMenuMini.Location = new Point(3, 419);
            pnMenuMini.Name = "pnMenuMini";
            pnMenuMini.Size = new Size(180, 40);
            pnMenuMini.TabIndex = 4;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(71, 72, 83);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.FromArgb(170, 160, 160);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 87);
            button10.Name = "button10";
            button10.Padding = new Padding(10, 0, 0, 0);
            button10.Size = new Size(180, 30);
            button10.TabIndex = 0;
            button10.Text = "        Doanh thu";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(71, 72, 83);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.FromArgb(170, 160, 160);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 44);
            button9.Name = "button9";
            button9.Padding = new Padding(10, 0, 0, 0);
            button9.Size = new Size(180, 30);
            button9.TabIndex = 0;
            button9.Text = "        Chi tiêu";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(71, 72, 83);
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.FromArgb(170, 160, 160);
            btnThongKe.Image = (Image)resources.GetObject("btnThongKe.Image");
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 0);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 0, 0);
            btnThongKe.Size = new Size(180, 30);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "        Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // pnHoadon
            // 
            pnHoadon.Controls.Add(button5);
            pnHoadon.Location = new Point(3, 465);
            pnHoadon.Name = "pnHoadon";
            pnHoadon.Size = new Size(180, 40);
            pnHoadon.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(71, 72, 83);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(170, 160, 160);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(180, 30);
            button5.TabIndex = 0;
            button5.Text = "        Hóa đơn";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // pnDangxuat
            // 
            pnDangxuat.Controls.Add(button8);
            pnDangxuat.Location = new Point(3, 511);
            pnDangxuat.Name = "pnDangxuat";
            pnDangxuat.Size = new Size(180, 40);
            pnDangxuat.TabIndex = 4;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(71, 72, 83);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.FromArgb(170, 160, 160);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 0);
            button8.Name = "button8";
            button8.Padding = new Padding(10, 0, 0, 0);
            button8.Size = new Size(180, 30);
            button8.TabIndex = 0;
            button8.Text = "        Đăng xuất";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.FromArgb(134, 179, 209);
            pnMenu.Controls.Add(tableLayoutPanel2);
            pnMenu.Dock = DockStyle.Top;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(1000, 40);
            pnMenu.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 2, 0);
            tableLayoutPanel2.Controls.Add(imgMenu, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1000, 40);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 0);
            label2.Size = new Size(246, 30);
            label2.TabIndex = 6;
            label2.Text = "Vật liệu xây dựng Đông Anh";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1000, 700);
            Controls.Add(pnSidebar);
            Controls.Add(pnMenu);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaxSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMenu).EndInit();
            pnSidebar.ResumeLayout(false);
            pnNguoiDung.ResumeLayout(false);
            pnNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnTrangChu.ResumeLayout(false);
            pnNhanvien.ResumeLayout(false);
            pnSanpham.ResumeLayout(false);
            pnKhachhang.ResumeLayout(false);
            pnNhacungcap.ResumeLayout(false);
            pnMenuMini.ResumeLayout(false);
            pnHoadon.ResumeLayout(false);
            pnDangxuat.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel pnSidebar;
        private Panel pnNguoiDung;
        private LinkLabel linkLabel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnTrangChu;
        private Button button7;
        private Panel pnNhanvien;
        private Button button1;
        private Panel pnSanpham;
        private Button button2;
        private Panel pnKhachhang;
        private Button button3;
        private Panel pnNhacungcap;
        private Button button4;
        private Panel pnHoadon;
        private Button button5;
        private Panel pnMenuMini;
        private Button btnThongKe;
        private Panel pnDangxuat;
        private Button button8;
        private PictureBox imgMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox btnClose;
        private PictureBox btnMaxSize;
        private PictureBox btnMinSize;
        private Button button10;
        private Button button9;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel pnMenu;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
    }
}