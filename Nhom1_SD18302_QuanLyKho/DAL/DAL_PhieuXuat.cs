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
    public class DAL_PhieuXuat : DBConnect
    {
        public DataTable get_PhieuXuat()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "loadChiTietPhieuXuat";
                cmd.Connection = _conn;
                DataTable dtPhieuXuat = new DataTable();
                dtPhieuXuat.Load(cmd.ExecuteReader());

                return dtPhieuXuat;
            }
            finally { _conn.Close(); }
        }
        public DataTable get_maHang()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_maHang";
                cmd.Connection = _conn;
                DataTable dtPhieuXuat = new DataTable();
                dtPhieuXuat.Load(cmd.ExecuteReader());

                return dtPhieuXuat;
            }
            finally { _conn.Close(); }
        }
        public DataTable get_maND()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_maND";
                cmd.Connection = _conn;
                DataTable dtPhieuXuat = new DataTable();
                dtPhieuXuat.Load(cmd.ExecuteReader());

                return dtPhieuXuat;
            }
            finally { _conn.Close(); }
        }
        public DataTable tim_PhieuXuat(string ten_PhieuXuat)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "timChiTietPhieuXuat";
                cmd.Parameters.AddWithValue("tenND", ten_PhieuXuat);
                cmd.Connection = _conn;
                DataTable dtPhieuXuat = new DataTable();
                dtPhieuXuat.Load(cmd.ExecuteReader());
                return dtPhieuXuat;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable loc_phieuXuat()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "locChiTietPhieuXuatTheoTen";
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
        public DataTable loc_phieuXuatTH()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "locChiTietPhieuXuatTheoTenHang";
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

        public bool them_PhieuXuat(DTO_PhieuXuat phieuXuat)
       {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "themPhieuXuat";
                cmd.Parameters.AddWithValue("ngayXuat", phieuXuat.NgayXuat);
                cmd.Parameters.AddWithValue("maND", phieuXuat.MaND);
             


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
        public bool sua_phieuXuat(DTO_PhieuXuat phieuXuat)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "suaPhieuXuat";
                cmd.Parameters.AddWithValue("maPhieuXuat", phieuXuat.MaPhieuXuat);
                cmd.Parameters.AddWithValue("ngayXuat", phieuXuat.NgayXuat);
                cmd.Parameters.AddWithValue("maND", phieuXuat.MaND);
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
        public bool sua_chiTietphieuXuat(DTO_PhieuXuat phieuXuat)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "suaChiTietPhieuXuat";
                cmd.Parameters.AddWithValue("maHang", phieuXuat.MaHang);
                cmd.Parameters.AddWithValue("maPhieuXuat", phieuXuat.MaPhieuXuat);
                cmd.Parameters.AddWithValue("soLuong", phieuXuat.SoLuong);
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

        public bool them_ChiTietPhieuXuat(DTO_PhieuXuat phieuXuat)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "themChiTietPhieuXuat";
                cmd.Parameters.AddWithValue("maHang", phieuXuat.MaHang);
                cmd.Parameters.AddWithValue("maPhieuXuat", phieuXuat.MaPhieuXuat);
                cmd.Parameters.AddWithValue("soLuong", phieuXuat.SoLuong);



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

        public DataTable get_maPX()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "combobox_maPX";
                cmd.Connection = _conn;
                DataTable dtPhieuXuat = new DataTable();
                dtPhieuXuat.Load(cmd.ExecuteReader());

                return dtPhieuXuat;
            }
            finally { _conn.Close(); }
        }
        public DataTable getSoLuong(string maPX, string maHang)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "so_luong_san_pham";
                cmd.Parameters.AddWithValue("maPX", maPX);
                cmd.Parameters.AddWithValue("maHH", maHang);
                cmd.Connection = _conn;
                DataTable dtPhieuXuat = new DataTable();
                dtPhieuXuat.Load(cmd.ExecuteReader());

                return dtPhieuXuat;
            }
            finally { _conn.Close(); }
        }
        public bool sua_soLuong(DTO_PhieuXuat phieuXuat)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "suaChiTietPhieuXuat";
                cmd.Parameters.AddWithValue("maHang", phieuXuat.MaHang);
                cmd.Parameters.AddWithValue("maPhieuXuat", phieuXuat.MaPhieuXuat);
                cmd.Parameters.AddWithValue("soLuong", phieuXuat.SoLuong);
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
        public bool xoa_ctpx(string maHangHoa, string maPXuat)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoaChiTietPhieuXuat";
                cmd.Parameters.AddWithValue("maHang", maHangHoa);
                cmd.Parameters.AddWithValue("maPhieuXuat", maPXuat);

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
        public bool xoa_px( string maPXuat)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoaPhieuXuat";
                cmd.Parameters.AddWithValue("maPhieuXuat", maPXuat);

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
        public bool xoa_full(string maPX)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoa_full_ctpx";
                cmd.Parameters.AddWithValue("ma_px", maPX);

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

    }
}
