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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dalNhaCungCap =  new DAL_NhaCungCap();

        public DataTable getNguoiDung()
        {
            return dalNhaCungCap.GetNguoiDung();
        }

        public DataTable getNhaCungCap()
        {
            return dalNhaCungCap.getNhaCungCap();
        }
        public bool insertNhaCungCap(DTO_NhaCungCap NCC)
        {
            return dalNhaCungCap.insertNCC(NCC);
        }
        public bool updateNhaCungCap(DTO_NhaCungCap NCC)
        {
            return dalNhaCungCap.UpdateNCC(NCC);
        }
        public bool deleteNhaCungCap(string MaNCC)
        {
            return dalNhaCungCap.DeleteNCC(MaNCC) ;
        }
        public DataTable searchNhaCungCap(string TenNCC)
        {
            return dalNhaCungCap.SearchNCC(TenNCC);
        }
        public DataTable LocNhaCungCapA_Z()
        {
            return dalNhaCungCap.LocA_Z();
        }
        public DataTable LocNhaCungCapZ_A()
        {
            return dalNhaCungCap.LocZ_A();
        }
    }
}
