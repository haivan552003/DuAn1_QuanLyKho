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
            btnMinSize = new PictureBox();
            imgMenu = new PictureBox();
            pnSidebar = new FlowLayoutPanel();
            pnNguoiDung = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            lblTenND = new Label();
            pnTrangChu = new Panel();
            btnTrangChu = new Button();
            pnNhanvien = new Panel();
            btnNhanVien = new Button();
            pnDanhMucSanpham = new Panel();
            btnDanhMuc = new Button();
            btnSanPham = new Button();
            btnDanhMucSP = new Button();
            pnKhachhang = new Panel();
            btnKhachHang = new Button();
            pnNhacungcap = new Panel();
            btnNhaCungCap = new Button();
            pnPhieu = new Panel();
            btnPhieuXuat = new Button();
            btnPhieuNhap = new Button();
            btnHoaDon = new Button();
            btnPhieu = new Button();
            pnMenuMini = new Panel();
            btnDoanhThu = new Button();
            btnChiTieu = new Button();
            btnThongKe = new Button();
            pnDangxuat = new Panel();
            btnDangXuat = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            pnMenu = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            phieuTransition = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMenu).BeginInit();
            pnSidebar.SuspendLayout();
            pnNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnTrangChu.SuspendLayout();
            pnNhanvien.SuspendLayout();
            pnDanhMucSanpham.SuspendLayout();
            pnKhachhang.SuspendLayout();
            pnNhacungcap.SuspendLayout();
            pnPhieu.SuspendLayout();
            pnMenuMini.SuspendLayout();
            pnDangxuat.SuspendLayout();
            pnMenu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.4246559F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.5753441F));
            tableLayoutPanel1.Controls.Add(btnClose, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMinSize, 0, 0);
            tableLayoutPanel1.Location = new Point(933, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(64, 25);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(37, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 19);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 8;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinSize
            // 
            btnMinSize.Image = (Image)resources.GetObject("btnMinSize.Image");
            btnMinSize.Location = new Point(3, 3);
            btnMinSize.Name = "btnMinSize";
            btnMinSize.Size = new Size(25, 19);
            btnMinSize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinSize.TabIndex = 6;
            btnMinSize.TabStop = false;
            btnMinSize.Click += btnMinSize_Click;
            // 
            // imgMenu
            // 
            imgMenu.Dock = DockStyle.Right;
            imgMenu.Image = (Image)resources.GetObject("imgMenu.Image");
            imgMenu.Location = new Point(15, 3);
            imgMenu.Name = "imgMenu";
            imgMenu.Size = new Size(29, 34);
            imgMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMenu.TabIndex = 5;
            imgMenu.TabStop = false;
            imgMenu.Click += imgMenu_Click;
            // 
            // pnSidebar
            // 
            pnSidebar.BackColor = Color.FromArgb(36, 40, 77);
            pnSidebar.Controls.Add(pnNguoiDung);
            pnSidebar.Controls.Add(pnTrangChu);
            pnSidebar.Controls.Add(pnNhanvien);
            pnSidebar.Controls.Add(pnDanhMucSanpham);
            pnSidebar.Controls.Add(pnKhachhang);
            pnSidebar.Controls.Add(pnNhacungcap);
            pnSidebar.Controls.Add(pnPhieu);
            pnSidebar.Controls.Add(pnMenuMini);
            pnSidebar.Controls.Add(pnDangxuat);
            pnSidebar.Dock = DockStyle.Left;
            pnSidebar.Location = new Point(0, 40);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(180, 660);
            pnSidebar.TabIndex = 1;
            // 
            // pnNguoiDung
            // 
            pnNguoiDung.Controls.Add(pictureBox1);
            pnNguoiDung.Controls.Add(linkLabel1);
            pnNguoiDung.Controls.Add(lblTenND);
            pnNguoiDung.Dock = DockStyle.Top;
            pnNguoiDung.Location = new Point(3, 3);
            pnNguoiDung.Name = "pnNguoiDung";
            pnNguoiDung.Size = new Size(180, 180);
            pnNguoiDung.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 192, 255);
            linkLabel1.Location = new Point(33, 144);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đổi mật khẩu";
            // 
            // lblTenND
            // 
            lblTenND.AutoSize = true;
            lblTenND.Location = new Point(3, 115);
            lblTenND.Name = "lblTenND";
            lblTenND.Size = new Size(111, 20);
            lblTenND.TabIndex = 1;
            lblTenND.Text = "tên người dùng";
            // 
            // pnTrangChu
            // 
            pnTrangChu.Controls.Add(btnTrangChu);
            pnTrangChu.Location = new Point(3, 189);
            pnTrangChu.Name = "pnTrangChu";
            pnTrangChu.Size = new Size(180, 40);
            pnTrangChu.TabIndex = 3;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.FromArgb(36, 40, 77);
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Image = (Image)resources.GetObject("btnTrangChu.Image");
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(10, 0, 0, 0);
            btnTrangChu.Size = new Size(180, 30);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "        Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // pnNhanvien
            // 
            pnNhanvien.Controls.Add(btnNhanVien);
            pnNhanvien.Location = new Point(3, 235);
            pnNhanvien.Name = "pnNhanvien";
            pnNhanvien.Size = new Size(180, 40);
            pnNhanvien.TabIndex = 4;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(36, 40, 77);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10, 0, 0, 0);
            btnNhanVien.Size = new Size(180, 30);
            btnNhanVien.TabIndex = 0;
            btnNhanVien.Text = "        Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // pnDanhMucSanpham
            // 
            pnDanhMucSanpham.Controls.Add(btnDanhMuc);
            pnDanhMucSanpham.Controls.Add(btnSanPham);
            pnDanhMucSanpham.Controls.Add(btnDanhMucSP);
            pnDanhMucSanpham.Location = new Point(3, 281);
            pnDanhMucSanpham.Name = "pnDanhMucSanpham";
            pnDanhMucSanpham.Size = new Size(180, 40);
            pnDanhMucSanpham.TabIndex = 4;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.FromArgb(36, 40, 77);
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDanhMuc.ForeColor = Color.White;
            btnDanhMuc.Image = (Image)resources.GetObject("btnDanhMuc.Image");
            btnDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.Location = new Point(0, 90);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Padding = new Padding(10, 0, 0, 0);
            btnDanhMuc.Size = new Size(180, 30);
            btnDanhMuc.TabIndex = 0;
            btnDanhMuc.Text = "        Danh Mục";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(36, 40, 77);
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.Image = (Image)resources.GetObject("btnSanPham.Image");
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 45);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10, 0, 0, 0);
            btnSanPham.Size = new Size(180, 30);
            btnSanPham.TabIndex = 0;
            btnSanPham.Text = "        Sản Phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.UseVisualStyleBackColor = false;
            // 
            // btnDanhMucSP
            // 
            btnDanhMucSP.BackColor = Color.FromArgb(36, 40, 77);
            btnDanhMucSP.FlatAppearance.BorderSize = 0;
            btnDanhMucSP.FlatStyle = FlatStyle.Flat;
            btnDanhMucSP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDanhMucSP.ForeColor = Color.White;
            btnDanhMucSP.Image = (Image)resources.GetObject("btnDanhMucSP.Image");
            btnDanhMucSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhMucSP.Location = new Point(0, 0);
            btnDanhMucSP.Name = "btnDanhMucSP";
            btnDanhMucSP.Padding = new Padding(10, 0, 0, 0);
            btnDanhMucSP.Size = new Size(180, 30);
            btnDanhMucSP.TabIndex = 0;
            btnDanhMucSP.Text = "        Sản Phẩm";
            btnDanhMucSP.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMucSP.UseVisualStyleBackColor = false;
            btnDanhMucSP.Click += btnDanhMucSP_Click;
            // 
            // pnKhachhang
            // 
            pnKhachhang.Controls.Add(btnKhachHang);
            pnKhachhang.Location = new Point(3, 327);
            pnKhachhang.Name = "pnKhachhang";
            pnKhachhang.Size = new Size(180, 40);
            pnKhachhang.TabIndex = 4;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(36, 40, 77);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 0);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(10, 0, 0, 0);
            btnKhachHang.Size = new Size(180, 30);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "        Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // pnNhacungcap
            // 
            pnNhacungcap.Controls.Add(btnNhaCungCap);
            pnNhacungcap.Location = new Point(3, 373);
            pnNhacungcap.Name = "pnNhacungcap";
            pnNhacungcap.Size = new Size(180, 40);
            pnNhacungcap.TabIndex = 4;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(36, 40, 77);
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.Image = (Image)resources.GetObject("btnNhaCungCap.Image");
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(0, 0);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10, 0, 0, 0);
            btnNhaCungCap.Size = new Size(180, 30);
            btnNhaCungCap.TabIndex = 0;
            btnNhaCungCap.Text = "        Nhà cung cấp";
            btnNhaCungCap.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // pnPhieu
            // 
            pnPhieu.Controls.Add(btnPhieuXuat);
            pnPhieu.Controls.Add(btnPhieuNhap);
            pnPhieu.Controls.Add(btnHoaDon);
            pnPhieu.Controls.Add(btnPhieu);
            pnPhieu.Location = new Point(3, 419);
            pnPhieu.Name = "pnPhieu";
            pnPhieu.Size = new Size(180, 40);
            pnPhieu.TabIndex = 4;
            // 
            // btnPhieuXuat
            // 
            btnPhieuXuat.BackColor = Color.FromArgb(36, 40, 77);
            btnPhieuXuat.FlatAppearance.BorderSize = 0;
            btnPhieuXuat.FlatStyle = FlatStyle.Flat;
            btnPhieuXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPhieuXuat.ForeColor = Color.White;
            btnPhieuXuat.Image = (Image)resources.GetObject("btnPhieuXuat.Image");
            btnPhieuXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuXuat.Location = new Point(0, 138);
            btnPhieuXuat.Name = "btnPhieuXuat";
            btnPhieuXuat.Padding = new Padding(10, 0, 0, 0);
            btnPhieuXuat.Size = new Size(180, 30);
            btnPhieuXuat.TabIndex = 0;
            btnPhieuXuat.Text = "        Phiếu Xuất";
            btnPhieuXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuXuat.UseVisualStyleBackColor = false;
            btnPhieuXuat.Click += btnPhieuXuat_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = Color.FromArgb(36, 40, 77);
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPhieuNhap.ForeColor = Color.White;
            btnPhieuNhap.Image = (Image)resources.GetObject("btnPhieuNhap.Image");
            btnPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.Location = new Point(0, 93);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Padding = new Padding(10, 0, 0, 0);
            btnPhieuNhap.Size = new Size(180, 30);
            btnPhieuNhap.TabIndex = 0;
            btnPhieuNhap.Text = "        Phiếu Nhập";
            btnPhieuNhap.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(36, 40, 77);
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 46);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 0, 0);
            btnHoaDon.Size = new Size(180, 30);
            btnHoaDon.TabIndex = 0;
            btnHoaDon.Text = "        Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnPhieu
            // 
            btnPhieu.BackColor = Color.FromArgb(36, 40, 77);
            btnPhieu.FlatAppearance.BorderSize = 0;
            btnPhieu.FlatStyle = FlatStyle.Flat;
            btnPhieu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPhieu.ForeColor = Color.White;
            btnPhieu.Image = (Image)resources.GetObject("btnPhieu.Image");
            btnPhieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieu.Location = new Point(0, 0);
            btnPhieu.Name = "btnPhieu";
            btnPhieu.Padding = new Padding(10, 0, 0, 0);
            btnPhieu.Size = new Size(180, 30);
            btnPhieu.TabIndex = 0;
            btnPhieu.Text = "        Phiếu";
            btnPhieu.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieu.UseVisualStyleBackColor = false;
            btnPhieu.Click += btnPhieu_Click;
            // 
            // pnMenuMini
            // 
            pnMenuMini.Controls.Add(btnDoanhThu);
            pnMenuMini.Controls.Add(btnChiTieu);
            pnMenuMini.Controls.Add(btnThongKe);
            pnMenuMini.Location = new Point(3, 465);
            pnMenuMini.Name = "pnMenuMini";
            pnMenuMini.Size = new Size(180, 40);
            pnMenuMini.TabIndex = 4;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.BackColor = Color.FromArgb(36, 40, 77);
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatStyle = FlatStyle.Flat;
            btnDoanhThu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoanhThu.ForeColor = Color.White;
            btnDoanhThu.Image = (Image)resources.GetObject("btnDoanhThu.Image");
            btnDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoanhThu.Location = new Point(0, 87);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Padding = new Padding(10, 0, 0, 0);
            btnDoanhThu.Size = new Size(180, 30);
            btnDoanhThu.TabIndex = 0;
            btnDoanhThu.Text = "        Doanh thu";
            btnDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btnDoanhThu.UseVisualStyleBackColor = false;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // btnChiTieu
            // 
            btnChiTieu.BackColor = Color.FromArgb(36, 40, 77);
            btnChiTieu.FlatAppearance.BorderSize = 0;
            btnChiTieu.FlatStyle = FlatStyle.Flat;
            btnChiTieu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChiTieu.ForeColor = Color.White;
            btnChiTieu.Image = (Image)resources.GetObject("btnChiTieu.Image");
            btnChiTieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnChiTieu.Location = new Point(0, 44);
            btnChiTieu.Name = "btnChiTieu";
            btnChiTieu.Padding = new Padding(10, 0, 0, 0);
            btnChiTieu.Size = new Size(180, 30);
            btnChiTieu.TabIndex = 0;
            btnChiTieu.Text = "        Chi tiêu";
            btnChiTieu.TextAlign = ContentAlignment.MiddleLeft;
            btnChiTieu.UseVisualStyleBackColor = false;
            btnChiTieu.Click += btnChiTieu_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(36, 40, 77);
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.White;
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
            // pnDangxuat
            // 
            pnDangxuat.Controls.Add(btnDangXuat);
            pnDangxuat.Location = new Point(3, 511);
            pnDangxuat.Name = "pnDangxuat";
            pnDangxuat.Size = new Size(180, 40);
            pnDangxuat.TabIndex = 4;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(36, 40, 77);
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 0);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(10, 0, 0, 0);
            btnDangXuat.Size = new Size(180, 30);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "        Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
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
            tableLayoutPanel2.BackColor = Color.FromArgb(36, 40, 77);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(imgMenu, 0, 0);
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
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 0);
            label2.Size = new Size(246, 30);
            label2.TabIndex = 6;
            label2.Text = "Vật liệu xây dựng Đông Anh";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // phieuTransition
            // 
            phieuTransition.Interval = 10;
            phieuTransition.Tick += phieuTransition_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 160, 160);
            ClientSize = new Size(1000, 700);
            Controls.Add(pnSidebar);
            Controls.Add(pnMenu);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMenu).EndInit();
            pnSidebar.ResumeLayout(false);
            pnNguoiDung.ResumeLayout(false);
            pnNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnTrangChu.ResumeLayout(false);
            pnNhanvien.ResumeLayout(false);
            pnDanhMucSanpham.ResumeLayout(false);
            pnKhachhang.ResumeLayout(false);
            pnNhacungcap.ResumeLayout(false);
            pnPhieu.ResumeLayout(false);
            pnMenuMini.ResumeLayout(false);
            pnDangxuat.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel pnSidebar;
        private Panel pnTrangChu;
        private Button btnTrangChu;
        private Panel pnNhanvien;
        private Button btnNhanVien;
        private Panel pnDanhMucSanpham;
        private Button btnDanhMucSP;
        private Panel pnKhachhang;
        private Button btnKhachHang;
        private Panel pnNhacungcap;
        private Button btnNhaCungCap;
        private Panel pnPhieu;
        private Button btnPhieu;
        private Panel pnMenuMini;
        private Button btnThongKe;
        private Panel pnDangxuat;
        private Button btnDangXuat;
        private PictureBox imgMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox btnClose;
        private PictureBox btnMinSize;
        private Button btnDoanhThu;
        private Button btnChiTieu;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel pnMenu;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Panel pnNguoiDung;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label lblTenND;
        private Button btnDanhMuc;
        private Button btnSanPham;
        private Button btnHoaDon;
        private Button btnPhieuNhap;
        private Button btnPhieuXuat;
        private System.Windows.Forms.Timer phieuTransition;
    }
}