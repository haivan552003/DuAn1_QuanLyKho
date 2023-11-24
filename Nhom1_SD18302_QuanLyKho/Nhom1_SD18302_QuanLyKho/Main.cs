using BUS;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmMain : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public static int profile = 0; //doi mat khau thanh cong/that bai
        public static string mail; //truyen email

        public string email { set; get; }

        frmNhanVien frmNhanVien;
        frmKhachHang frmKhachHang;
        frmNhaCungCap frmNhaCungCap;
        frmThuChi frmThuChi;
        frmDoanhThu frmDoanhThu;
        frmHangHoa frmHangHoa;
        frmHoaDon frmHoaDon;
        frmPhieuNhap frmPhieuNhap;
        frmPhieuXuat frmPhieuXuat;
        public frmMain()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true;
        bool menuExpand = false;
        bool phieuExpand = false;

        private void VaiTroNV()
        {
            pnNhanvien.Hide();
            pnMenuMini.Hide();
        }

        private void VaiTroKT()
        {
            pnNhanvien.Hide();
            pnKhachhang.Hide();
        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ResetValue()
        {
            DataTable dtVaiTro = busNV.VaiTroNhanVien(frmMain.mail);

            lblTenND.Text = "Chào, " + frmMain.mail;

            string vaitro = dtVaiTro.Rows[0][0].ToString();
            if (Convert.ToInt32(vaitro) == 2)
            {
                VaiTroKT();

            }
            else if (Convert.ToInt32(vaitro) == 3)
            {
                VaiTroNV();
            }
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                // set menu khi thu nho
                pnMenuMini.Height += 15;

                //set menu ve height >= height luc thiet ke(menu lon)
                if (pnMenuMini.Height >= 120)
                {

                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                pnMenuMini.Height -= 15;

                //set menu ve height <= height luc thiet ke(menu nho)
                if (pnMenuMini.Height <= 40)
                {

                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void phieuTransition_Tick(object sender, EventArgs e)
        {
            if (phieuExpand == false)
            {
                // set menu khi thu nho
                pnPhieu.Height += 15;

                //set menu ve height >= height luc thiet ke(menu lon)
                if (pnPhieu.Height >= 168)
                {
                    pnDangxuat.Hide();
                    phieuTransition.Stop();
                    phieuExpand = true;
                }
            }
            else
            {
                pnPhieu.Height -= 15;

                //set menu ve height <= height luc thiet ke(menu nho)
                if (pnPhieu.Height <= 40)
                {
                    pnDangxuat.Show();
                    phieuTransition.Stop();
                    phieuExpand = false;
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnPhieu_Click(object sender, EventArgs e)
        {
            phieuTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //toc do dong mo sidebar
                pnSidebar.Width -= 10;

                //sidebar thu nho
                if (pnSidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnNguoiDung.Hide();

                    pnTrangChu.Width = pnSidebar.Width;
                    pnNhanvien.Width = pnSidebar.Width;
                    pnMenuMini.Width = pnSidebar.Width;
                    pnPhieu.Width = pnSidebar.Width;
                    pnKhachhang.Width = pnSidebar.Width;
                    pnDangxuat.Width = pnSidebar.Width;
                    pnNhacungcap.Width = pnSidebar.Width;
                    pnDanhMucSanpham.Width = pnSidebar.Width;
                }
            }
            else
            {
                pnSidebar.Width += 10;

                if (pnSidebar.Width >= 180)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnNguoiDung.Show();
                    pnTrangChu.Width = pnSidebar.Width;
                    pnNhanvien.Width = pnSidebar.Width;
                    pnMenuMini.Width = pnSidebar.Width;
                    pnPhieu.Width = pnSidebar.Width;
                    pnKhachhang.Width = pnSidebar.Width;
                    pnDangxuat.Width = pnSidebar.Width;
                    pnNhacungcap.Width = pnSidebar.Width;
                    pnDanhMucSanpham.Width = pnSidebar.Width;
                }
            }
        }


        private void imgMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

            if (frmNhanVien == null)
            {
                frmNhanVien = new frmNhanVien();
                frmNhanVien.FormClosed += FrmNhanVien_FormClosed;
                frmNhanVien.MdiParent = this;
                frmNhanVien.Dock = DockStyle.Fill;
                frmNhanVien.Show();
            }
            else
            {
                frmNhanVien.Activate();
            }
        }

        private void FrmNhanVien_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmNhanVien = null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnDanhMucSP_Click(object sender, EventArgs e)
        {
            if (frmHangHoa == null)
            {
                frmHangHoa = new frmHangHoa();
                frmHangHoa.FormClosed += FrmHangHoa_FormClosed;
                frmHangHoa.MdiParent = this;
                frmHangHoa.Dock = DockStyle.Fill;
                frmHangHoa.Show();
            }
            else
            {
                frmHangHoa.Activate();
            }
        }

        private void FrmHangHoa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmHangHoa = null;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (frmKhachHang == null)
            {
                frmKhachHang = new frmKhachHang();
                frmKhachHang.FormClosed += FrmKhachHang_FormClosed;
                frmKhachHang.MdiParent = this;
                frmKhachHang.Dock = DockStyle.Fill;
                frmKhachHang.Show();
            }
            else
            {
                frmKhachHang.Activate();
            }
        }

        private void FrmKhachHang_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmKhachHang = null;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (frmNhaCungCap == null)
            {
                frmNhaCungCap = new frmNhaCungCap();
                frmNhaCungCap.FormClosed += FrmNhaCungCap_FormClosed;
                frmNhaCungCap.MdiParent = this;
                frmNhaCungCap.Dock = DockStyle.Fill;
                frmNhaCungCap.Show();
            }
            else
            {
                frmNhaCungCap.Activate();
            }
        }

        private void FrmNhaCungCap_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmNhaCungCap = null;
        }


        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (frmDoanhThu == null)
            {
                frmDoanhThu = new frmDoanhThu();
                frmDoanhThu.FormClosed += FrmDoanhThu_FormClosed;
                frmDoanhThu.MdiParent = this;
                frmDoanhThu.Dock = DockStyle.Fill;
                frmDoanhThu.Show();
            }
            else
            {
                frmDoanhThu.Activate();
            }
        }

        private void FrmDoanhThu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmDoanhThu = null;
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            if (frmThuChi == null)
            {
                frmThuChi = new frmThuChi();
                frmThuChi.FormClosed += FrmThuChi_FormClosed;
                frmThuChi.MdiParent = this;
                frmThuChi.Dock = DockStyle.Fill;
                frmThuChi.Show();
            }
            else
            {
                frmThuChi.Activate();
            }
        }

        private void FrmThuChi_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmDoanhThu = null;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (frmHangHoa != null)
            {
                frmHangHoa.Close();

            }
            if (frmDoanhThu != null)
            {
                frmDoanhThu.Close();

            }
            if (frmThuChi != null)
            {
                frmThuChi.Close();
            }
            if (frmNhanVien != null)
            {
                frmNhanVien.Close();
            }
            if (frmNhaCungCap != null)
            {
                frmNhaCungCap.Close();

            }
            if (frmPhieuNhap != null)
            {
                frmPhieuNhap.Close();
            }
            if (frmPhieuXuat != null)
            {
                frmPhieuXuat.Close();
            }
            if (frmHoaDon != null)
            {
                frmHoaDon.Close();
            }
            if (frmKhachHang != null)
            {
                frmKhachHang.Close();
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (frmHoaDon == null)
            {
                frmHoaDon = new frmHoaDon();
                frmHoaDon.FormClosed += FrmHoaDon_FormClosed;
                frmHoaDon.MdiParent = this;
                frmHoaDon.Dock = DockStyle.Fill;
                frmHoaDon.Show();
            }
            else
            {
                frmHoaDon.Activate();
            }
        }

        private void FrmHoaDon_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmHoaDon = null;
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            if (frmPhieuNhap == null)
            {
                frmPhieuNhap = new frmPhieuNhap();
                frmPhieuNhap.FormClosed += FrmPhieuNhap_FormClosed;
                frmPhieuNhap.MdiParent = this;
                frmPhieuNhap.Dock = DockStyle.Fill;
                frmPhieuNhap.Show();
            }
            else
            {
                frmPhieuNhap.Activate();
            }
        }

        private void FrmPhieuNhap_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmPhieuNhap = null;
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            if (frmPhieuXuat == null)
            {
                frmPhieuXuat = new frmPhieuXuat();
                frmPhieuXuat.FormClosed += FrmPhieuXuat_FormClosed;
                frmPhieuXuat.MdiParent = this;
                frmPhieuXuat.Dock = DockStyle.Fill;
                frmPhieuXuat.Show();
            }
            else
            {
                frmPhieuXuat.Activate();
            }
        }

        private void FrmPhieuXuat_FormClosed(object? sender, FormClosedEventArgs e)
        {
            frmPhieuXuat = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}