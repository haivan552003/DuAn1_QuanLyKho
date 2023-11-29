using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuNhap
    {
        private string maPhieuNhap;
        private string ngayNhap;
        private float tamUng;
        private float thanhToan;
        private string maNCC;
        private string maND;
        public string maHang;
        public int soLuong;
        public float donGia;
        public float thanhTien;

        public string NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public float TamUng
        {
            get { return tamUng;}
            set { tamUng = value; }
        }
        public float ThanhToan
        {
            get { return thanhToan; }
            set { thanhToan = value;}
        } 
        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string MaND
        {
            get { return maND; }
            set { maND = value; }
        }
        public string MaPhieuNhap
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }
        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        //dto phieu nhap
        public DTO_PhieuNhap(string ngayNhap, float tamUng, float thanhToan, string maNCC, string maND)
        {
            this.ngayNhap = ngayNhap;
            this.tamUng = tamUng;
            this.thanhToan = thanhToan;
            this.maNCC = maNCC;
            this.maND = maND;
        }

        public DTO_PhieuNhap(string maPhieuNhap,string ngayNhap, float tamUng, float thanhToan, string maNCC, string maND)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.ngayNhap = ngayNhap;
            this.tamUng = tamUng;
            this.thanhToan = thanhToan;
            this.maNCC = maNCC;
            this.maND = maND;
        }


        // dto chi tiet phieu nhap
        public DTO_PhieuNhap(string maPhieuNhap, string maHang, int soLuong, float donGia, float thanhTien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maHang = maHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }
        public DTO_PhieuNhap(string maPhieuNhap, string maHang, int soLuong, float thanhTien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maHang = maHang;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
        }

        public DTO_PhieuNhap()
        {

        }
    }
}
