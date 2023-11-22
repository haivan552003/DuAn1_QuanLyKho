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

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmDangNhap : Form
    {
        BUS_NhanVien busNV = new BUS.BUS_NhanVien();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();

            nv.Email = txtTenTaiKhoan.Text;
            nv.MatKhau = busNV.Encrypt(txtMatKhau.Text);

            if (!string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) &&
                !string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                if (busNV.NhanVienDangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    frmMain frmMain = new frmMain();
                    frmMain.mail = txtTenTaiKhoan.Text;

                    MessageBox.Show("Đăng nhập thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenTaiKhoan.Text = null;
                    txtMatKhau.Text = null;
                    txtTenTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
