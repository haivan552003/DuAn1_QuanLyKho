namespace Nhom1_SD18302_QuanLyKho
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboLoc = new ComboBox();
            pictureBox1 = new PictureBox();
            dgvThongtin = new DataGridView();
            pictureBox2 = new PictureBox();
            txtTimkiem = new TextBox();
            txtTen = new TextBox();
            txtDiachi = new TextBox();
            txtMaKH = new TextBox();
            txtSĐT = new TextBox();
            cboMaND = new ComboBox();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            btn_inPN = new Button();
            btn_lammoiPX = new Button();
            btn_xoaPX = new Button();
            btn_capnhatPX = new Button();
            btn_themPX = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongtin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 515);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 12;
            label3.Text = "Tên khách hàng:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 554);
            label8.Name = "label8";
            label8.Size = new Size(134, 23);
            label8.TabIndex = 11;
            label8.Text = "Mã người dùng:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(435, 518);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 10;
            label7.Text = "Số điện thoại:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(435, 478);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 478);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 15;
            label2.Text = "Mã khách hàng:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 8;
            label1.Text = "KHÁCH HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cboLoc
            // 
            cboLoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboLoc.FormattingEnabled = true;
            cboLoc.Location = new Point(12, 68);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(150, 28);
            cboLoc.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // dgvThongtin
            // 
            dgvThongtin.BackgroundColor = SystemColors.ActiveBorder;
            dgvThongtin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongtin.Location = new Point(8, 104);
            dgvThongtin.Name = "dgvThongtin";
            dgvThongtin.RowHeadersWidth = 51;
            dgvThongtin.RowTemplate.Height = 29;
            dgvThongtin.Size = new Size(796, 352);
            dgvThongtin.TabIndex = 49;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(557, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(245, 68);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(310, 27);
            txtTimkiem.TabIndex = 50;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(165, 518);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(232, 27);
            txtTen.TabIndex = 53;
            // 
            // txtDiachi
            // 
            txtDiachi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(556, 476);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(232, 27);
            txtDiachi.TabIndex = 54;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKH.Location = new Point(165, 478);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(232, 27);
            txtMaKH.TabIndex = 56;
            // 
            // txtSĐT
            // 
            txtSĐT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSĐT.Location = new Point(556, 511);
            txtSĐT.Name = "txtSĐT";
            txtSĐT.Size = new Size(232, 27);
            txtSĐT.TabIndex = 57;
            // 
            // cboMaND
            // 
            cboMaND.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaND.FormattingEnabled = true;
            cboMaND.Location = new Point(165, 557);
            cboMaND.Name = "cboMaND";
            cboMaND.Size = new Size(232, 28);
            cboMaND.TabIndex = 58;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(139, 189, 188);
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(452, 603);
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
            btnNhapExcel.Location = new Point(346, 603);
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
            btn_inPN.Location = new Point(25, 603);
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
            btn_lammoiPX.Location = new Point(593, 601);
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
            btn_xoaPX.Location = new Point(699, 601);
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
            btn_capnhatPX.Location = new Point(237, 603);
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
            btn_themPX.Location = new Point(131, 603);
            btn_themPX.Name = "btn_themPX";
            btn_themPX.Padding = new Padding(5, 0, 5, 0);
            btn_themPX.Size = new Size(100, 45);
            btn_themPX.TabIndex = 78;
            btn_themPX.Text = "Thêm";
            btn_themPX.TextAlign = ContentAlignment.MiddleRight;
            btn_themPX.UseVisualStyleBackColor = false;
            // 
            // frmKhachHang
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
            Controls.Add(cboMaND);
            Controls.Add(txtSĐT);
            Controls.Add(txtMaKH);
            Controls.Add(txtDiachi);
            Controls.Add(txtTen);
            Controls.Add(pictureBox2);
            Controls.Add(txtTimkiem);
            Controls.Add(dgvThongtin);
            Controls.Add(cboLoc);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongtin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label1;
        private ComboBox cboLoc;
        private PictureBox pictureBox1;
        private DataGridView dgvThongtin;
        private PictureBox pictureBox2;
        private TextBox txtTimkiem;
        private TextBox txtTen;
        private TextBox txtDiachi;
        private TextBox txtMaKH;
        private TextBox txtSĐT;
        private ComboBox cboMaND;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private Button btn_inPN;
        private Button btn_lammoiPX;
        private Button btn_xoaPX;
        private Button btn_capnhatPX;
        private Button btn_themPX;
    }
}