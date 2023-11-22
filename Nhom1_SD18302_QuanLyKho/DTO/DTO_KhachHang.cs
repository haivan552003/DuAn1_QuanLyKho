using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string maKH;
        private string tenKH;
        private string diaChi;
        private string soDienThoai;
        private string maNV;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public DTO_KhachHang(string maKH, string tenKH, string diaChi, string soDienThoai, string maNV)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.maNV = maNV;
        }

        public DTO_KhachHang(string tenKH, string diaChi, string soDienThoai, string maNV)
        {
            this.tenKH = tenKH;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.maNV = maNV;
        }

        public DTO_KhachHang()
        {
        }
    }
}
