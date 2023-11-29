using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuXuat
    {
        private string maPhieuXuat;
        private int soLuong;
        private string ngayXuat;
        private string maHang;
        private string maND;

        public string MaPhieuXuat 
        {
            get {  return maPhieuXuat; }
            set {  maPhieuXuat = value;}
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value;}
        }
        public string NgayXuat
        {
            get { return ngayXuat; }
            set { ngayXuat = value; }
        }
        public string MaHang 
        { get { return maHang; } 
          set { maHang = value;} 
        }
        public string MaND
        {
            get { return maND; }
            set { maND = value; }
        }
        public DTO_PhieuXuat(string MaHang,string MaPhieuXuat, int SoLuong)
        {       
            this.maHang= MaHang;
            this.maPhieuXuat = MaPhieuXuat;
            this.soLuong = SoLuong;
        }
        public DTO_PhieuXuat( string NgayXuat, string MaND)
        {
            this.ngayXuat = NgayXuat;
            this.maND = MaND;
        }
        public DTO_PhieuXuat( string MaPhieuXuat, string MaHang, int SoLuong, string NgayXuat, string MaND)
        {
            this.maPhieuXuat = MaPhieuXuat;
            this.maHang = MaHang;
            this.soLuong = SoLuong;
            this.ngayXuat = NgayXuat;
            this.maND = MaND;
        }
        public DTO_PhieuXuat(string MaPhieuXuat)
        {
            this.maPhieuXuat= MaPhieuXuat;
        }
        public DTO_PhieuXuat (string MaPhieuXuat ,string NgayXuat,string MaND)
        {
            this.maPhieuXuat = MaPhieuXuat;
            this.ngayXuat= NgayXuat;
            this.maND = MaND;
        }
        

        public DTO_PhieuXuat()
        {

        }
    }
}
