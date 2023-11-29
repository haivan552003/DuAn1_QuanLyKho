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
    public class DAL_HangHoa : DBConnect
    {
        public DataTable getHangHoa()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "loadHangHoa";
                cmd.Connection = _conn;
                DataTable dtHangHoa = new DataTable();
                dtHangHoa.Load(cmd.ExecuteReader());

                return dtHangHoa;
            }
            finally { _conn.Close(); }
        }
        public bool themHangHoa(DTO_HangHoa hangHoa)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemHangHoa";
                cmd.Parameters.AddWithValue("tenHang", hangHoa.TenHang);
                cmd.Parameters.AddWithValue("donGia", hangHoa.DonGia);
                cmd.Parameters.AddWithValue("hanSuDung", hangHoa.HangSuDung);
                cmd.Parameters.AddWithValue("ghiChu", hangHoa.GhiChu);
                cmd.Parameters.AddWithValue("hinhAnh", hangHoa.Anh);
                cmd.Parameters.AddWithValue("maDanhMuc", hangHoa.MaDanhMuc);
                cmd.Parameters.AddWithValue("maND", hangHoa.MaNguoiDung);
                cmd.Parameters.AddWithValue("maKho", hangHoa.MaKho);


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
        public DataTable get_TenHang()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_tenHang";
                cmd.Connection = _conn;
                DataTable dtHangHoa = new DataTable();
                dtHangHoa.Load(cmd.ExecuteReader());

                return dtHangHoa;
            }
            finally { _conn.Close(); }
        }
        public DataTable get_DonGia()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_donGia";
                cmd.Connection = _conn;
                DataTable dtHangHoa = new DataTable();
                dtHangHoa.Load(cmd.ExecuteReader());

                return dtHangHoa;
            }
            finally { _conn.Close(); }
        }
        public DataTable get_maDanhMuc()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_maDanhMuc";
                cmd.Connection = _conn;
                DataTable dtHangHoa = new DataTable();
                dtHangHoa.Load(cmd.ExecuteReader());

                return dtHangHoa;
            }
            finally { _conn.Close(); }
        }
        public DataTable get_maNguoiDung()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_maNguoiDung";
                cmd.Connection = _conn;
                DataTable dtHangHoa = new DataTable();
                dtHangHoa.Load(cmd.ExecuteReader());

                return dtHangHoa;
            }
            finally { _conn.Close(); }
        }
        public DataTable get_maKho()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_maKho";
                cmd.Connection = _conn;
                DataTable dtHangHoa = new DataTable();
                dtHangHoa.Load(cmd.ExecuteReader());

                return dtHangHoa;
            }
            finally { _conn.Close(); }
        }
        public bool sua_hangHoa(DTO_HangHoa hangHoa)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaHangHoa";
                cmd.Parameters.AddWithValue("tenHang", hangHoa.TenHang);
                cmd.Parameters.AddWithValue("donGia", hangHoa.DonGia);
                cmd.Parameters.AddWithValue("hanSuDung", hangHoa.HangSuDung);
                cmd.Parameters.AddWithValue("ghiChu", hangHoa.GhiChu);
                cmd.Parameters.AddWithValue("hinhAnh", hangHoa.Anh);
                cmd.Parameters.AddWithValue("maDanhMuc", hangHoa.MaDanhMuc);
                cmd.Parameters.AddWithValue("maND", hangHoa.MaNguoiDung);
                cmd.Parameters.AddWithValue("maKho", hangHoa.MaKho);
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
        public bool xoa_hangHoa(string maHang)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaHangHoa";
                cmd.Parameters.AddWithValue("maHangHoa", maHang);

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
        public DataTable tim_HangHoa( string ten_hangHoa)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "tim_hang_hoa";
                cmd.Parameters.AddWithValue("tenHangHoa", ten_hangHoa);
                cmd.Connection = _conn;
                DataTable dataHangHoa = new DataTable();
                dataHangHoa.Load(cmd.ExecuteReader());
                return dataHangHoa;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable locAZ()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "locHangHoa_a_z";
                cmd.Connection = _conn;
                DataTable dataHangHoa = new DataTable();
                dataHangHoa.Load(cmd.ExecuteReader());
                return dataHangHoa;
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
                cmd.CommandText = "locHangHoa_z_a";
                cmd.Connection = _conn;
                DataTable dataHangHoa = new DataTable();
                dataHangHoa.Load(cmd.ExecuteReader());
                return dataHangHoa;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
