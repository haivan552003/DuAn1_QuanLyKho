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
            textBox6 = new TextBox();
            pictureBox2 = new PictureBox();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            btn_inPN = new Button();
            btn_lammoiPX = new Button();
            btn_xoaPX = new Button();
            btn_capnhatPX = new Button();
            btn_themPX = new Button();
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
            comboBox1.Location = new Point(12, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
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
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(150, 438);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(250, 27);
            txtMaHoaDon.TabIndex = 5;
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
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoLuong.ForeColor = Color.White;
            lblSoLuong.Location = new Point(28, 542);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(83, 23);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(150, 538);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(250, 27);
            txtSoLuong.TabIndex = 11;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonGia.ForeColor = Color.White;
            lblDonGia.Location = new Point(28, 575);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(74, 23);
            lblDonGia.TabIndex = 12;
            lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(150, 571);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(250, 27);
            txtDonGia.TabIndex = 13;
            // 
            // dtpNgayGiao
            // 
            dtpNgayGiao.Location = new Point(538, 470);
            dtpNgayGiao.Name = "dtpNgayGiao";
            dtpNgayGiao.Size = new Size(250, 27);
            dtpNgayGiao.TabIndex = 15;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Location = new Point(538, 439);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(250, 27);
            dtpNgayBan.TabIndex = 16;
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
            lblTienCoc.Location = new Point(439, 507);
            lblTienCoc.Name = "lblTienCoc";
            lblTienCoc.Size = new Size(77, 23);
            lblTienCoc.TabIndex = 19;
            lblTienCoc.Text = "Tiền cọc:";
            // 
            // txtTienCoc
            // 
            txtTienCoc.Location = new Point(539, 503);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.Size = new Size(250, 27);
            txtTienCoc.TabIndex = 20;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(538, 538);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(251, 27);
            txtThanhTien.TabIndex = 21;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThanhTien.ForeColor = Color.White;
            lblThanhTien.Location = new Point(439, 542);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(96, 23);
            lblThanhTien.TabIndex = 22;
            lblThanhTien.Text = "Thành tiền:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(237, 76);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(310, 27);
            textBox6.TabIndex = 28;
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
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(820, 660);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnNhapExcel);
            Controls.Add(btn_inPN);
            Controls.Add(btn_lammoiPX);
            Controls.Add(btn_xoaPX);
            Controls.Add(btn_capnhatPX);
            Controls.Add(btn_themPX);
            Controls.Add(pictureBox2);
            Controls.Add(textBox6);
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
        private TextBox textBox6;
        private PictureBox pictureBox2;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private Button btn_inPN;
        private Button btn_lammoiPX;
        private Button btn_xoaPX;
        private Button btn_capnhatPX;
        private Button btn_themPX;
    }
}