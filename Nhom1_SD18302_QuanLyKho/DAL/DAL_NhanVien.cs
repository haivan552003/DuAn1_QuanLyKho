using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
