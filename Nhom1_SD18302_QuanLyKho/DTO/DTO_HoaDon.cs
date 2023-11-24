using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string maHD;
        private string ngayBan;
        private string ngayGiao;
        private float tienCoc;
        private string maND;
        private string maKH;
        private string maSP;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        public string NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        public string NgayGiao
        {
            get { return ngayGiao; }
            set { ngayGiao = value; }
        }
        public float TienCoc
        {
            get { return tienCoc; }
            set { tienCoc = value; }
        }
        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string MaND
        {
            get { return maND; }
            set { maND = value; }
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
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

        //sua hd
        public DTO_HoaDon(string maHD, string ngayBan, string ngayGiao, float tienCoc, string maND, string maKH)
        {
            this.maHD = maHD;
            this.ngayBan = ngayBan;
            this.ngayGiao = ngayGiao;
            this.tienCoc = tienCoc;
            this.maND = maND;
            this.maKH = maKH;
        }
        //them hd
        public DTO_HoaDon(string ngayBan, string ngayGiao, float tienCoc, string maND, string maKH)
        {
            this.ngayBan = ngayBan;
            this.ngayGiao = ngayGiao;
            this.tienCoc = tienCoc;
            this.maND = maND;
            this.maKH = maKH;
        }

        //them, sua cthd
        public DTO_HoaDon(string maHD, string maSP, int soLuong, float donGia, float thanhTien)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        //them so luong san pham
        public DTO_HoaDon(string maHD, string maSP, int soLuong, float thanhTien)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
        }

        //xoa hd
        public DTO_HoaDon() { }
    }
}
