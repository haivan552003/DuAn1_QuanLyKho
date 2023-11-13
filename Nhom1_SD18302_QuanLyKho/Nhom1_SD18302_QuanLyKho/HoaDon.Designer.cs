namespace Nhom1_SD18302_QuanLyKho
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dgvHoaDon = new DataGridView();
            lblMaHoaDon = new Label();
            txtMaHoaDon = new TextBox();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblHang = new Label();
            cboHang = new ComboBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            dtpNgayGiao = new DateTimePicker();
            dtpNgayBan = new DateTimePicker();
            lblNgayBan = new Label();
            lblNgayGiao = new Label();
            lblTienCoc = new Label();
            txtTienCoc = new TextBox();
            txtThanhTien = new TextBox();
            lblThanhTien = new Label();
            btnIn = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            textBox6 = new TextBox();
            pictureBox2 = new PictureBox();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(333, 27);
            label1.Name = "label1";
            label1.Size = new Size(135, 35);
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
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHoaDon.ForeColor = Color.White;
            lblMaHoaDon.Location = new Point(11, 442);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(108, 23);
            lblMaHoaDon.TabIndex = 4;
            lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(134, 438);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(250, 27);
            txtMaHoaDon.TabIndex = 5;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKhachHang.ForeColor = Color.White;
            lblKhachHang.Location = new Point(12, 475);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(105, 23);
            lblKhachHang.TabIndex = 6;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(134, 470);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(250, 28);
            cboKhachHang.TabIndex = 7;
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHang.ForeColor = Color.White;
            lblHang.Location = new Point(12, 509);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(56, 23);
            lblHang.TabIndex = 8;
            lblHang.Text = "Hàng:";
            // 
            // cboHang
            // 
            cboHang.FormattingEnabled = true;
            cboHang.Location = new Point(134, 504);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(250, 28);
            cboHang.TabIndex = 9;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoLuong.ForeColor = Color.White;
            lblSoLuong.Location = new Point(12, 542);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(83, 23);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(134, 538);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(250, 27);
            txtSoLuong.TabIndex = 11;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonGia.ForeColor = Color.White;
            lblDonGia.Location = new Point(12, 575);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(74, 23);
            lblDonGia.TabIndex = 12;
            lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(134, 571);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(250, 27);
            txtDonGia.TabIndex = 13;
            // 
            // dtpNgayGiao
            // 
            dtpNgayGiao.Location = new Point(557, 470);
            dtpNgayGiao.Name = "dtpNgayGiao";
            dtpNgayGiao.Size = new Size(250, 27);
            dtpNgayGiao.TabIndex = 15;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Location = new Point(557, 439);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(250, 27);
            dtpNgayBan.TabIndex = 16;
            // 
            // lblNgayBan
            // 
            lblNgayBan.AutoSize = true;
            lblNgayBan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayBan.ForeColor = Color.White;
            lblNgayBan.Location = new Point(458, 443);
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
            lblNgayGiao.Location = new Point(458, 474);
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
            lblTienCoc.Location = new Point(458, 507);
            lblTienCoc.Name = "lblTienCoc";
            lblTienCoc.Size = new Size(77, 23);
            lblTienCoc.TabIndex = 19;
            lblTienCoc.Text = "Tiền cọc:";
            // 
            // txtTienCoc
            // 
            txtTienCoc.Location = new Point(558, 503);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.Size = new Size(250, 27);
            txtTienCoc.TabIndex = 20;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(557, 538);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(251, 27);
            txtThanhTien.TabIndex = 21;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.White;
            lblThanhTien.Location = new Point(458, 542);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(96, 23);
            lblThanhTien.TabIndex = 22;
            lblThanhTien.Text = "Thành tiền:";
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnIn.Image = (Image)resources.GetObject("btnIn.Image");
            btnIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnIn.Location = new Point(11, 610);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(75, 38);
            btnIn.TabIndex = 23;
            btnIn.Text = "In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(733, 610);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 38);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(92, 610);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 38);
            btnThem.TabIndex = 25;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Black;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(192, 610);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(111, 38);
            btnSua.TabIndex = 26;
            btnSua.Text = "Cập nhật";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(621, 610);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 38);
            btnLamMoi.TabIndex = 27;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(241, 77);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(310, 27);
            textBox6.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(567, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 160, 160);
            ClientSize = new Size(820, 660);
            Controls.Add(pictureBox2);
            Controls.Add(textBox6);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnIn);
            Controls.Add(lblThanhTien);
            Controls.Add(txtThanhTien);
            Controls.Add(txtTienCoc);
            Controls.Add(lblTienCoc);
            Controls.Add(lblNgayGiao);
            Controls.Add(lblNgayBan);
            Controls.Add(dtpNgayBan);
            Controls.Add(dtpNgayGiao);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(cboHang);
            Controls.Add(lblHang);
            Controls.Add(cboKhachHang);
            Controls.Add(lblKhachHang);
            Controls.Add(txtMaHoaDon);
            Controls.Add(lblMaHoaDon);
            Controls.Add(dgvHoaDon);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dgvHoaDon;
        private Label lblMaHoaDon;
        private TextBox txtMaHoaDon;
        private Label lblKhachHang;
        private ComboBox cboKhachHang;
        private Label lblHang;
        private ComboBox cboHang;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private DateTimePicker dtpNgayGiao;
        private DateTimePicker dtpNgayBan;
        private Label lblNgayBan;
        private Label lblNgayGiao;
        private Label lblTienCoc;
        private TextBox txtTienCoc;
        private TextBox txtThanhTien;
        private Label lblThanhTien;
        private Button btnIn;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private TextBox textBox6;
        private PictureBox pictureBox2;
    }
}