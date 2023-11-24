namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cboSapXep = new ComboBox();
            txtTimKiem = new TextBox();
            btnTim = new PictureBox();
            dvThongTin = new DataGridView();
            txtMaND = new TextBox();
            txtTuoi = new TextBox();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtSDT = new TextBox();
            label2 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            label5 = new Label();
            lbl = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            ckNam = new RadioButton();
            ckNu = new RadioButton();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            btn_inPN = new Button();
            btn_lammoiPX = new Button();
            btn_xoaPX = new Button();
            btn_capnhatPX = new Button();
            btn_themPX = new Button();
            label3 = new Label();
            cboChucvu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvThongTin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(426, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 0;
            label1.Text = "NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cboSapXep
            // 
            cboSapXep.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboSapXep.FormattingEnabled = true;
            cboSapXep.Items.AddRange(new object[] { "A - Z", "Z - A", "Chức Vụ" });
            cboSapXep.Location = new Point(15, 85);
            cboSapXep.Margin = new Padding(4);
            cboSapXep.Name = "cboSapXep";
            cboSapXep.Size = new Size(186, 33);
            cboSapXep.TabIndex = 2;
            cboSapXep.SelectedIndexChanged += cboSapXep_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(334, 85);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(386, 31);
            txtTimKiem.TabIndex = 3;
            // 
            // btnTim
            // 
            btnTim.Image = (Image)resources.GetObject("btnTim.Image");
            btnTim.Location = new Point(724, 85);
            btnTim.Margin = new Padding(4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(38, 38);
            btnTim.TabIndex = 4;
            btnTim.TabStop = false;
            btnTim.Click += btnTim_Click;
            // 
            // dvThongTin
            // 
            dvThongTin.BackgroundColor = SystemColors.ActiveBorder;
            dvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvThongTin.Location = new Point(15, 130);
            dvThongTin.Margin = new Padding(4);
            dvThongTin.Name = "dvThongTin";
            dvThongTin.RowHeadersWidth = 51;
            dvThongTin.RowTemplate.Height = 29;
            dvThongTin.Size = new Size(995, 421);
            dvThongTin.TabIndex = 5;
            dvThongTin.Click += dvThongTin_Click;
            // 
            // txtMaND
            // 
            txtMaND.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaND.Location = new Point(230, 572);
            txtMaND.Margin = new Padding(4);
            txtMaND.Name = "txtMaND";
            txtMaND.Size = new Size(299, 31);
            txtMaND.TabIndex = 3;
            // 
            // txtTuoi
            // 
            txtTuoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTuoi.Location = new Point(230, 655);
            txtTuoi.Margin = new Padding(4);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(299, 31);
            txtTuoi.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(230, 614);
            txtTen.Margin = new Padding(4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(299, 31);
            txtTen.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(676, 572);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(676, 660);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(298, 31);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(676, 614);
            txtSDT.Margin = new Padding(4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(298, 31);
            txtSDT.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 572);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã người dùng:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.ForeColor = Color.White;
            lbl4.Location = new Point(54, 619);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(162, 28);
            lbl4.TabIndex = 0;
            lbl4.Text = "Tên người dùng:";
            lbl4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.ForeColor = Color.White;
            lbl3.Location = new Point(54, 660);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(55, 28);
            lbl3.TabIndex = 0;
            lbl3.Text = "Tuổi:";
            lbl3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 702);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 0;
            label5.Text = "Giới tính:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(568, 572);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(65, 28);
            lbl.TabIndex = 0;
            lbl.Text = "Email:";
            lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(568, 619);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(53, 28);
            lbl1.TabIndex = 0;
            lbl1.Text = "SĐT:";
            lbl1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(568, 660);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(103, 28);
            lbl2.TabIndex = 0;
            lbl2.Text = "Mật khẩu:";
            lbl2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ckNam
            // 
            ckNam.AutoSize = true;
            ckNam.Location = new Point(175, 701);
            ckNam.Margin = new Padding(4);
            ckNam.Name = "ckNam";
            ckNam.Size = new Size(75, 29);
            ckNam.TabIndex = 6;
            ckNam.TabStop = true;
            ckNam.Text = "Nam";
            ckNam.UseVisualStyleBackColor = true;
            // 
            // ckNu
            // 
            ckNu.AutoSize = true;
            ckNu.Location = new Point(290, 702);
            ckNu.Margin = new Padding(4);
            ckNu.Name = "ckNu";
            ckNu.Size = new Size(61, 29);
            ckNu.TabIndex = 6;
            ckNu.TabStop = true;
            ckNu.Text = "Nữ";
            ckNu.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(139, 189, 188);
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(559, 754);
            btnXuatExcel.Margin = new Padding(4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(125, 56);
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
            btnNhapExcel.Location = new Point(426, 754);
            btnNhapExcel.Margin = new Padding(4);
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(125, 56);
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
            btn_inPN.Location = new Point(25, 754);
            btn_inPN.Margin = new Padding(4);
            btn_inPN.Name = "btn_inPN";
            btn_inPN.Padding = new Padding(6, 0, 6, 0);
            btn_inPN.Size = new Size(125, 56);
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
            btn_lammoiPX.Location = new Point(735, 751);
            btn_lammoiPX.Margin = new Padding(4);
            btn_lammoiPX.Name = "btn_lammoiPX";
            btn_lammoiPX.Size = new Size(125, 56);
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
            btn_xoaPX.Location = new Point(868, 751);
            btn_xoaPX.Margin = new Padding(4);
            btn_xoaPX.Name = "btn_xoaPX";
            btn_xoaPX.Padding = new Padding(6, 0, 6, 0);
            btn_xoaPX.Size = new Size(125, 56);
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
            btn_capnhatPX.Location = new Point(290, 754);
            btn_capnhatPX.Margin = new Padding(4);
            btn_capnhatPX.Name = "btn_capnhatPX";
            btn_capnhatPX.Size = new Size(125, 56);
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
            btn_themPX.Location = new Point(158, 754);
            btn_themPX.Margin = new Padding(4);
            btn_themPX.Name = "btn_themPX";
            btn_themPX.Padding = new Padding(6, 0, 6, 0);
            btn_themPX.Size = new Size(125, 56);
            btn_themPX.TabIndex = 78;
            btn_themPX.Text = "Thêm";
            btn_themPX.TextAlign = ContentAlignment.MiddleRight;
            btn_themPX.UseVisualStyleBackColor = false;
            btn_themPX.Click += btn_themPX_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(568, 700);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 0;
            label3.Text = "Chức vụ:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // cboChucvu
            // 
            cboChucvu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboChucvu.FormattingEnabled = true;
            cboChucvu.Items.AddRange(new object[] { "Admin", "Kiểm toán", "Nhân viên" });
            cboChucvu.Location = new Point(676, 699);
            cboChucvu.Margin = new Padding(4);
            cboChucvu.Name = "cboChucvu";
            cboChucvu.Size = new Size(298, 33);
            cboChucvu.TabIndex = 82;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1025, 825);
            Controls.Add(cboChucvu);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnNhapExcel);
            Controls.Add(btn_inPN);
            Controls.Add(btn_lammoiPX);
            Controls.Add(btn_xoaPX);
            Controls.Add(btn_capnhatPX);
            Controls.Add(btn_themPX);
            Controls.Add(ckNu);
            Controls.Add(ckNam);
            Controls.Add(dvThongTin);
            Controls.Add(btnTim);
            Controls.Add(txtSDT);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTen);
            Controls.Add(txtEmail);
            Controls.Add(txtTuoi);
            Controls.Add(txtMaND);
            Controls.Add(txtTimKiem);
            Controls.Add(cboSapXep);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lbl3);
            Controls.Add(lbl4);
            Controls.Add(label3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvThongTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cboSapXep;
        private TextBox txtTimKiem;
        private PictureBox btnTim;
        private DataGridView dvThongTin;
        private TextBox txtMaND;
        private TextBox txtTuoi;
        private TextBox txtTen;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtSDT;
        private Label label2;
        private Label lbl4;
        private Label lbl3;
        private Label label5;
        private Label lbl;
        private Label lbl1;
        private Label lbl2;
        private RadioButton ckNam;
        private RadioButton ckNu;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private Button btn_inPN;
        private Button btn_lammoiPX;
        private Button btn_xoaPX;
        private Button btn_capnhatPX;
        private Button btn_themPX;
        private Label label3;
        private ComboBox cboChucvu;
    }
}