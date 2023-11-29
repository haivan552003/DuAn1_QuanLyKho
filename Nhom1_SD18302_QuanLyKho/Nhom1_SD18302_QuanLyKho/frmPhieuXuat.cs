using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmPhieuXuat : Form
    {
        BUS_PhieuXuat busPX = new BUS_PhieuXuat();
        //int soLuong;
        //bool isInt = int.TryParse(txt_soLuong.Text.Trim().ToString(), out soLuong);
        public frmPhieuXuat()
        {
            InitializeComponent();

        }
        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            loadPhieuXuat();
            get_maHang();
            get_maND();
        }
        public void loadPhieuXuat()
        {
            dv_PX.DataSource = busPX.get_PhieuXuat();
        }
        public void get_maHang()
        {
            cboMaHang.DataSource = busPX.get_maHang();
            cboMaHang.DisplayMember = "ten_hang";
            cboMaHang.ValueMember = "ma_hang";
        }
        public void get_maND()
        {
            cboNguoiDung.DataSource = busPX.get_MaND();
            cboNguoiDung.DisplayMember = "ten_nd";
            cboNguoiDung.ValueMember = "ma_nd";
        }
        public void get_maPX()
        {
            cbo_maPX.DataSource = busPX.get_mapx();
            cbo_maPX.DisplayMember = "ma_phieu_xuat";
            cbo_maPX.ValueMember = "ma_phieu_xuat";
        }
        public void reset()
        {
            cboMaHang.Text = "";
            cboNguoiDung.Text = "";
            cbo_maPX.Text = "";
            txt_soLuong.Text = "";

        }


        private void btn_themPX_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(txt_soLuong.Text.Trim().ToString(), out intSoLuong);
            if (cboMaHang.Text == "" && cboNguoiDung.Text == "" && txt_soLuong.Text == "")
            {
                MessageBox.Show("Thêm thất bại \\ điền đủ thông tin để thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboMaHang.Text == "")
            {
                MessageBox.Show("Thêm thất bại \\ điền đủ thông tin để thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboNguoiDung.Text == "")
            {
                MessageBox.Show("Thêm thất bại \\ điền đủ thông tin để thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_soLuong.Text == "")
            {
                MessageBox.Show("Thêm thất bại \\ điền đủ thông tin để thêm mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(cboMaHang.SelectedValue.ToString()) ||
                !string.IsNullOrWhiteSpace(cboNguoiDung.SelectedValue.ToString()) ||
                !string.IsNullOrWhiteSpace(cbo_maPX.SelectedValue.ToString()) ||
                //!string.IsNullOrWhiteSpace(int.Parse()) ||
                !string.IsNullOrWhiteSpace(dtp_ngayXuat.Text))
                {
                    if (!isInt || int.Parse(txt_soLuong.Text) < 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_soLuong.Focus();
                        return;
                    }
                    else
                    {
                        DTO_PhieuXuat phieuXuatt = new DTO_PhieuXuat(cbo_maPX.Text, cboMaHang.SelectedValue.ToString(), int.Parse(txt_soLuong.Text), dtp_ngayXuat.Text, cboNguoiDung.SelectedValue.ToString());
                        if (cbo_maPX.SelectedValue == null)
                        {

                            DTO_PhieuXuat phieuXuat = new DTO_PhieuXuat(dtp_ngayXuat.Text, cboNguoiDung.SelectedValue.ToString());
                            if (!busPX.them_PX(phieuXuat))
                            {
                                get_maPX();
                                DTO_PhieuXuat CTphieuXuat = new DTO_PhieuXuat(cboMaHang.SelectedValue.ToString(), cbo_maPX.SelectedValue.ToString(), int.Parse(txt_soLuong.Text));
                                if (!busPX.them_CTPX(CTphieuXuat))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadPhieuXuat();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                loadPhieuXuat();
                            }
                            else
                            {
                                MessageBox.Show("thêm thất bại");
                            }
                        }
                        else
                        {

                            DataTable dtSoLuong = busPX.get_soLuong(cbo_maPX.SelectedValue.ToString(), cboMaHang.SelectedValue.ToString());

                            if (dtSoLuong != null && dtSoLuong.Rows.Count > 0)
                            {
                                object soLuongObj = dtSoLuong.Rows[0][0].ToString();
                                //neu sp da ton tai trong hoa don
                                int soLuongSP = Convert.ToInt32(soLuongObj) + int.Parse(txt_soLuong.Text);

                                DTO_PhieuXuat ctpx = new DTO_PhieuXuat(cboMaHang.SelectedValue.ToString(), cbo_maPX.SelectedValue.ToString(), int.Parse(txt_soLuong.Text));

                                if (busPX.sua_soLuong(ctpx))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadPhieuXuat();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //them cthd
                                DTO_PhieuXuat ctpx = new DTO_PhieuXuat(cboMaHang.SelectedValue.ToString(), cbo_maPX.SelectedValue.ToString(), int.Parse(txt_soLuong.Text));

                                if (busPX.sua_soLuong(ctpx))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadPhieuXuat();
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


        }

        private void cbo_maPX_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_maPX();
        }

        private void btn_capnhatPX_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(txt_soLuong.Text.Trim().ToString(), out intSoLuong);
            if (cboMaHang.Text == "" && cboNguoiDung.Text == "" && txt_soLuong.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ vui lòng điền điền đủ thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboMaHang.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ vui lòng điền điền đủ thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboNguoiDung.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ vui lòng điền điền đủ thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_soLuong.Text == "")
            {
                MessageBox.Show("Sửa thất bại \\ vui lòng điền điền đủ thông tin ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(cboMaHang.SelectedValue.ToString()) ||
                        !string.IsNullOrWhiteSpace(cboNguoiDung.SelectedValue.ToString()) ||
                        !string.IsNullOrWhiteSpace(cbo_maPX.SelectedValue.ToString()) ||
                        //!string.IsNullOrWhiteSpace(int.Parse()) ||
                        !string.IsNullOrWhiteSpace(dtp_ngayXuat.Text))
                    {
                        if (!isInt || int.Parse(txt_soLuong.Text) < 0)
                        {
                            MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_soLuong.Focus();
                            return;
                        }
                        else
                        {
                            DTO_PhieuXuat phieuXuatt = new DTO_PhieuXuat(cbo_maPX.Text, dtp_ngayXuat.Text, cboNguoiDung.SelectedValue.ToString());
                            if (cbo_maPX.Text != null)
                            {
                                if (busPX.sua_phieuXuat(phieuXuatt))
                                {

                                    DTO_PhieuXuat ctpx_soLuong = new DTO_PhieuXuat(cboMaHang.SelectedValue.ToString(), cbo_maPX.Text, int.Parse(txt_soLuong.Text));
                                    if (busPX.sua_chiTietPhieuXuat(ctpx_soLuong))
                                    {
                                        MessageBox.Show("Sửa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        loadPhieuXuat();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void dv_PX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lst = dv_PX.CurrentRow.Index;
            cbo_maPX.Text = dv_PX.Rows[lst].Cells[0].Value.ToString();
            cboMaHang.Text = dv_PX.Rows[lst].Cells[2].Value.ToString();
            txt_soLuong.Text = dv_PX.Rows[lst].Cells[3].Value.ToString();
            dtp_ngayXuat.Text = dv_PX.Rows[lst].Cells[4].Value.ToString();
            cboNguoiDung.Text = dv_PX.Rows[lst].Cells[5].Value.ToString();

        }

        private void btn_xoaPX_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("bạn có muốn xóa toàn bộ phiếu xuất?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (cbo_maPX.Text != null && cboMaHang.Text != null)
                {
                    busPX.xoa_full(cbo_maPX.Text);
                    busPX.xoa_px(cbo_maPX.Text);
                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPhieuXuat();
                    get_maPX();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (cbo_maPX.SelectedValue != null && cboMaHang.SelectedValue != null)
                {
                    busPX.xoa_ctpx(cboMaHang.SelectedValue.ToString(), cbo_maPX.Text);
                    busPX.xoa_px(cbo_maPX.Text);
                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPhieuXuat();
                    get_maPX();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ptb_timPX_Click(object sender, EventArgs e)
        {
            string ten_px = txt_timPX.Text;
            DataTable dt = busPX.tim_phieuXuat(ten_px);
            if (cbo_maPX.SelectedValue != null && cboMaHang.SelectedValue != null)
            {
                MessageBox.Show("Tìm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadPhieuXuat();
            }
            else
            {
                MessageBox.Show("Tìm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_locPX_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbx_locPX.SelectedItem == "Hàng")
            {
                dv_PX.DataSource = busPX.get_loc_Hang();
            }
            else if (cbx_locPX.SelectedItem == "Tên Hàng")
            {
                dv_PX.DataSource = busPX.get_loc_tenHang();
            }

        }
    }
}
