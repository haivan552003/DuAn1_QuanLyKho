using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 public class DTO_NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string soDienThoai;
        private string maND;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string MaND
        {
            get { return maND; }
            set { maND = value; }
        }



        public DTO_NhaCungCap(string maNCC, string tenNCC, string diaChi, string soDienThoai, string maND)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.maND = maND;
        }

        //public DTO_NhaCungCap(string tenNCC, string diaChi,  string soDienThoai, string maND)
        //{
        //    this.tenNCC = tenNCC;
        //    this.diaChi = diaChi;
        //    this.soDienThoai = soDienThoai;
        //    this.maND = maND;
        //}

        public DTO_NhaCungCap() { }
    }
}
