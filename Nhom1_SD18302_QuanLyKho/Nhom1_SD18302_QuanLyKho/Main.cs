using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmMain : Form
    {
        frmNhanVien frmNhanVien;
        public frmMain()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true;
        bool menuExpand = false;

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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
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
                    pnHoadon.Width = pnSidebar.Width;
                    pnKhachhang.Width = pnSidebar.Width;
                    pnDangxuat.Width = pnSidebar.Width;
                    pnNhacungcap.Width = pnSidebar.Width;
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
                    pnHoadon.Width = pnSidebar.Width;
                    pnKhachhang.Width = pnSidebar.Width;
                    pnDangxuat.Width = pnSidebar.Width;
                    pnNhacungcap.Width = pnSidebar.Width;
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
    }
}