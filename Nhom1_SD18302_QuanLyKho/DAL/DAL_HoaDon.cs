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
    public class DAL_HoaDon : DBConnect
    {
        public DataTable getHD()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[load_hdct]";
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }
        public DataTable getDonGia(string maHang)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[don_gia_hang_hoa]";
                cmd.Parameters.AddWithValue("@maHH", maHang);
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }
        public DataTable getSoLuongSP(string maHD, string maHang)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[so_luong_san_pham_trong_hoa_don]";
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@maHH", maHang);
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
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
                cmd.CommandText = "[lay_nguoi_dung]";
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }
        public DataTable getHH()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[lay_ma_hang]";
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }

        public DataTable getMaHD()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[lay_ma_hoa_don]";
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }

        public DataTable getKH()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[lay_ma_khach_hang]";
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }

        public bool insertHD(DTO_HoaDon hoadon)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_hoa_don]";
                cmd.Parameters.AddWithValue("@ngay_ban", hoadon.NgayBan);
                cmd.Parameters.AddWithValue("@ngay_giao_hang", hoadon.NgayGiao);
                cmd.Parameters.AddWithValue("@tien_coc", hoadon.TienCoc);
                cmd.Parameters.AddWithValue("@ma_nd", hoadon.MaND);
                cmd.Parameters.AddWithValue("@ma_kh", hoadon.MaKH);

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

        public bool insertCTHD(DTO_HoaDon hoadon)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_chi_tiet_hoa_don]";
                cmd.Parameters.AddWithValue("@ma_hd", hoadon.MaHD);
                cmd.Parameters.AddWithValue("@ma_hang", hoadon.MaSP);
                cmd.Parameters.AddWithValue("@so_luong", hoadon.SoLuong);
                cmd.Parameters.AddWithValue("@don_gia", hoadon.DonGia);
                cmd.Parameters.AddWithValue("@thanh_tien", hoadon.ThanhTien);

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

        //them so luong sp trong hoa don
        //sua chi tiet hoa don
        public bool insertSoLuongSP(DTO_HoaDon hoadon)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_chi_tiet_hoa_don]";
                cmd.Parameters.AddWithValue("@maHD", hoadon.MaHD);
                cmd.Parameters.AddWithValue("@maHH", hoadon.MaSP);
                cmd.Parameters.AddWithValue("@soLuong", hoadon.SoLuong);
                cmd.Parameters.AddWithValue("@thanhTien", hoadon.ThanhTien);

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

        public bool updateHoaDon(DTO_HoaDon hoadon)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_hoa_don]";
                cmd.Parameters.AddWithValue("@ma_hd", hoadon.MaHD);
                cmd.Parameters.AddWithValue("@ngay_ban", hoadon.NgayBan);
                cmd.Parameters.AddWithValue("@ngay_giao_hang", hoadon.NgayGiao);
                cmd.Parameters.AddWithValue("@tien_coc", hoadon.TienCoc);
                cmd.Parameters.AddWithValue("@ma_nd", hoadon.MaND);
                cmd.Parameters.AddWithValue("@ma_kh", hoadon.MaKH);

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

        public bool deleteCTHD(string maHD, string maHH)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_hoa_don_chi_tiet]";
                cmd.Parameters.AddWithValue("@ma_hd", maHD);
                cmd.Parameters.AddWithValue("@ma_hang", maHH);

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
        public bool delete_full_CTHD(string maHD)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_full_hoa_don_chi_tiet]";
                cmd.Parameters.AddWithValue("@ma_hd", maHD);

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

        public bool deleteHD(string maHD)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_hoa_don]";
                cmd.Parameters.AddWithValue("@ma_hd", maHD);

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

        public DataTable SeachHD(string maHD)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tim_hdct_ngayBan]";
                cmd.Parameters.AddWithValue("@ma_hd", maHD);
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

        public DataTable loc_hd_a_z()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_hd_a_z]";
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }

        public DataTable loc_hd_z_a()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_hd_z_a]";
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }

        public DataTable in_hd(string maHD)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[load_in_hd]";
                cmd.Parameters.AddWithValue("@ma_hd", maHD);
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }

        public DataTable getThongTinKH(string maHD)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[thongtin_khachhang]";
                cmd.Parameters.AddWithValue("@ma_hd", maHD);
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }
    }
}
