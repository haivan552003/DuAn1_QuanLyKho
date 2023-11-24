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

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmDoanhThu : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        public void LoadDT()
        {
            dvThongTin.DataSource = busNV.getDoanhThu();

        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            LoadDT();
        }
    }
}
