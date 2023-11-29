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
    public class DAL_PhieuNhap:DBConnect
    {
        public DataTable getDonGia(string maHang)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[cbo_don_gia_hang_hoa]";
                cmd.Parameters.AddWithValue("@maHH", maHang);
                cmd.Connection = _conn;
                DataTable dtHD = new DataTable();
                dtHD.Load(cmd.ExecuteReader());

                return dtHD;
            }
            finally { _conn.Close(); }
        }
        public DataTable getLayMaNhaCungCap()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[combobox_NCC]";
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
        public DataTable getLayMaNguoiDung()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[combobox_ND]";
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
        public DataTable getLayMaHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[combobox_MH]";
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
        public DataTable getLayMaPhieuNhap()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[combobox_MaPN]";
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
        public DataTable getPhieuNhap()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[load_phieu_nhap]";
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
        public bool themSoLuong(DTO_PhieuNhap phieuNhap)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_so_luong_sp]";
                cmd.Parameters.AddWithValue("@maPN", phieuNhap.MaPhieuNhap);
                cmd.Parameters.AddWithValue("@maHH", phieuNhap.MaHang);
                cmd.Parameters.AddWithValue("@soLuong", phieuNhap.SoLuong);
                cmd.Parameters.AddWithValue("@thanhTien", phieuNhap.ThanhTien);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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
        public bool themSoLuongLan2(DTO_PhieuNhap phieuNhap)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_so_luong_sp_lan_2]";
                cmd.Parameters.AddWithValue("@maPN", phieuNhap.MaPhieuNhap);
                cmd.Parameters.AddWithValue("@maHH", phieuNhap.MaHang);
                cmd.Parameters.AddWithValue("@soLuong", phieuNhap.SoLuong);
                cmd.Parameters.AddWithValue("@donGia", phieuNhap.DonGia);
                cmd.Parameters.AddWithValue("@thanhTien", phieuNhap.ThanhTien);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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

        public DataTable getSoLuongPhieuNhap(string maPN, string maHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn; 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[so_luong_san_pham_trong_phieu_nhap]";
                cmd.Parameters.AddWithValue("maPN", maPN);
                cmd.Parameters.AddWithValue("maHH", maHang);
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
        public bool insertPhieuNhap(DTO_PhieuNhap nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_phieu_nhap]";
                cmd.Parameters.AddWithValue("ngay_nhap", nv.NgayNhap);
                cmd.Parameters.AddWithValue("tam_ung", nv.TamUng);
                cmd.Parameters.AddWithValue("thanh_toan", nv.ThanhToan);
                cmd.Parameters.AddWithValue("mancc", nv.MaNCC);
                cmd.Parameters.AddWithValue("mand", nv.MaND);
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
        public bool insertChiTietPhieuNhap(DTO_PhieuNhap ctpn)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[them_chi_tiet_phieu_nhap]";
                cmd.Parameters.AddWithValue("ma_phieu_nhap", ctpn.MaPhieuNhap);
                cmd.Parameters.AddWithValue("ma_hang", ctpn.MaHang);
                cmd.Parameters.AddWithValue("so_luong", ctpn.SoLuong);
                cmd.Parameters.AddWithValue("don_gia", ctpn.DonGia);
                cmd.Parameters.AddWithValue("thanh_tien", ctpn.ThanhTien);
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
        public bool UpdatePhieuNhap(DTO_PhieuNhap nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_phieu_nhap]";
                cmd.Parameters.AddWithValue("@maPN", nv.MaPhieuNhap);
                cmd.Parameters.AddWithValue("@ngay_nhap", nv.NgayNhap);
                cmd.Parameters.AddWithValue("@tam_ung", nv.TamUng);
                cmd.Parameters.AddWithValue("@thanh_toan", nv.ThanhToan);
                cmd.Parameters.AddWithValue("@mancc", nv.MaNCC);
                cmd.Parameters.AddWithValue("@mand", nv.MaND);

                // Thực thi stored procedure
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool insertChiTietPhieuNhap1(DTO_PhieuNhap ctpn)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_chi_tiet_phieu_nhap]";
                cmd.Parameters.AddWithValue("ma_phieu_nhap", ctpn.MaPhieuNhap);
                cmd.Parameters.AddWithValue("ma_hang", ctpn.MaHang);
                cmd.Parameters.AddWithValue("so_luong", ctpn.SoLuong);
                cmd.Parameters.AddWithValue("don_gia", ctpn.DonGia);
                cmd.Parameters.AddWithValue("thanh_tien", ctpn.ThanhTien);
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
        public bool UpdateChiTietPhieuNhap(DTO_PhieuNhap nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sua_chi_tiet_phieu_nhap]";
                cmd.Parameters.AddWithValue("@ma_phieu_nhap", nv.MaPhieuNhap);
                cmd.Parameters.AddWithValue("@ma_hang", nv.MaHang);
                cmd.Parameters.AddWithValue("@so_luong", nv.SoLuong);
                cmd.Parameters.AddWithValue("@don_gia", nv.DonGia);
                cmd.Parameters.AddWithValue("@thanh_tien", nv.ThanhTien);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteCTPN(string maHang, string maPN)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_chi_tiet_phieu_nhap]";
                cmd.Parameters.AddWithValue("@ma_hang_hoa", maHang);
                cmd.Parameters.AddWithValue("@maPN", maPN);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeletePN(string maPN)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_phieu_nhap]";
                cmd.Parameters.AddWithValue("@maPN", maPN);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeletefullPN(string maPN)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[xoa_full_chi_tiet_phieu_nhap]";
                cmd.Parameters.AddWithValue("@maPN", maPN);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable SearchPhieuNhap(string tenND)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[tim_phieu_nhap]";
                cmd.Parameters.AddWithValue("ten_nd", tenND);
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
        public DataTable LocHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_phieu_nhap_theo_hang]";
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
        public DataTable LocNhaCungCapg()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_phieu_nhap_theo_nha_cung_cap]";
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
        public DataTable LocNguoiDung()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[loc_phieu_nhap_theo_nguoi_dung]";
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
