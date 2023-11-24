using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmHoaDon : Form
    {
        BUS_HoaDon busHD = new BUS_HoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void getHH()
        {
            cboHang.DataSource = busHD.getHangHoa();
            cboHang.DisplayMember = "ten_hang";
            cboHang.ValueMember = "ma_hang";
        }

        private void getKH()
        {
            cboKhachHang.DataSource = busHD.getKhachHang();
            cboKhachHang.DisplayMember = "ten_khach_hang";
            cboKhachHang.ValueMember = "ma_khach_hang";
        }

        private void getNV()
        {
            cboNhanVien.DataSource = busHD.getNguoiDung();
            cboNhanVien.DisplayMember = "ten_nd";
            cboNhanVien.ValueMember = "ma_nd";
        }

        private void getHD()
        {
            cboMaHD.DataSource = busHD.getMaHD();
            cboMaHD.DisplayMember = "ma_hoa_don";
            cboMaHD.ValueMember = "ma_hoa_don";
        }

        private void LoadHD()
        {
            dgvHoaDon.DataSource = busHD.getHoaDon();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
            getKH();
            getHH();
            getNV();
        }

        private void cboHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHang.SelectedValue != null)
            {
                DataTable dtDonGia = busHD.getDonGia(cboHang.SelectedValue.ToString());

                if (dtDonGia.Rows.Count > 0)
                {
                    object maHangObj = dtDonGia.Rows[0][0].ToString();
                    if (maHangObj != DBNull.Value)
                    {
                        txtDonGia.Text = maHangObj.ToString();
                    }
                    else
                    {
                        txtDonGia.Text = "0";
                    }
                }
            }
            else
            {
                txtDonGia.Text = "0";
            }
        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {
            float donGia, soLuong, tienCoc;
            if (float.TryParse(txtDonGia.Text, out donGia) &&
                float.TryParse(txtSoLuong.Text, out soLuong) &&
                float.TryParse(txtTienCoc.Text, out tienCoc))
            {
                float thanhTien = donGia * soLuong - tienCoc;
                txtThanhTien.Text = thanhTien.ToString();
            }
            else
            {
                // Xử lý khi dữ liệu không hợp lệ
                txtThanhTien.Text = "0";
            }
        }

        private void btn_themPX_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            float floatTienCoc;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoLuong);
            bool isFloat = float.TryParse(txtSoLuong.Text.Trim().ToString(), out floatTienCoc);

            DateTime ngayBan = dtpNgayBan.Value;
            DateTime ngayGiao = dtpNgayGiao.Value;
            string ngayBanFormatted = ngayBan.ToString("dd/MM/yyyy");
            string ngayGiaoFormatted = ngayGiao.ToString("dd/MM/yyyy");

            try
            {
                //them day du hd
                if (!string.IsNullOrWhiteSpace(cboKhachHang.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(cboHang.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    !string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                    !string.IsNullOrWhiteSpace(dtpNgayBan.Text) ||
                    !string.IsNullOrWhiteSpace(dtpNgayGiao.Text) ||
                    !string.IsNullOrWhiteSpace(txtTienCoc.Text) ||
                    !string.IsNullOrWhiteSpace(txtThanhTien.Text))
                {
                    if (!isInt || int.Parse(txtSoLuong.Text) < 0 ||
                        !isFloat || float.Parse(txtTienCoc.Text) < 0
                        )
                    {
                        MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSoLuong.Focus();
                        return;
                    }
                    else
                    {

                        DTO_HoaDon hd = new DTO_HoaDon(ngayBanFormatted, ngayGiaoFormatted, float.Parse(txtTienCoc.Text), cboNhanVien.SelectedValue.ToString(), cboKhachHang.SelectedValue.ToString());

                        if (cboMaHD.SelectedValue == null)
                        {
                            //them hoa don + chi tiet hoa don
                            if (busHD.insertHD(hd))
                            {
                                getHD();
                                DTO_HoaDon cthd = new DTO_HoaDon(cboMaHD.SelectedValue.ToString(), cboHang.SelectedValue.ToString(), int.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text), float.Parse(txtThanhTien.Text));
                                if (busHD.insertCTHD(cthd))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadHD();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            DataTable dtSoLuong = busHD.getSoLuongSP(cboMaHD.SelectedValue.ToString(), cboHang.SelectedValue.ToString());

                            if (dtSoLuong != null && dtSoLuong.Rows.Count > 0)
                            {
                                object soLuongObj = dtSoLuong.Rows[0][0].ToString();
                                object thanhTienObj = dtSoLuong.Rows[0][1].ToString();

                                //neu sp da ton tai trong hoa don
                                int soLuongSP = Convert.ToInt32(soLuongObj) + int.Parse(txtSoLuong.Text);
                                float thanhTien = Convert.ToSingle(thanhTienObj) + Convert.ToSingle(txtThanhTien.Text) - Convert.ToSingle(txtTienCoc.Text);

                                DTO_HoaDon cthd_soLuong = new DTO_HoaDon(cboMaHD.SelectedValue.ToString(), cboHang.SelectedValue.ToString(), soLuongSP, thanhTien);

                                if (busHD.insertSoLuongSP(cthd_soLuong))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadHD();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //them cthd
                                DTO_HoaDon cthd = new DTO_HoaDon(cboMaHD.SelectedValue.ToString(), cboHang.SelectedValue.ToString(), int.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text), float.Parse(txtThanhTien.Text));

                                if (busHD.insertCTHD(cthd))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadHD();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { }
        }

        private void cboMaHD_Click(object sender, EventArgs e)
        {
            getHD();
        }

        private void btn_capnhatPX_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            float floatTienCoc;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoLuong);
            bool isFloat = float.TryParse(txtSoLuong.Text.Trim().ToString(), out floatTienCoc);

            DateTime ngayBan = dtpNgayBan.Value;
            DateTime ngayGiao = dtpNgayGiao.Value;
            string ngayBanFormatted = ngayBan.ToString("dd/MM/yyyy");
            string ngayGiaoFormatted = ngayGiao.ToString("dd/MM/yyyy");

            try
            {
                //sua day du hd
                if (!string.IsNullOrWhiteSpace(cboKhachHang.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(cboHang.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    !string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                    !string.IsNullOrWhiteSpace(dtpNgayBan.Text) ||
                    !string.IsNullOrWhiteSpace(dtpNgayGiao.Text) ||
                    !string.IsNullOrWhiteSpace(txtTienCoc.Text) ||
                    !string.IsNullOrWhiteSpace(txtThanhTien.Text))
                {
                    if (!isInt || int.Parse(txtSoLuong.Text) < 0 ||
                        !isFloat || float.Parse(txtTienCoc.Text) < 0
                        )
                    {
                        MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSoLuong.Focus();
                        return;
                    }
                    else
                    {
                        DTO_HoaDon hd = new DTO_HoaDon(cboMaHD.SelectedValue.ToString(), ngayBanFormatted, ngayGiaoFormatted, float.Parse(txtTienCoc.Text), cboNhanVien.SelectedValue.ToString(), cboKhachHang.SelectedValue.ToString());

                        if (cboMaHD.SelectedValue.ToString() != null)
                        {
                            //sua hoa don + chi tiet hoa don
                            if (busHD.updateHoaDon(hd))
                            {
                                DataTable dtSoLuong = busHD.getSoLuongSP(cboMaHD.SelectedValue.ToString(), cboHang.SelectedValue.ToString());

                                object soLuongObj = dtSoLuong.Rows[0][0].ToString();
                                object thanhTienObj = dtSoLuong.Rows[0][1].ToString();

                                float thanhTien = Convert.ToSingle(thanhTienObj) + Convert.ToSingle(txtThanhTien.Text) - Convert.ToSingle(txtTienCoc.Text);

                                DTO_HoaDon cthd_soLuong = new DTO_HoaDon(cboMaHD.SelectedValue.ToString(), cboHang.SelectedValue.ToString(), int.Parse(txtSoLuong.Text), thanhTien);

                                if (busHD.insertSoLuongSP(cthd_soLuong))
                                {
                                    MessageBox.Show("Sửa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadHD();
                                }
                                else
                                {
                                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btn_xoaPX_Click(object sender, EventArgs e)
        {
            string maHD = cboMaHD.SelectedValue.ToString();
            string maHH = cboHang.SelectedValue.ToString();

            DialogResult resualt = MessageBox.Show("Bạn có muốn xóa toàn bộ hóa đơn?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resualt == DialogResult.Yes)
            {
                if (maHD != null && maHH != null)
                {
                    busHD.delete_full_CTHD(maHD);
                    busHD.deleteHD(maHD);

                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHD();
                    getHD();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (resualt == DialogResult.No)
            {
                if (maHD != null && maHH != null)
                {
                    busHD.deleteCTHD(maHD, maHH);
                    busHD.deleteHD(maHD);

                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHD();
                    getHD();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getHD();
            foreach (DataGridViewRow item in dgvHoaDon.SelectedRows)
            {
                cboMaHD.Text = item.Cells[0].Value.ToString();
                cboKhachHang.Text = item.Cells[4].Value.ToString();
                cboHang.Text = item.Cells[5].Value.ToString();
                cboNhanVien.Text = item.Cells[3].Value.ToString();


                //DateTime dateTime = DateTime.ParseExact(dtpNgayBan.Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //dtpNgayBan.Text = item.Cells[1].Value.ToString();
                //try
                //{

                //    dtpNgayGiao.Text = item.Cells[2].Value.ToString();
                //}
                //catch (Exception) { }


                txtSoLuong.Text = item.Cells[6].Value.ToString();
                txtDonGia.Text = item.Cells[7].Value.ToString();
                txtThanhTien.Text = item.Cells[9].Value.ToString();
                txtTienCoc.Text = item.Cells[8].Value.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string maHD = txtTim.Text;
            DataTable dt = busHD.SeachHD(maHD);

            if (dt.Rows.Count > 0)
            {
                dgvHoaDon.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoc.SelectedItem == "A - Z")
            {
                dgvHoaDon.DataSource = busHD.loc_hd_a_z();
            }
            else
            {
                dgvHoaDon.DataSource = busHD.loc_hd_z_a();
            }
        }
    }
}

