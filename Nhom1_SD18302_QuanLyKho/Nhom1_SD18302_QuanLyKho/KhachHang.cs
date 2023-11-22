using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmKhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void LoadKH()
        {
            dvThongTin.DataSource = busKH.getKhachHang();
        }

        private void ResetValues()
        {
            txtMaKH.Enabled = false;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
            ResetValues();
            cboMaND.DataSource = busKH.getNguoiDung();
            cboMaND.DisplayMember = "ten_nd";
            cboMaND.ValueMember = "ma_nd";
        }

        private void btn_themPX_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtSDT.Text.Trim().ToString(), out intDienThoai);


            if (!isInt || float.Parse(txtSDT.Text) < 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txtTen.Text, txtDiachi.Text, txtSDT.Text, cboMaND.SelectedValue.ToString());

                if (busKH.insertKH(kh))
                {
                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKH();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_capnhatPX_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang(txtMaKH.Text, txtTen.Text, txtDiachi.Text, txtSDT.Text, cboMaND.SelectedValue.ToString());

            if (busKH.updateKH(kh))
            {
                MessageBox.Show("Sửa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKH();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dvThongTin.SelectedRows)
            {
                txtMaKH.Text = item.Cells[0].Value.ToString();
                txtTen.Text = item.Cells[1].Value.ToString();
                txtDiachi.Text = item.Cells[2].Value.ToString();
                txtSDT.Text = item.Cells[3].Value.ToString();
                string maNd = item.Cells[4].Value.ToString();

                int index = cboMaND.FindStringExact(maNd);

                if (index != -1)
                {
                    cboMaND.SelectedIndex = index;
                }
            }
        }

        private void btn_xoaPX_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;

            if (MessageBox.Show("Bạn có muốn xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busKH.deleteKH(maKH))
                {
                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKH();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenKH = txtTimkiem.Text;
            DataTable dt = busKH.SeachKH(tenKH);

            if (dt.Rows.Count > 0)
            {
                dvThongTin.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoc.SelectedItem == "A - Z")
            {
                dvThongTin.DataSource = busKH.LocAZ();
            }
            else
            {
                dvThongTin.DataSource = busKH.LocZA();
            }
        }
    }
}
