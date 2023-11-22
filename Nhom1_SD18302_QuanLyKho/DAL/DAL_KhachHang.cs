using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable getKH()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[load_khach_hang]";
                cmd.Connection = _conn;
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());

                return dtNhanVien;
            }
            finally { _conn.Close(); }
        }

        public DataTable getND()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[combobox_kh]";
                cmd.Connection = _conn;
                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());

                return dtNhanVien;
            }
            finally { _conn.Close(); }
        }

        public bool insertKH(DTO_KhachHang khachHang)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_khach_hang]";
                cmd.Parameters.AddWithValue("@tenkhachhang", khachHang.TenKH);
                cmd.Parameters.AddWithValue("@diachi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@soDienThoai", khachHang.SoDienThoai);
                cmd.Parameters.AddWithValue("@maND", khachHang.MaNV);

                if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                {
                    return false;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                _conn.Close();
            }
            return true;
        }

        public bool updateKH(DTO_KhachHang khachHang)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_khach_hang]";
                cmd.Parameters.AddWithValue("@makhachhang", khachHang.MaKH);
                cmd.Parameters.AddWithValue("@tenkhachhang", khachHang.TenKH);
                cmd.Parameters.AddWithValue("@diachi", khachHang.DiaChi);
                cmd.Parameters.AddWithValue("@soDienThoai", khachHang.SoDienThoai);
                cmd.Parameters.AddWithValue("@maND", khachHang.MaNV);

                if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                {
                    return false;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                _conn.Close();
            }
            return true;
        }

        public bool deleteKH(string maKH)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_khach_hang]";
                cmd.Parameters.AddWithValue("@maNd", maKH);

                if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                {
                    return false;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }
            return true;
        }

        public DataTable SeachKH(string maKH)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tim_khach_hang]";
                cmd.Parameters.AddWithValue("@ten_nd", maKH);
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable LocAZ()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_khach_hang_a_z]";
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable LocZA()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_khach_hang_z_a]";
                cmd.Connection = _conn;
                DataTable dtNV = new DataTable();
                dtNV.Load(cmd.ExecuteReader());
                return dtNV;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
