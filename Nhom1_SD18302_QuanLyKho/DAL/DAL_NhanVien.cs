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
    public class DAL_NhanVien : DBConnect
    {
        public bool NhanVienDangNhap(string email, string password)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("MatKhau", password);

                if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }

        public DataTable getNV()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[load_nguoi_dung]";
                cmd.Connection = _conn;
                DataTable Nhanvien = new DataTable();
                Nhanvien.Load(cmd.ExecuteReader());

                return Nhanvien;
            }
            finally { _conn.Close(); }
        }
        public DataTable VaiTroNhanVien(string email)
        {
            DataTable dataTable = new DataTable();
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayChucVuNV]";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Connection = _conn;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            finally { _conn.Close(); }
            return dataTable;
        }
        public bool insertNV(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_nguoi_dung]";
                cmd.Parameters.AddWithValue("tenNd", nv.TenNV);
                cmd.Parameters.AddWithValue("tuoi", nv.Tuoi);
                cmd.Parameters.AddWithValue("gioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("soDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("matKhau", nv.MatKhau);
                cmd.Parameters.AddWithValue("idChucVu ", nv.IdChucVu);

                if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                {
                    return true;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool updateNV(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_nguoi_dung]";
                cmd.Parameters.AddWithValue("tenNd", nv.TenNV);
                cmd.Parameters.AddWithValue("tuoi", nv.Tuoi);
                cmd.Parameters.AddWithValue("gioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("soDienThoai", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("idChucVu ", nv.IdChucVu);

                if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                {
                    return true;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable getDT()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[thu_chi]";
                cmd.Connection = _conn;
                DataTable Nhanvien = new DataTable();
                Nhanvien.Load(cmd.ExecuteReader());

                return Nhanvien;
            }
            finally
            { 
                _conn.Close(); 
            }
        }
        public bool deleteNV(string mand)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_nguoi_dung]";
                cmd.Parameters.AddWithValue("maNd", mand);

                if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                {
                    return true;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable SeachNV(string tenNV)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tim_nguoi_dung]";
                cmd.Parameters.AddWithValue("ten_nd", tenNV);
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
            public bool UpdateMatKhau(string email, string matKhauCu, string matKhauMoi, string nhapLaimatKhauMoi)
            {
                try
                {
                    _conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[chgpwd]";
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("@oPwd", matKhauCu);
                    cmd.Parameters.AddWithValue("@nPwd", matKhauMoi);
                    cmd.Parameters.AddWithValue("@re_nPwd", nhapLaimatKhauMoi);

                    if ((Convert.ToInt16(cmd.ExecuteScalar()) > 0))
                    {
                        return false;
                    }
                }
                catch (Exception ex) { }
                finally { _conn.Close(); }

                return true;
            }
        public DataTable locAZ()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_nguoi_dung_a_z]";
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
        public DataTable locZA()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_nguoi_dung_z_a]";
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
        public DataTable locCV()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_nguoi_dung_chuc_vu]";
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