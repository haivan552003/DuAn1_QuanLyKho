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
        int count = 0;
        bool isHide = false;
        public frmDangNhap()
        {
            InitializeComponent();
            btnHidePass.Image = imageList2.Images[0];
            txtMatKhau.UseSystemPasswordChar = true;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 4)
            {
                imgSlide.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                btnHidePass.Image = imageList2.Images[0];
                txtMatKhau.UseSystemPasswordChar = false;
                isHide = true;
            }
            else
            {
                btnHidePass.Image = imageList2.Images[1];
                txtMatKhau.UseSystemPasswordChar = true;
                isHide = false;
            }
        }
    }
}
