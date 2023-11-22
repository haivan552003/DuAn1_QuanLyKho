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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();

        public DataTable getKhachHang()
        {
            return dalKH.getKH();
        }

        public DataTable getNguoiDung()
        {
            return dalKH.getND();
        }

        public bool insertKH(DTO_KhachHang nv)
        {
            return dalKH.insertKH(nv);
        }

        public bool updateKH(DTO_KhachHang nv)
        {
            return dalKH.updateKH(nv);
        }
        public bool deleteKH(string maKH)
        {
            return dalKH.deleteKH(maKH);
        }
        public DataTable SeachKH(string maKH)
        {
            return dalKH.SeachKH(maKH);
        }
        public DataTable LocAZ()
        {
            return dalKH.LocAZ();
        }
        public DataTable LocZA()
        {
            return dalKH.LocZA();
        }
    }
}
