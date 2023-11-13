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
            cboLoc = new ComboBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtTimKiem = new TextBox();
            dataGridView1 = new DataGridView();
            lblMaHoaDon = new Label();
            txtMaHoaDon = new TextBox();
            lblKhachHang = new Label();
            lblHang = new Label();
            txtHang = new TextBox();
            label2 = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblNgayBan = new Label();
            lblNgayGiao = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            txtTienCoc = new TextBox();
            txtThanhTien = new TextBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnLamMoi = new Button();
            btnIn = new Button();
            lblTienCoc = new Label();
            lblThanhTien = new Label();
            cboKhachHang = new ComboBox();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // cboLoc
            // 
            cboLoc.FormattingEnabled = true;
            cboLoc.Location = new Point(13, 78);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(150, 28);
            cboLoc.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 34);
            label1.Name = "label1";
            label1.Size = new Size(135, 35);
            label1.TabIndex = 5;
            label1.Text = "HÓA ĐƠN";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(170, 160, 160);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(588, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(272, 81);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(310, 27);
            txtTimKiem.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(796, 283);
            dataGridView1.TabIndex = 8;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHoaDon.ForeColor = Color.White;
            lblMaHoaDon.Location = new Point(13, 430);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(108, 23);
            lblMaHoaDon.TabIndex = 9;
            lblMaHoaDon.Text = "Mã hóa đơn:";
            lblMaHoaDon.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(141, 426);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(260, 27);
            txtMaHoaDon.TabIndex = 10;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKhachHang.ForeColor = Color.White;
            lblKhachHang.Location = new Point(13, 463);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(105, 23);
            lblKhachHang.TabIndex = 9;
            lblKhachHang.Text = "Khách hàng:";
            lblKhachHang.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHang.ForeColor = Color.White;
            lblHang.Location = new Point(13, 496);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(56, 23);
            lblHang.TabIndex = 9;
            lblHang.Text = "Hàng:";
            lblHang.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHang
            // 
            txtHang.Location = new Point(141, 492);
            txtHang.Name = "txtHang";
            txtHang.Size = new Size(260, 27);
            txtHang.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 529);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 9;
            label2.Text = "Số lượng:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(141, 525);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(260, 27);
            txtSoLuong.TabIndex = 10;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonGia.ForeColor = Color.White;
            lblDonGia.Location = new Point(13, 562);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(74, 23);
            lblDonGia.TabIndex = 9;
            lblDonGia.Text = "Đơn giá:";
            lblDonGia.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(141, 558);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(260, 27);
            txtDonGia.TabIndex = 10;
            // 
            // lblNgayBan
            // 
            lblNgayBan.AutoSize = true;
            lblNgayBan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayBan.ForeColor = Color.White;
            lblNgayBan.Location = new Point(446, 434);
            lblNgayBan.Name = "lblNgayBan";
            lblNgayBan.Size = new Size(89, 23);
            lblNgayBan.TabIndex = 9;
            lblNgayBan.Text = "Ngày bán:";
            lblNgayBan.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNgayGiao
            // 
            lblNgayGiao.AutoSize = true;
            lblNgayGiao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgayGiao.ForeColor = Color.White;
            lblNgayGiao.Location = new Point(446, 467);
            lblNgayGiao.Name = "lblNgayGiao";
            lblNgayGiao.Size = new Size(93, 23);
            lblNgayGiao.TabIndex = 9;
            lblNgayGiao.Text = "Ngày giao:";
            lblNgayGiao.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(558, 431);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(558, 464);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // txtTienCoc
            // 
            txtTienCoc.Location = new Point(558, 495);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.Size = new Size(250, 27);
            txtTienCoc.TabIndex = 12;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(558, 532);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(250, 27);
            txtThanhTien.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(134, 179, 209);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(93, 596);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 40);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(134, 179, 209);
            btnCapNhat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhat.Location = new Point(193, 596);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(111, 40);
            btnCapNhat.TabIndex = 14;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.TextAlign = ContentAlignment.MiddleRight;
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(134, 179, 209);
            btnLamMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(619, 596);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 40);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnIn
            // 
            btnIn.BackColor = Color.FromArgb(134, 179, 209);
            btnIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIn.ForeColor = Color.White;
            btnIn.Image = (Image)resources.GetObject("btnIn.Image");
            btnIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnIn.Location = new Point(13, 596);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(74, 40);
            btnIn.TabIndex = 14;
            btnIn.Text = "In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.UseVisualStyleBackColor = false;
            // 
            // lblTienCoc
            // 
            lblTienCoc.AutoSize = true;
            lblTienCoc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTienCoc.ForeColor = Color.White;
            lblTienCoc.Location = new Point(446, 499);
            lblTienCoc.Name = "lblTienCoc";
            lblTienCoc.Size = new Size(77, 23);
            lblTienCoc.TabIndex = 9;
            lblTienCoc.Text = "Tiền cọc:";
            lblTienCoc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.White;
            lblThanhTien.Location = new Point(446, 533);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(96, 23);
            lblThanhTien.TabIndex = 9;
            lblThanhTien.Text = "Thành tiền:";
            lblThanhTien.TextAlign = ContentAlignment.TopCenter;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(141, 458);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(260, 28);
            cboKhachHang.TabIndex = 15;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(132, 77, 54);
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(737, 596);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(71, 40);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 160, 160);
            ClientSize = new Size(820, 660);
            Controls.Add(cboKhachHang);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnCapNhat);
            Controls.Add(btnIn);
            Controls.Add(btnThem);
            Controls.Add(txtThanhTien);
            Controls.Add(txtTienCoc);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtHang);
            Controls.Add(txtMaHoaDon);
            Controls.Add(lblDonGia);
            Controls.Add(label2);
            Controls.Add(lblThanhTien);
            Controls.Add(lblTienCoc);
            Controls.Add(lblNgayGiao);
            Controls.Add(lblHang);
            Controls.Add(lblNgayBan);
            Controls.Add(lblKhachHang);
            Controls.Add(lblMaHoaDon);
            Controls.Add(dataGridView1);
            Controls.Add(txtTimKiem);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(cboLoc);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaDon";
            Load += HoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cboLoc;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtTimKiem;
        private DataGridView dataGridView1;
        private Label lblMaHoaDon;
        private TextBox txtMaHoaDon;
        private Label lblKhachHang;
        private Label lblHang;
        private TextBox txtHang;
        private Label label2;
        private TextBox txtSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblNgayBan;
        private Label lblNgayGiao;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox txtTienCoc;
        private TextBox txtThanhTien;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnLamMoi;
        private Button btnIn;
        private Label lblTienCoc;
        private Label lblThanhTien;
        private ComboBox cboKhachHang;
        private Button btnXoa;
    }
}