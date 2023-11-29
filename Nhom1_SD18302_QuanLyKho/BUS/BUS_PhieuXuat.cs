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
    public class BUS_PhieuXuat
    {
        DAL_PhieuXuat DAL_PX = new DAL_PhieuXuat();
        public DataTable get_PhieuXuat()
        {
            return DAL_PX.get_PhieuXuat();
        }
        public DataTable get_maHang()
        {
            return DAL_PX.get_maHang();
        }
        public DataTable get_MaND()
        {
            return DAL_PX.get_maND();
        }
        public DataTable get_loc_Hang()
        {
            return DAL_PX.loc_phieuXuat();
        }
        public DataTable get_loc_tenHang()
        {
            return DAL_PX.loc_phieuXuatTH();
        }
        public DataTable tim_phieuXuat(string ten_PX)
        {
            return DAL_PX.tim_PhieuXuat(ten_PX);
        }
        public bool them_PX(DTO_PhieuXuat phieuXuat)
        {
            return DAL_PX.them_PhieuXuat(phieuXuat);
        }
        public bool them_CTPX(DTO_PhieuXuat CTphieuXuat)
        {
            return DAL_PX.them_ChiTietPhieuXuat(CTphieuXuat);
        }
        public DataTable get_mapx()
        {
            return DAL_PX.get_maPX();
        }
        public DataTable get_soLuong(string maPX, string maHang)
        {
            return DAL_PX.getSoLuong(maPX,maHang);
        }
        public bool sua_soLuong(DTO_PhieuXuat phieuXuat)
        {
            return DAL_PX.sua_soLuong(phieuXuat);
        }
        public bool sua_phieuXuat(DTO_PhieuXuat phieuXuat)
        {
            return DAL_PX.sua_phieuXuat(phieuXuat);
        }
        public bool sua_chiTietPhieuXuat(DTO_PhieuXuat phieuXuat)
        {
            return DAL_PX.sua_chiTietphieuXuat(phieuXuat);
        }
        public bool xoa_full(string maPXuat)
        {
            return DAL_PX.xoa_full(maPXuat);
        }
        public bool xoa_px(string maPXuat)
        {
            return DAL_PX.xoa_px(maPXuat);
        }
        public bool xoa_ctpx(string maHangg,string mapxx)
        {
            return DAL_PX.xoa_ctpx(maHangg,mapxx);
        }

    }
}
