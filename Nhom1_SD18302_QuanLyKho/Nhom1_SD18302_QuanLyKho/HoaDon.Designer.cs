namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            pictureBox1 = new PictureBox();
            cboLoc = new ComboBox();
            label1 = new Label();
            dgvHoaDon = new DataGridView();
            lblMaHoaDon = new Label();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblHang = new Label();
            cboHang = new ComboBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblNgayBan = new Label();
            lblNgayGiao = new Label();
            lblTienCoc = new Label();
            txtTienCoc = new TextBox();
            txtThanhTien = new TextBox();
            lblThanhTien = new Label();
            txtTim = new TextBox();
            pictureBox2 = new PictureBox();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            btn_inPN = new Button();
            btn_lammoiPX = new Button();
            btn_xoaPX = new Button();
            btn_capnhatPX = new Button();
            btn_themPX = new Button();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            cboMaHD = new ComboBox();
            dtpNgayBan = new DateTimePicker();
            dtpNgayGiao = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cboLoc
            // 
            cboLoc.FormattingEnabled = true;
            cboLoc.Items.AddRange(new object[] { "A - Z", "Z - A" });
            cboLoc.Location = new Point(12, 77);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(151, 28);
            cboLoc.TabIndex = 1;
            cboLoc.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(356, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 2;
            label1.Text = "HÓA ĐƠN";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(11, 111);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(796, 321);
            dgvHoaDon.TabIndex = 3;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHoaDon.ForeColor = Color.White;
            lblMaHoaDon.Location = new Point(27, 442);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(108, 23);
            lblMaHoaDon.TabIndex = 4;
            lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKhachHang.ForeColor = Color.White;
            lblKhachHang.Location = new Point(28, 475);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(105, 23);
            lblKhachHang.TabIndex = 6;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(150, 470);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(250, 28);
            cboKhachHang.TabIndex = 7;
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHang.ForeColor = Color.White;
            lblHang.Location = new Point(28, 509);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(56, 23);
            lblHang.TabIndex = 8;
            lblHang.Text = "Hàng:";
            // 
            // cboHang
            // 
            cboHang.FormattingEnabled = true;
            cboHang.Location = new Point(150, 504);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(250, 28);
            cboHang.TabIndex = 9;
            cboHang.SelectedIndexChanged += cboHang_SelectedIndexChanged;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoLuong.ForeColor = Color.White;
            lblSoLuong.Location = new Point(28, 576);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(83, 23);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(150, 572);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(250, 27);
            txtSoLuong.TabIndex = 11;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonGia.ForeColor = Color.White;
            lblDonGia.Location = new Point(441, 509);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(74, 23);
            lblDonGia.TabIndex = 12;
            lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Enabled = false;
            txtDonGia.Location = new Point(538, 503);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(250, 27);
            txtDonGia.TabIndex = 13;
            // 
            // lblNgayBan
            // 
            lblNgayBan.AutoSize = true;
            lblNgayBan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayBan.ForeColor = Color.White;
            lblNgayBan.Location = new Point(439, 443);
            lblNgayBan.Name = "lblNgayBan";
            lblNgayBan.Size = new Size(89, 23);
            lblNgayBan.TabIndex = 17;
            lblNgayBan.Text = "Ngày bán:";
            // 
            // lblNgayGiao
            // 
            lblNgayGiao.AutoSize = true;
            lblNgayGiao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayGiao.ForeColor = Color.White;
            lblNgayGiao.Location = new Point(439, 474);
            lblNgayGiao.Name = "lblNgayGiao";
            lblNgayGiao.Size = new Size(93, 23);
            lblNgayGiao.TabIndex = 18;
            lblNgayGiao.Text = "Ngày giao:";
            // 
            // lblTienCoc
            // 
            lblTienCoc.AutoSize = true;
            lblTienCoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienCoc.ForeColor = Color.White;
            lblTienCoc.Location = new Point(438, 542);
            lblTienCoc.Name = "lblTienCoc";
            lblTienCoc.Size = new Size(77, 23);
            lblTienCoc.TabIndex = 19;
            lblTienCoc.Text = "Tiền cọc:";
            // 
            // txtTienCoc
            // 
            txtTienCoc.Location = new Point(538, 538);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.Size = new Size(250, 27);
            txtTienCoc.TabIndex = 20;
            txtTienCoc.Text = "0";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(537, 573);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(251, 27);
            txtThanhTien.TabIndex = 21;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.DarkRed;
            lblThanhTien.Location = new Point(438, 577);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(96, 23);
            lblThanhTien.TabIndex = 22;
            lblThanhTien.Text = "Thành tiền:";
            lblThanhTien.Click += lblThanhTien_Click;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(237, 76);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(310, 27);
            txtTim.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(553, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(139, 189, 188);
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(452, 605);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(100, 45);
            btnXuatExcel.TabIndex = 80;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.BackColor = Color.FromArgb(139, 189, 188);
            btnNhapExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapExcel.ForeColor = Color.White;
            btnNhapExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapExcel.Location = new Point(346, 605);
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(100, 45);
            btnNhapExcel.TabIndex = 81;
            btnNhapExcel.Text = "Nhập Excel";
            btnNhapExcel.UseVisualStyleBackColor = false;
            // 
            // btn_inPN
            // 
            btn_inPN.BackColor = Color.FromArgb(134, 179, 209);
            btn_inPN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inPN.ForeColor = Color.White;
            btn_inPN.Image = (Image)resources.GetObject("btn_inPN.Image");
            btn_inPN.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inPN.Location = new Point(25, 605);
            btn_inPN.Name = "btn_inPN";
            btn_inPN.Padding = new Padding(5, 0, 5, 0);
            btn_inPN.Size = new Size(100, 45);
            btn_inPN.TabIndex = 79;
            btn_inPN.Text = "In";
            btn_inPN.UseVisualStyleBackColor = false;
            // 
            // btn_lammoiPX
            // 
            btn_lammoiPX.BackColor = Color.FromArgb(134, 179, 209);
            btn_lammoiPX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_lammoiPX.ForeColor = Color.White;
            btn_lammoiPX.Image = (Image)resources.GetObject("btn_lammoiPX.Image");
            btn_lammoiPX.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoiPX.Location = new Point(593, 603);
            btn_lammoiPX.Name = "btn_lammoiPX";
            btn_lammoiPX.Size = new Size(100, 45);
            btn_lammoiPX.TabIndex = 75;
            btn_lammoiPX.Text = "Làm mới";
            btn_lammoiPX.TextAlign = ContentAlignment.MiddleRight;
            btn_lammoiPX.UseVisualStyleBackColor = false;
            // 
            // btn_xoaPX
            // 
            btn_xoaPX.BackColor = Color.FromArgb(132, 77, 54);
            btn_xoaPX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoaPX.ForeColor = Color.White;
            btn_xoaPX.Image = (Image)resources.GetObject("btn_xoaPX.Image");
            btn_xoaPX.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoaPX.Location = new Point(699, 603);
            btn_xoaPX.Name = "btn_xoaPX";
            btn_xoaPX.Padding = new Padding(5, 0, 5, 0);
            btn_xoaPX.Size = new Size(100, 45);
            btn_xoaPX.TabIndex = 76;
            btn_xoaPX.Text = "Xóa";
            btn_xoaPX.TextAlign = ContentAlignment.MiddleRight;
            btn_xoaPX.UseVisualStyleBackColor = false;
            btn_xoaPX.Click += btn_xoaPX_Click;
            // 
            // btn_capnhatPX
            // 
            btn_capnhatPX.BackColor = Color.FromArgb(134, 179, 209);
            btn_capnhatPX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_capnhatPX.ForeColor = Color.White;
            btn_capnhatPX.Image = (Image)resources.GetObject("btn_capnhatPX.Image");
            btn_capnhatPX.ImageAlign = ContentAlignment.MiddleLeft;
            btn_capnhatPX.Location = new Point(237, 605);
            btn_capnhatPX.Name = "btn_capnhatPX";
            btn_capnhatPX.Size = new Size(100, 45);
            btn_capnhatPX.TabIndex = 77;
            btn_capnhatPX.Text = "Cập nhập";
            btn_capnhatPX.TextAlign = ContentAlignment.MiddleRight;
            btn_capnhatPX.UseVisualStyleBackColor = false;
            btn_capnhatPX.Click += btn_capnhatPX_Click;
            // 
            // btn_themPX
            // 
            btn_themPX.BackColor = Color.FromArgb(134, 179, 209);
            btn_themPX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_themPX.ForeColor = Color.White;
            btn_themPX.Image = (Image)resources.GetObject("btn_themPX.Image");
            btn_themPX.ImageAlign = ContentAlignment.MiddleLeft;
            btn_themPX.Location = new Point(131, 605);
            btn_themPX.Name = "btn_themPX";
            btn_themPX.Padding = new Padding(5, 0, 5, 0);
            btn_themPX.Size = new Size(100, 45);
            btn_themPX.TabIndex = 78;
            btn_themPX.Text = "Thêm";
            btn_themPX.TextAlign = ContentAlignment.MiddleRight;
            btn_themPX.UseVisualStyleBackColor = false;
            btn_themPX.Click += btn_themPX_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 542);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 8;
            label2.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(150, 537);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 28);
            cboNhanVien.TabIndex = 9;
            cboNhanVien.SelectedIndexChanged += cboHang_SelectedIndexChanged;
            // 
            // cboMaHD
            // 
            cboMaHD.FormattingEnabled = true;
            cboMaHD.Location = new Point(150, 436);
            cboMaHD.Name = "cboMaHD";
            cboMaHD.Size = new Size(250, 28);
            cboMaHD.TabIndex = 7;
            cboMaHD.Click += cboMaHD_Click;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            dtpNgayBan.Format = DateTimePickerFormat.Custom;
            dtpNgayBan.Location = new Point(538, 436);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(250, 27);
            dtpNgayBan.TabIndex = 83;
            dtpNgayBan.Value = new DateTime(2023, 11, 24, 0, 0, 0, 0);
            // 
            // dtpNgayGiao
            // 
            dtpNgayGiao.CustomFormat = "dd/MM/yyyy";
            dtpNgayGiao.Format = DateTimePickerFormat.Custom;
            dtpNgayGiao.Location = new Point(538, 470);
            dtpNgayGiao.Name = "dtpNgayGiao";
            dtpNgayGiao.Size = new Size(250, 27);
            dtpNgayGiao.TabIndex = 83;
            dtpNgayGiao.Value = new DateTime(2023, 11, 24, 0, 0, 0, 0);
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(820, 660);
            Controls.Add(dtpNgayGiao);
            Controls.Add(dtpNgayBan);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnNhapExcel);
            Controls.Add(btn_inPN);
            Controls.Add(btn_lammoiPX);
            Controls.Add(btn_xoaPX);
            Controls.Add(btn_capnhatPX);
            Controls.Add(btn_themPX);
            Controls.Add(pictureBox2);
            Controls.Add(txtTim);
            Controls.Add(lblThanhTien);
            Controls.Add(txtThanhTien);
            Controls.Add(txtTienCoc);
            Controls.Add(lblTienCoc);
            Controls.Add(lblNgayGiao);
            Controls.Add(lblNgayBan);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(cboNhanVien);
            Controls.Add(label2);
            Controls.Add(cboHang);
            Controls.Add(lblHang);
            Controls.Add(cboMaHD);
            Controls.Add(cboKhachHang);
            Controls.Add(lblKhachHang);
            Controls.Add(lblMaHoaDon);
            Controls.Add(dgvHoaDon);
            Controls.Add(label1);
            Controls.Add(cboLoc);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaDon";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cboLoc;
        private Label label1;
        private DataGridView dgvHoaDon;
        private Label lblMaHoaDon;
        private Label lblKhachHang;
        private ComboBox cboKhachHang;
        private Label lblHang;
        private ComboBox cboHang;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblNgayBan;
        private Label lblNgayGiao;
        private Label lblTienCoc;
        private TextBox txtTienCoc;
        private TextBox txtThanhTien;
        private Label lblThanhTien;
        private TextBox txtTim;
        private PictureBox pictureBox2;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private Button btn_inPN;
        private Button btn_lammoiPX;
        private Button btn_xoaPX;
        private Button btn_capnhatPX;
        private Button btn_themPX;
        private Label label2;
        private ComboBox cboNhanVien;
        private ComboBox cboMaHD;
        private DateTimePicker dtpNgayBan;
        private DateTimePicker dtpNgayGiao;
    }
}