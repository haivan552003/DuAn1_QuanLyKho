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
            btnLammoi = new Button();
            btnXoa = new Button();
            btnCapnhap = new Button();
            btnThem = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThongtin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLammoi
            // 
            btnLammoi.BackColor = Color.FromArgb(134, 179, 209);
            btnLammoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLammoi.ForeColor = Color.White;
            btnLammoi.Image = (Image)resources.GetObject("btnLammoi.Image");
            btnLammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLammoi.Location = new Point(549, 591);
            btnLammoi.Margin = new Padding(4);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(125, 56);
            btnLammoi.TabIndex = 32;
            btnLammoi.Text = "Làm mới";
            btnLammoi.TextAlign = ContentAlignment.MiddleRight;
            btnLammoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(132, 77, 54);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(682, 591);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(6, 0, 6, 0);
            btnXoa.Size = new Size(125, 56);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnCapnhap
            // 
            btnCapnhap.BackColor = Color.FromArgb(134, 179, 209);
            btnCapnhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapnhap.ForeColor = Color.White;
            btnCapnhap.Image = (Image)resources.GetObject("btnCapnhap.Image");
            btnCapnhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapnhap.Location = new Point(143, 591);
            btnCapnhap.Margin = new Padding(4);
            btnCapnhap.Name = "btnCapnhap";
            btnCapnhap.Size = new Size(125, 56);
            btnCapnhap.TabIndex = 30;
            btnCapnhap.Text = "Cập nhập";
            btnCapnhap.TextAlign = ContentAlignment.MiddleRight;
            btnCapnhap.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(134, 179, 209);
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(10, 591);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(6, 0, 6, 0);
            btnThem.Size = new Size(125, 56);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 494);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 12;
            label3.Text = "Tên :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(2, 543);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 28);
            label8.TabIndex = 11;
            label8.Text = "Mã ND:";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(425, 497);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 10;
            label7.Text = "SĐT:";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(416, 450);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 9;
            label6.Text = "Địa chỉ:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 447);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 15;
            label2.Text = "Mã KH:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(348, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
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
            cboLoc.Location = new Point(37, 80);
            cboLoc.Margin = new Padding(4);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(150, 33);
            cboLoc.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(170, 160, 160);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 22);
            pictureBox1.Margin = new Padding(4);
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
            dgvThongtin.Location = new Point(10, 158);
            dgvThongtin.Margin = new Padding(4);
            dgvThongtin.Name = "dgvThongtin";
            dgvThongtin.RowHeadersWidth = 51;
            dgvThongtin.RowTemplate.Height = 29;
            dgvThongtin.Size = new Size(796, 278);
            dgvThongtin.TabIndex = 49;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(605, 85);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 31);
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(300, 85);
            txtTimkiem.Margin = new Padding(4);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(310, 31);
            txtTimkiem.TabIndex = 50;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(101, 494);
            txtTen.Margin = new Padding(4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(289, 31);
            txtTen.TabIndex = 53;
            // 
            // txtDiachi
            // 
            txtDiachi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiachi.Location = new Point(502, 447);
            txtDiachi.Margin = new Padding(4);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(289, 31);
            txtDiachi.TabIndex = 54;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaKH.Location = new Point(101, 444);
            txtMaKH.Margin = new Padding(4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(289, 31);
            txtMaKH.TabIndex = 56;
            // 
            // txtSĐT
            // 
            txtSĐT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSĐT.Location = new Point(502, 491);
            txtSĐT.Margin = new Padding(4);
            txtSĐT.Name = "txtSĐT";
            txtSĐT.Size = new Size(289, 31);
            txtSĐT.TabIndex = 57;
            // 
            // cboMaND
            // 
            cboMaND.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cboMaND.FormattingEnabled = true;
            cboMaND.Location = new Point(101, 543);
            cboMaND.Margin = new Padding(4);
            cboMaND.Name = "cboMaND";
            cboMaND.Size = new Size(289, 33);
            cboMaND.TabIndex = 58;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 160, 160);
            ClientSize = new Size(820, 660);
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
            Controls.Add(btnLammoi);
            Controls.Add(btnXoa);
            Controls.Add(btnCapnhap);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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

        private Button btnLammoi;
        private Button btnXoa;
        private Button btnCapnhap;
        private Button btnThem;
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
    }
}