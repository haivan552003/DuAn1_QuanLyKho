namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            btn_inHH = new Button();
            btn_lammoiHH = new Button();
            btn_xoaHH = new Button();
            btn_capnhatHH = new Button();
            btn_themHH = new Button();
            ptb_timHH = new PictureBox();
            txt_timHH = new TextBox();
            lblThanhTien = new Label();
            txt_anh = new TextBox();
            lblTienCoc = new Label();
            lblNgayGiao = new Label();
            lblNgayBan = new Label();
            dtp_hanSuDung = new DateTimePicker();
            lblSoLuong = new Label();
            cbo_DonGia = new ComboBox();
            lblHang = new Label();
            cboTenHang = new ComboBox();
            lblKhachHang = new Label();
            txtMaHang = new TextBox();
            lblMaHoaDon = new Label();
            dgvHoaDon = new DataGridView();
            label1 = new Label();
            cbo_locHH = new ComboBox();
            pictureBox1 = new PictureBox();
            ptb_anhHH = new PictureBox();
            btn_anh = new Button();
            txt_ghichu = new TextBox();
            label2 = new Label();
            cbo_maKho = new ComboBox();
            cbo_maDanhMuc = new ComboBox();
            cbo_maNguoiDung = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ptb_timHH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_anhHH).BeginInit();
            SuspendLayout();
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(139, 189, 188);
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(453, 606);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(100, 45);
            btnXuatExcel.TabIndex = 111;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.BackColor = Color.FromArgb(139, 189, 188);
            btnNhapExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapExcel.ForeColor = Color.White;
            btnNhapExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapExcel.Location = new Point(347, 606);
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(100, 45);
            btnNhapExcel.TabIndex = 112;
            btnNhapExcel.Text = "Nhập Excel";
            btnNhapExcel.UseVisualStyleBackColor = false;
            // 
            // btn_inHH
            // 
            btn_inHH.BackColor = Color.FromArgb(134, 179, 209);
            btn_inHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inHH.ForeColor = Color.White;
            btn_inHH.Image = (Image)resources.GetObject("btn_inHH.Image");
            btn_inHH.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inHH.Location = new Point(26, 606);
            btn_inHH.Name = "btn_inHH";
            btn_inHH.Padding = new Padding(5, 0, 5, 0);
            btn_inHH.Size = new Size(100, 45);
            btn_inHH.TabIndex = 110;
            btn_inHH.Text = "In";
            btn_inHH.UseVisualStyleBackColor = false;
            // 
            // btn_lammoiHH
            // 
            btn_lammoiHH.BackColor = Color.FromArgb(134, 179, 209);
            btn_lammoiHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_lammoiHH.ForeColor = Color.White;
            btn_lammoiHH.Image = (Image)resources.GetObject("btn_lammoiHH.Image");
            btn_lammoiHH.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoiHH.Location = new Point(594, 604);
            btn_lammoiHH.Name = "btn_lammoiHH";
            btn_lammoiHH.Size = new Size(100, 45);
            btn_lammoiHH.TabIndex = 106;
            btn_lammoiHH.Text = "Làm mới";
            btn_lammoiHH.TextAlign = ContentAlignment.MiddleRight;
            btn_lammoiHH.UseVisualStyleBackColor = false;
            btn_lammoiHH.Click += btn_lammoiHH_Click;
            // 
            // btn_xoaHH
            // 
            btn_xoaHH.BackColor = Color.FromArgb(132, 77, 54);
            btn_xoaHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoaHH.ForeColor = Color.White;
            btn_xoaHH.Image = (Image)resources.GetObject("btn_xoaHH.Image");
            btn_xoaHH.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoaHH.Location = new Point(700, 604);
            btn_xoaHH.Name = "btn_xoaHH";
            btn_xoaHH.Padding = new Padding(5, 0, 5, 0);
            btn_xoaHH.Size = new Size(100, 45);
            btn_xoaHH.TabIndex = 107;
            btn_xoaHH.Text = "Xóa";
            btn_xoaHH.TextAlign = ContentAlignment.MiddleRight;
            btn_xoaHH.UseVisualStyleBackColor = false;
            btn_xoaHH.Click += btn_xoaHH_Click;
            // 
            // btn_capnhatHH
            // 
            btn_capnhatHH.BackColor = Color.FromArgb(134, 179, 209);
            btn_capnhatHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_capnhatHH.ForeColor = Color.White;
            btn_capnhatHH.Image = (Image)resources.GetObject("btn_capnhatHH.Image");
            btn_capnhatHH.ImageAlign = ContentAlignment.MiddleLeft;
            btn_capnhatHH.Location = new Point(238, 606);
            btn_capnhatHH.Name = "btn_capnhatHH";
            btn_capnhatHH.Size = new Size(100, 45);
            btn_capnhatHH.TabIndex = 108;
            btn_capnhatHH.Text = "Cập nhập";
            btn_capnhatHH.TextAlign = ContentAlignment.MiddleRight;
            btn_capnhatHH.UseVisualStyleBackColor = false;
            btn_capnhatHH.Click += btn_capnhatHH_Click;
            // 
            // btn_themHH
            // 
            btn_themHH.BackColor = Color.FromArgb(134, 179, 209);
            btn_themHH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_themHH.ForeColor = Color.White;
            btn_themHH.Image = (Image)resources.GetObject("btn_themHH.Image");
            btn_themHH.ImageAlign = ContentAlignment.MiddleLeft;
            btn_themHH.Location = new Point(132, 606);
            btn_themHH.Name = "btn_themHH";
            btn_themHH.Padding = new Padding(5, 0, 5, 0);
            btn_themHH.Size = new Size(100, 45);
            btn_themHH.TabIndex = 109;
            btn_themHH.Text = "Thêm";
            btn_themHH.TextAlign = ContentAlignment.MiddleRight;
            btn_themHH.UseVisualStyleBackColor = false;
            btn_themHH.Click += btn_themPX_Click;
            // 
            // ptb_timHH
            // 
            ptb_timHH.Image = (Image)resources.GetObject("ptb_timHH.Image");
            ptb_timHH.Location = new Point(565, 76);
            ptb_timHH.Name = "ptb_timHH";
            ptb_timHH.Size = new Size(30, 30);
            ptb_timHH.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_timHH.TabIndex = 105;
            ptb_timHH.TabStop = false;
            ptb_timHH.Click += ptb_timHH_Click;
            // 
            // txt_timHH
            // 
            txt_timHH.Location = new Point(249, 77);
            txt_timHH.Name = "txt_timHH";
            txt_timHH.Size = new Size(310, 27);
            txt_timHH.TabIndex = 104;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.White;
            lblThanhTien.Location = new Point(333, 522);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(134, 23);
            lblThanhTien.TabIndex = 103;
            lblThanhTien.Text = "Mã người dùng:";
            // 
            // txt_anh
            // 
            txt_anh.Location = new Point(464, 483);
            txt_anh.Name = "txt_anh";
            txt_anh.Size = new Size(152, 27);
            txt_anh.TabIndex = 101;
            // 
            // lblTienCoc
            // 
            lblTienCoc.AutoSize = true;
            lblTienCoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienCoc.ForeColor = Color.White;
            lblTienCoc.Location = new Point(333, 487);
            lblTienCoc.Name = "lblTienCoc";
            lblTienCoc.Size = new Size(45, 23);
            lblTienCoc.TabIndex = 100;
            lblTienCoc.Text = "Ảnh:";
            // 
            // lblNgayGiao
            // 
            lblNgayGiao.AutoSize = true;
            lblNgayGiao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayGiao.ForeColor = Color.White;
            lblNgayGiao.Location = new Point(333, 454);
            lblNgayGiao.Name = "lblNgayGiao";
            lblNgayGiao.Size = new Size(73, 23);
            lblNgayGiao.TabIndex = 99;
            lblNgayGiao.Text = "Ghi chú:";
            // 
            // lblNgayBan
            // 
            lblNgayBan.AutoSize = true;
            lblNgayBan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayBan.ForeColor = Color.White;
            lblNgayBan.Location = new Point(333, 423);
            lblNgayBan.Name = "lblNgayBan";
            lblNgayBan.Size = new Size(114, 23);
            lblNgayBan.TabIndex = 98;
            lblNgayBan.Text = "Hạn sử dụng:";
            // 
            // dtp_hanSuDung
            // 
            dtp_hanSuDung.CustomFormat = "MM/dd/yyyy";
            dtp_hanSuDung.Format = DateTimePickerFormat.Custom;
            dtp_hanSuDung.Location = new Point(463, 419);
            dtp_hanSuDung.MinDate = new DateTime(2023, 11, 23, 0, 0, 0, 0);
            dtp_hanSuDung.Name = "dtp_hanSuDung";
            dtp_hanSuDung.Size = new Size(198, 27);
            dtp_hanSuDung.TabIndex = 97;
            dtp_hanSuDung.Value = new DateTime(2023, 11, 23, 17, 47, 49, 0);
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoLuong.ForeColor = Color.White;
            lblSoLuong.Location = new Point(10, 522);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(121, 23);
            lblSoLuong.TabIndex = 92;
            lblSoLuong.Text = "Mã danh mục:";
            // 
            // cbo_DonGia
            // 
            cbo_DonGia.FormattingEnabled = true;
            cbo_DonGia.Location = new Point(132, 484);
            cbo_DonGia.Name = "cbo_DonGia";
            cbo_DonGia.Size = new Size(195, 28);
            cbo_DonGia.TabIndex = 91;
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHang.ForeColor = Color.White;
            lblHang.Location = new Point(10, 489);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(74, 23);
            lblHang.TabIndex = 90;
            lblHang.Text = "Đơn giá:";
            // 
            // cboTenHang
            // 
            cboTenHang.FormattingEnabled = true;
            cboTenHang.Location = new Point(132, 450);
            cboTenHang.Name = "cboTenHang";
            cboTenHang.Size = new Size(195, 28);
            cboTenHang.TabIndex = 89;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKhachHang.ForeColor = Color.White;
            lblKhachHang.Location = new Point(10, 455);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(84, 23);
            lblKhachHang.TabIndex = 88;
            lblKhachHang.Text = "Tên hàng:";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(132, 418);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(195, 27);
            txtMaHang.TabIndex = 87;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHoaDon.ForeColor = Color.White;
            lblMaHoaDon.Location = new Point(9, 422);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(83, 23);
            lblMaHoaDon.TabIndex = 86;
            lblMaHoaDon.Text = "Mã hàng:";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(12, 112);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(796, 286);
            dgvHoaDon.TabIndex = 85;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 10);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 84;
            label1.Text = "HÀNG HÓA";
            // 
            // cbo_locHH
            // 
            cbo_locHH.FormattingEnabled = true;
            cbo_locHH.Items.AddRange(new object[] { "A-Z", "Z-a" });
            cbo_locHH.Location = new Point(13, 78);
            cbo_locHH.Name = "cbo_locHH";
            cbo_locHH.Size = new Size(151, 28);
            cbo_locHH.TabIndex = 83;
            cbo_locHH.SelectedIndexChanged += cbo_locHH_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // ptb_anhHH
            // 
            ptb_anhHH.Image = (Image)resources.GetObject("ptb_anhHH.Image");
            ptb_anhHH.Location = new Point(668, 419);
            ptb_anhHH.Name = "ptb_anhHH";
            ptb_anhHH.Size = new Size(140, 160);
            ptb_anhHH.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_anhHH.TabIndex = 113;
            ptb_anhHH.TabStop = false;
            // 
            // btn_anh
            // 
            btn_anh.BackColor = Color.FromArgb(36, 40, 77);
            btn_anh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_anh.ForeColor = Color.FromArgb(36, 40, 77);
            btn_anh.Image = (Image)resources.GetObject("btn_anh.Image");
            btn_anh.Location = new Point(622, 483);
            btn_anh.Name = "btn_anh";
            btn_anh.Size = new Size(38, 30);
            btn_anh.TabIndex = 106;
            btn_anh.TextAlign = ContentAlignment.MiddleRight;
            btn_anh.UseVisualStyleBackColor = false;
            btn_anh.Click += button1_Click;
            // 
            // txt_ghichu
            // 
            txt_ghichu.Location = new Point(464, 449);
            txt_ghichu.Name = "txt_ghichu";
            txt_ghichu.Size = new Size(198, 27);
            txt_ghichu.TabIndex = 114;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 556);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 115;
            label2.Text = "Mã kho:";
            // 
            // cbo_maKho
            // 
            cbo_maKho.FormattingEnabled = true;
            cbo_maKho.Location = new Point(132, 551);
            cbo_maKho.Name = "cbo_maKho";
            cbo_maKho.Size = new Size(195, 28);
            cbo_maKho.TabIndex = 116;
            // 
            // cbo_maDanhMuc
            // 
            cbo_maDanhMuc.FormattingEnabled = true;
            cbo_maDanhMuc.Location = new Point(132, 517);
            cbo_maDanhMuc.Name = "cbo_maDanhMuc";
            cbo_maDanhMuc.Size = new Size(195, 28);
            cbo_maDanhMuc.TabIndex = 117;
            // 
            // cbo_maNguoiDung
            // 
            cbo_maNguoiDung.FormattingEnabled = true;
            cbo_maNguoiDung.Location = new Point(463, 517);
            cbo_maNguoiDung.Name = "cbo_maNguoiDung";
            cbo_maNguoiDung.Size = new Size(198, 28);
            cbo_maNguoiDung.TabIndex = 118;
            // 
            // frmHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(820, 660);
            Controls.Add(cbo_maNguoiDung);
            Controls.Add(cbo_maDanhMuc);
            Controls.Add(cbo_maKho);
            Controls.Add(label2);
            Controls.Add(txt_ghichu);
            Controls.Add(ptb_anhHH);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnNhapExcel);
            Controls.Add(btn_inHH);
            Controls.Add(btn_anh);
            Controls.Add(btn_lammoiHH);
            Controls.Add(btn_xoaHH);
            Controls.Add(btn_capnhatHH);
            Controls.Add(btn_themHH);
            Controls.Add(ptb_timHH);
            Controls.Add(txt_timHH);
            Controls.Add(lblThanhTien);
            Controls.Add(txt_anh);
            Controls.Add(lblTienCoc);
            Controls.Add(lblNgayGiao);
            Controls.Add(lblNgayBan);
            Controls.Add(dtp_hanSuDung);
            Controls.Add(lblSoLuong);
            Controls.Add(cbo_DonGia);
            Controls.Add(lblHang);
            Controls.Add(cboTenHang);
            Controls.Add(lblKhachHang);
            Controls.Add(txtMaHang);
            Controls.Add(lblMaHoaDon);
            Controls.Add(dgvHoaDon);
            Controls.Add(label1);
            Controls.Add(cbo_locHH);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHangHoa";
            Text = "Hàng Hóa";
            ((System.ComponentModel.ISupportInitialize)ptb_timHH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_anhHH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private Button btn_inHH;
        private Button btn_lammoiHH;
        private Button btn_xoaHH;
        private Button btn_capnhatHH;
        private Button btn_themHH;
        private PictureBox ptb_timHH;
        private TextBox txt_timHH;
        private Label lblThanhTien;
        private TextBox txt_anh;
        private Label lblTienCoc;
        private Label lblNgayGiao;
        private Label lblNgayBan;
        private DateTimePicker dtp_hanSuDung;
        private Label lblSoLuong;
        private ComboBox cbo_DonGia;
        private Label lblHang;
        private ComboBox cboTenHang;
        private Label lblKhachHang;
        private TextBox txtMaHang;
        private Label lblMaHoaDon;
        private DataGridView dgvHoaDon;
        private Label label1;
        private ComboBox cbo_locHH;
        private PictureBox pictureBox1;
        private PictureBox ptb_anhHH;
        private Button btn_anh;
        private TextBox txt_ghichu;
        private Label label2;
        private ComboBox cbo_maKho;
        private ComboBox cbo_maDanhMuc;
        private ComboBox cbo_maNguoiDung;
    }
}