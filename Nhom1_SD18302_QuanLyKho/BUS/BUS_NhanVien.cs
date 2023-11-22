using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        public bool NhanVienDangNhap(string email, string password)
        {
            return dalNV.NhanVienDangNhap(email, password);
        }

        public string Encrypt(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2")); // Đảm bảo luôn là 2 ký tự hex
                }

                return sb.ToString();
            }
        }

        public DataTable VaiTroNhanVien(string email)
        {
            return dalNV.VaiTroNhanVien(email);
        }
    }


}
