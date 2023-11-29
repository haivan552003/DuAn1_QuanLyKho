using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HangHoa
    {
        private string maHang;
        private string tenHang;
        private float donGia;
        private string maDanhMuc;
        private string hangSuDung;
        private string ghiChu;
        private string anh;
        private string maNguoiDung;
        private string maKho;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public string MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }
        public string HangSuDung
        {
            get { return hangSuDung;}
            set { hangSuDung = value;}
        }
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        public string MaNguoiDung
        {
            get { return maNguoiDung;}
            set {  maNguoiDung = value; }
        }
        public string MaKho
        {
            get { return maKho; }
            set { maKho = value; }
        }
        
        public DTO_HangHoa(string TenHang, float DonGia, string HangSuDung, string GhiChu, string Anh, string MaDanhMuc, string MaNguoiDung ,string MaKho)
        {
            this.tenHang = TenHang;
            this.donGia = DonGia;
            this.hangSuDung = HangSuDung;
            this.ghiChu = GhiChu;
            this.anh = Anh;
            this.maDanhMuc = MaDanhMuc;
            this.maNguoiDung = MaNguoiDung;
            this.maKho = MaKho;
        }
        public DTO_HangHoa() 
        {

        }
    }
}
