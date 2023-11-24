using BUS;
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
    public partial class frmDoiMatKhau : Form
    {
        string strEmail;
        BUS_NhanVien busNV = new BUS.BUS_NhanVien();
        public frmDoiMatKhau(string email)
        {
            InitializeComponent();
            strEmail = email;
            txtTenTaiKhoan.Text = strEmail;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            BUS_NhanVien busNV = new BUS.BUS_NhanVien();
            if (txtMatKhauCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            else if (txtMatKhauMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            else if (txtNhapLaiMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            else if (txtNhapLaiMatKhau.Text.Trim().Length != txtMatKhauMoi.Text.Trim().Length)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn cập nhật mật khẩu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != 0)
                {
                    string matkhaumoi = busNV.Encrypt(txtMatKhauMoi.Text);
                    string matkhaucu = busNV.Encrypt(txtMatKhauCu.Text);
                    string nhapLaimatKhauMoi = busNV.Encrypt(txtNhapLaiMatKhau.Text);

                    //string matkhaumoi = txtMKMoi.Text;
                    //string matkhaucu = txtMKCu.Text;
                    //string nhapLaimatKhauMoi = txtNhapLaiMKMoi.Text;


                    if (busNV.UpdateMatKhau(txtTenTaiKhoan.Text, matkhaucu, matkhaumoi, nhapLaimatKhauMoi))
                    {
                        //frmMain.profile = 1;
                        //frmMain.session = 0;
                        MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng, vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhauCu.Text = null;
                        txtMatKhauMoi.Text = null;
                        txtNhapLaiMatKhau.Text = null;
                    }
                }
                else
                {
                    txtMatKhauCu.Text = null;
                    txtMatKhauMoi.Text = null;
                    txtNhapLaiMatKhau.Text = null;
                }
            }
        }
    }
}
