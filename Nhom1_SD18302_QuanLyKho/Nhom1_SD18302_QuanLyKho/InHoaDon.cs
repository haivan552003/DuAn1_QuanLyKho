using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmInHoaDon : Form
    {
        BUS_HoaDon busHD = new BUS_HoaDon();

        public string date, tenKH, sdt, diaChi, thanhTien, maHD;
        private Bitmap memoryImg;

        public frmInHoaDon()
        {
            InitializeComponent();
            date = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            lblNgay.Text = date;
            lblMaHD.Text = maHD;
            lblTen.Text = tenKH;
            lblDiaChi.Text = diaChi;
            lblSDT.Text = sdt;

            dvThongTin.DataSource = busHD.in_hd(maHD);
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);//ten printdoccument
            printPreviewDialog1.ShowDialog();
        }
        private void GetPrintArea(Panel pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            int marginLeft = (pageArea.Width - panel1.Width) / 2; 
            int marginTop = (pageArea.Height - panel1.Height) / 2;

            e.Graphics.DrawImage(memoryImg, marginLeft, marginTop, panel1.Width, panel1.Height);
        }

        private void btnIn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnIn, "Print");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }
    }
}
