using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Hang
    {
        DAL_HangHoa DALHangHoa = new DAL_HangHoa();

        public DataTable getHangHoa()
        {
            return DALHangHoa.getHangHoa();
        }
        public bool themHangHoa(DTO_HangHoa hangHoa)
        {
            return DALHangHoa.themHangHoa(hangHoa);
        }
        public DataTable get_tenHang()
        {
            return DALHangHoa.get_TenHang();
        }
        public DataTable get_dongia()
        {
            return DALHangHoa.get_DonGia();
        }
        public DataTable get_maKho() 
        {
            return DALHangHoa.get_maKho();
        }
        public DataTable get_maDanhMuc()
        {
            return DALHangHoa.get_maDanhMuc();
        }
        public DataTable get_maND()
        {
            return DALHangHoa.get_maNguoiDung();
        }
        public bool sua_hangHoa(DTO_HangHoa hangHoa)
        {
            return DALHangHoa.sua_hangHoa(hangHoa);
        }
        public bool xoa_hangHoa(string maHang)
        {
            return DALHangHoa.xoa_hangHoa(maHang);
        }
        public DataTable tim_hangHoa(string ten_hangHoa)
        {
            return DALHangHoa.tim_HangHoa(ten_hangHoa);
        }
        public DataTable locAZ()
        {
            return DALHangHoa.locAZ();
        }
        public DataTable locZA()
        {
            return DALHangHoa.locZA();
        }


    }
}
