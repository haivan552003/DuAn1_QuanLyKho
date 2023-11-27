using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHD = new DAL_HoaDon();

        public DataTable getHoaDon()
        {
            return dalHD.getHD();
        }

        public DataTable getDonGia(string maHang)
        {
            return dalHD.getDonGia(maHang);
        }
        public DataTable getSoLuongSP(string maHD, string maHang)
        {
            return dalHD.getSoLuongSP(maHD, maHang);
        }

        public DataTable getHangHoa()
        {
            return dalHD.getHH();
        }
        public DataTable getKhachHang()
        {
            return dalHD.getKH();
        }
        public DataTable getNguoiDung()
        {
            return dalHD.getND();
        }
        public DataTable getMaHD()
        {
            return dalHD.getMaHD();
        }
        public bool insertHD(DTO_HoaDon hoadon)
        {
            return dalHD.insertHD(hoadon);
        }
        public bool insertCTHD(DTO_HoaDon hoadon)
        {
            return dalHD.insertCTHD(hoadon);
        }
        public bool insertSoLuongSP(DTO_HoaDon hoadon)
        {
            return dalHD.insertSoLuongSP(hoadon);
        }
        public bool updateHoaDon(DTO_HoaDon hoadon)
        {
            return dalHD.updateHoaDon(hoadon);
        }
        public bool deleteCTHD(string maHD, string maHang)
        {
            return dalHD.deleteCTHD(maHD, maHang);
        }
        public bool delete_full_CTHD(string maHD)
        {
            return dalHD.delete_full_CTHD(maHD);
        }
        public bool deleteHD(string maHD)
        {
            return dalHD.deleteHD(maHD);
        }
        public DataTable SeachHD(string maHD)
        {
            return dalHD.SeachHD(maHD);
        }
        public DataTable loc_hd_a_z()
        {
            return dalHD.loc_hd_a_z();
        }
        public DataTable loc_hd_z_a()
        {
            return dalHD.loc_hd_z_a();
        }
        public DataTable in_hd(string maHD)
        {
            return dalHD.in_hd(maHD);
        }
        public DataTable getThongTinKH(string maHD)
        {
            return dalHD.getThongTinKH(maHD);
        }
    }
}
