using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmNhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();

        }

        private void LoadNV()
        {
            dvThongTin.DataSource = busNV.getNhanVien();

        }
        public bool IsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();

        }

        private void btn_themPX_Click(object sender, EventArgs e)
        {
            string phai = "Nam";
            if (ckNu.Checked == true)
                phai = "Nữ";

            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email chưa hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }
            else if (cboChucvu.SelectedIndex == null)
            {
                MessageBox.Show("chưa nhập chức vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }
            else if (txtMatKhau.Text.Trim().Length > 3 && txtMatKhau.Text.Trim().Length > 10)
            {
                MessageBox.Show("Độ dài tối thiểu 3, tối đa 10 của mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }

            else if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }

            else if (txtTuoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }
            else if (txtTuoi.Text.Trim().Length > 1 && txtTuoi.Text.Trim().Length >= 70)
            {
                MessageBox.Show("Nhập tuổi > 1 và  >= 70", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }
            else if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl.Focus();
                return;
            }
            
            else
            {
                string encryptPass = busNV.Encrypt(txtMatKhau.Text);
                DTO_NhanVien nv = new DTO_NhanVien(txtTen.Text, Convert.ToInt32(txtTuoi.Text), phai, txtEmail.Text, txtSDT.Text,
                                                   encryptPass, cboChucvu.SelectedIndex + 1);
                if (!busNV.insertNV(nv))
                {
                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadNV();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_capnhatPX_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập họ tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            string phai = "Nam";
            if (ckNu.Checked == true)
                phai = "Nữ";

            DTO_NhanVien nv = new DTO_NhanVien(txtTen.Text, Convert.ToInt32(txtTuoi.Text), phai, txtEmail.Text, txtSDT.Text,
                                                     cboChucvu.SelectedIndex + 1);
            if (MessageBox.Show("Bạn có muốn chỉnh sửa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!busNV.updateNV(nv))
                {
                    MessageBox.Show("Sửa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadNV();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void dvThongTin_Click(object sender, EventArgs e)
        {
            if (dvThongTin.Rows.Count > 1)
            {


                int lst = dvThongTin.CurrentRow.Index;
                txtMaND.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
                txtTen.Text = dvThongTin.Rows[lst].Cells[1].Value.ToString();
                txtTuoi.Text = dvThongTin.Rows[lst].Cells[2].Value.ToString();
                string phai = dvThongTin.Rows[lst].Cells[3].Value.ToString();
                txtEmail.Text = dvThongTin.Rows[lst].Cells[4].Value.ToString();
                txtSDT.Text = dvThongTin.Rows[lst].Cells[5].Value.ToString();
                txtMatKhau.Text = dvThongTin.Rows[lst].Cells[6].Value.ToString();
                cboChucvu.SelectedItem = dvThongTin.Rows[lst].Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoaPX_Click(object sender, EventArgs e)
        {
            string mand = txtMaND.Text;

            if (MessageBox.Show("Bạn có muốn xóa?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!busNV.deleteNV(mand))
                {
                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadNV();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenNV = txtTimKiem.Text;
            DataTable dt = busNV.SeachNV(tenNV);

            if (dt.Rows.Count > 0)
            {
                dvThongTin.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSapXep.SelectedItem == "A - Z")
            {
                dvThongTin.DataSource = busNV.LocAZ();
            }
            else if (cboSapXep.SelectedItem == "Z - A")
            {
                dvThongTin.DataSource = busNV.LocZA();
            }
            else
            {
                dvThongTin.DataSource = busNV.LocCV();
            }
        }
    }
}


