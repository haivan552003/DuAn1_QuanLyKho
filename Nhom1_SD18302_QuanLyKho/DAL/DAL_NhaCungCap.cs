using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaCungCap : DBConnect
    {
        public DataTable GetNguoiDung()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[combobox_NguoiDung]";
                cmd.Connection = _conn;
                DataTable dtNhaCungCap = new DataTable();
                dtNhaCungCap.Load(cmd.ExecuteReader());
                return dtNhaCungCap;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable getNhaCungCap()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[load_ncc]";
                cmd.Connection = _conn;
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool insertNCC(DTO_NhaCungCap nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_ncc]";
                cmd.Parameters.AddWithValue("ten_ncc", nv.TenNCC);
                cmd.Parameters.AddWithValue("dia_chi", nv.DiaChi);
                cmd.Parameters.AddWithValue("so_dien_thoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("ma_nd", nv.MaND);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool UpdateNCC(DTO_NhaCungCap nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_ncc]";
                cmd.Parameters.AddWithValue("@ma_ncc", nv.MaNCC);
                cmd.Parameters.AddWithValue("@ten_ncc", nv.TenNCC);
                cmd.Parameters.AddWithValue("@dia_chi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@so_dien_thoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@ma_nd", nv.MaND);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeleteNCC(string maNCC)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_nha_cung_cap]";
                cmd.Parameters.AddWithValue("ma_ncc", maNCC);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable SearchNCC(string tenNCC)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tim_nha_cung_cap]";
                cmd.Parameters.AddWithValue("ten_ncc", tenNCC);
                cmd.Connection = _conn;
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable LocA_Z()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_nha_cung_cap_az]";
                cmd.Connection = _conn;
                DataTable dtNCC = new DataTable();
                dtNCC.Load(cmd.ExecuteReader());
                return dtNCC;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable LocZ_A()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_nha_cung_cap_za]";
                cmd.Connection = _conn;
                DataTable dtNCC = new DataTable();
                dtNCC.Load(cmd.ExecuteReader());
                return dtNCC;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
