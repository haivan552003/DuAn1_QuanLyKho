using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string tenNV;
        private int tuoi;
        private string gioiTinh;
        private string email;
        private string soDienThoai;
        private string matKhau;
        private int idChucVu;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public int IdChucVu
        {
            get { return idChucVu; }
            set { idChucVu = value; }
        }

        public DTO_NhanVien(string tenNV, int tuoi, string gioiTinh, string email, string soDienThoai, string matKhau, int idChucVu)
        {
            this.tenNV = tenNV;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.matKhau = matKhau;
            this.idChucVu = idChucVu;
        }

        public DTO_NhanVien(string tenNV, int tuoi, string gioiTinh, string soDienThoai, int idChucVu)
        {
            this.tenNV = tenNV;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.idChucVu = idChucVu;
        }

        public DTO_NhanVien(string tenNV, int tuoi, string gioiTinh, string soDienThoai, string matKhau, int idChucVu)
        {
            this.tenNV = tenNV;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.matKhau = matKhau;
            this.idChucVu = idChucVu;
        }
        public DTO_NhanVien() { }
    }
}
