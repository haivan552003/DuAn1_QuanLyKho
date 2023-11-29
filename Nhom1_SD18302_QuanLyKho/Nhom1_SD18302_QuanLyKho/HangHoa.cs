using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmHangHoa : Form
    {
        BUS_Hang busHang = new BUS_Hang();
        string checkUrlImg;
        string fileName;
        string fileSavePath;
        string fileAddress;
        public frmHangHoa()
        {
            InitializeComponent();
            loadHangHoa();
            get_tenHang();
            get_donGia();
            get_maKho();
            get_maDanhMuc();
            get_maND();
        }
        void reset()
        {
            cbo_maNguoiDung.Text = "";
            txt_anh.Text = "";
            cboTenHang.Text = "";
            cbo_maKho.Text = "";
            cbo_DonGia.Text = "";
            cbo_maDanhMuc.Text = "";
            txt_ghichu.Text = "";
            txtMaHang.Text = "";
        }
        public void get_tenHang()
        {
            cboTenHang.DataSource = busHang.get_tenHang();
            cboTenHang.DisplayMember = "ten_hang";
            cboTenHang.ValueMember = "ma_hang";
        }
        public void get_donGia()
        {
            cbo_DonGia.DataSource = busHang.get_dongia();
            cbo_DonGia.DisplayMember = "don_gia";
            cbo_DonGia.ValueMember = "don_gia";

        }
        public void get_maKho()
        {
            cbo_maKho.DataSource = busHang.get_maKho();
            cbo_maKho.DisplayMember = "ten_kho";
            cbo_maKho.ValueMember = "ma_kho";

        }

        public void get_maDanhMuc()
        {
            cbo_maDanhMuc.DataSource = busHang.get_maDanhMuc();
            cbo_maDanhMuc.DisplayMember = "ten_danh_muc";
            cbo_maDanhMuc.ValueMember = "ma_danh_muc";
        }
        public void get_maND()
        {
            cbo_maNguoiDung.DataSource = busHang.get_maND();
            cbo_maNguoiDung.DisplayMember = "ten_nd";
            cbo_maNguoiDung.ValueMember = "ma_nd";
        }

        public void loadHangHoa()
        {
            dgvHoaDon.DataSource = busHang.getHangHoa();
        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            int lst = dgvHoaDon.CurrentRow.Index;
            txtMaHang.Text = dgvHoaDon.Rows[lst].Cells[0].Value.ToString();
            cboTenHang.Text = dgvHoaDon.Rows[lst].Cells[1].Value.ToString();
            cbo_DonGia.Text = dgvHoaDon.Rows[lst].Cells[2].Value.ToString();
            dtp_hanSuDung.Text = dgvHoaDon.Rows[lst].Cells[3].Value.ToString();
            txt_ghichu.Text = dgvHoaDon.Rows[lst].Cells[4].Value.ToString();
            txt_anh.Text = dgvHoaDon.Rows[lst].Cells[5].Value.ToString();
            checkUrlImg = txt_anh.Text;
            cbo_maDanhMuc.Text = dgvHoaDon.Rows[lst].Cells[6].Value.ToString();
            cbo_maNguoiDung.Text = dgvHoaDon.Rows[lst].Cells[7].Value.ToString();
            cbo_maKho.Text = dgvHoaDon.Rows[lst].Cells[8].Value.ToString();

            string imagePath = Path.Combine(saveDirectory, txt_anh.Text);
            if (File.Exists(imagePath))
            {
                ptb_anhHH.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy hình ảnh: " + imagePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon anh";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                ptb_anhHH.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txt_anh.Text = "\\Images\\" + fileName;
            }
        }
        private void btn_themPX_Click(object sender, EventArgs e)
        {
            DTO_HangHoa hangHoa = new DTO_HangHoa(cboTenHang.SelectedValue.ToString(), float.Parse(cbo_DonGia.SelectedValue.ToString()), dtp_hanSuDung
                .Text, txt_ghichu.Text, txt_anh.Text, cbo_maDanhMuc.SelectedValue.ToString(), cbo_maNguoiDung.SelectedValue.ToString(), cbo_maKho.SelectedValue.ToString());
            if (cboTenHang.Text == "" && cbo_DonGia.Text == "" && txt_ghichu.Text == "" && txt_anh.Text == "" && cbo_maDanhMuc.Text == "" && cbo_maNguoiDung.Text == "" && cbo_maKho.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else if (cboTenHang.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else if (txt_anh.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else if (txt_ghichu.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else if (cbo_maNguoiDung.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else if (cbo_maDanhMuc.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else if (cbo_DonGia.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else if (cbo_maKho.Text == "")
            {
                MessageBox.Show("thêm thất bại \\ cần điền đầy đủ thông tin để thêm mới");
            }
            else
            {
                if (!busHang.themHangHoa(hangHoa))
                {
                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadHangHoa();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_capnhatHH_Click(object sender, EventArgs e)
        {
            DTO_HangHoa hangHoa = new DTO_HangHoa(cboTenHang.SelectedValue.ToString(), float.Parse(cbo_DonGia.SelectedValue.ToString()), dtp_hanSuDung
                .Text, txt_ghichu.Text, txt_anh.Text, cbo_maDanhMuc.SelectedValue.ToString(), cbo_maNguoiDung.SelectedValue.ToString(), cbo_maKho.SelectedValue.ToString());
            if (cboTenHang.Text == "" && cbo_DonGia.Text == "" && txt_ghichu.Text == "" && txt_anh.Text == "" && cbo_maDanhMuc.Text == "" && cbo_maNguoiDung.Text == "" && cbo_maKho.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else if (cboTenHang.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else if (txt_anh.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else if (txt_ghichu.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else if (cbo_maNguoiDung.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else if (cbo_maDanhMuc.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else if (cbo_DonGia.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else if (cbo_maKho.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ cần điền đầy đủ thông tin để Sửa");
            }
            else
            {
                if (busHang.sua_hangHoa(hangHoa))
                {
                    MessageBox.Show("Sua thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadHangHoa();
                }
                else
                {
                    MessageBox.Show("Sua thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_xoaHH_Click(object sender, EventArgs e)
        {
            if (cboTenHang.Text == "" && cbo_DonGia.Text == "" && txt_ghichu.Text == "" && txt_anh.Text == "" && cbo_maDanhMuc.Text == "" && cbo_maNguoiDung.Text == "" && cbo_maKho.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else if (cboTenHang.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else if (txt_anh.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else if (txt_ghichu.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else if (cbo_maNguoiDung.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else if (cbo_maDanhMuc.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else if (cbo_DonGia.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else if (cbo_maKho.Text == "")
            {
                MessageBox.Show("xóa thất bại");
            }
            else
            {
                string maHangHoa = txtMaHang.Text;
                if (MessageBox.Show("Bạn có muốn chỉnh xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busHang.xoa_hangHoa(maHangHoa))
                    {
                        MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadHangHoa();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ptb_timHH_Click(object sender, EventArgs e)
        {
            string tenHang = txt_timHH.Text;
            DataTable dt = busHang.tim_hangHoa(tenHang);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("tìm thành công");
                loadHangHoa();
            }
            else
            {
                MessageBox.Show("tìm thất bại");
            }
        }
        private void btn_lammoiHH_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void cbo_locHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_locHH.SelectedItem == "A-Z")
            {
                dgvHoaDon.DataSource = busHang.locAZ();
            }
            else
            {
                dgvHoaDon.DataSource = busHang.locZA();

            }
        }
    }
}
