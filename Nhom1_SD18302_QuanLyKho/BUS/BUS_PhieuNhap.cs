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
    public class BUS_PhieuNhap
    {
        DAL_PhieuNhap dalPhieuNhap = new DAL_PhieuNhap();
        public DataTable getLayMaNhaCungCap()
        {
            return dalPhieuNhap.getLayMaNhaCungCap();
        }
        public DataTable getDonGia(string maHang)
        {
            return dalPhieuNhap.getDonGia(maHang);
        }
        public DataTable getLayMaNguoiDung()
        {
            return dalPhieuNhap.getLayMaNguoiDung();
        }
        public DataTable getLayMaHang()
        {
            return dalPhieuNhap.getLayMaHang();
        }
        public DataTable getLayMaPhieuNhap()
        {
            return dalPhieuNhap.getLayMaPhieuNhap();
        }
        public DataTable getPhieuNhap()
        {
            return dalPhieuNhap.getPhieuNhap();
        }
        public DataTable getSoLuong(string maPN,string maHang)
        {
            return dalPhieuNhap.getSoLuongPhieuNhap(maPN,maHang);
        }

        public bool insertSoLuongSp(DTO_PhieuNhap ctpn_soLuong)
        {
            return dalPhieuNhap.themSoLuong(ctpn_soLuong);
        }
        public bool insertSoLuongSpLan2(DTO_PhieuNhap ctpn_soLuong)
        {
            return dalPhieuNhap.themSoLuongLan2(ctpn_soLuong);
        }

        public bool insertPhieuNhap(DTO_PhieuNhap PN)
        {
            return dalPhieuNhap.insertPhieuNhap(PN);
        }
        public bool insertChiTietPhieuNhap(DTO_PhieuNhap CTPN)
        {
            return dalPhieuNhap.insertChiTietPhieuNhap(CTPN);
        }
        public bool updatePhieuNhap(DTO_PhieuNhap PN)
        {
            return dalPhieuNhap.UpdatePhieuNhap(PN);
        }
        public bool updateChiTietPhieuNhap(DTO_PhieuNhap CTPN)
        {
            return dalPhieuNhap.insertChiTietPhieuNhap1(CTPN);
        }
        public bool deleteCTPN(string maHang, string maPN)
        {
            return dalPhieuNhap.DeleteCTPN(maHang, maPN);
        }
        public bool deletePN(string maPN)
        {
            return dalPhieuNhap.DeletePN(maPN);
        }
        public bool deletefullCTPN(string maPN )
        {
            return dalPhieuNhap.DeletefullPN(maPN);
        }
        public DataTable searchPhieuNhap(string TenND)
        {
            return dalPhieuNhap.SearchPhieuNhap(TenND);
        }
        public DataTable LocHang()
        {
            return dalPhieuNhap.LocHang();
        }
        public DataTable LocNhaCungCap()
        {
            return dalPhieuNhap.LocNhaCungCapg();
        }
        public DataTable LocNguoiDung()
        {
            return dalPhieuNhap.LocNguoiDung();
        }
    }
}
