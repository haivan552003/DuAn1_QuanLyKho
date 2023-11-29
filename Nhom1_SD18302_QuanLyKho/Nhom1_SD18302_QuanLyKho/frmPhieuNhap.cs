using BUS;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmPhieuNhap : Form
    {
        BUS_PhieuNhap busPN = new BUS_PhieuNhap();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadGridView_PhieuNhap();
            getLayMaHang();
            getMaNhaCungCap();
            getMaNguoiDung();
            //dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            //dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            //dtpNgayNhap.Value.ToString("dd/MM/yyyy");
            //dv_phieunhap.CellFormatting += dv_phieunhap_CellFormatting;
        }
        public void getLayMaHang()
        {
            cboMaHang.DataSource = busPN.getLayMaHang();
            cboMaHang.DisplayMember = "ten_hang";
            cboMaHang.ValueMember = "ma_hang";
        }
        public void getLayMaPhieuNhap()
        {
            cboMaPhieuNhap.DataSource = busPN.getLayMaPhieuNhap();
            cboMaPhieuNhap.DisplayMember = "ma_phieu_nhap";
            cboMaPhieuNhap.ValueMember = "ma_phieu_nhap";
        }
        public void getMaNhaCungCap()
        {
            cboNhaCungCap.DataSource = busPN.getLayMaNhaCungCap();
            cboNhaCungCap.DisplayMember = "ten_ncc";
            cboNhaCungCap.ValueMember = "ma_ncc";
        }
        public void getMaNguoiDung()
        {
            cboNguoiDung.DataSource = busPN.getLayMaNguoiDung();
            cboNguoiDung.DisplayMember = "ten_nd";
            cboNguoiDung.ValueMember = "ma_nd";
        }
        private void LoadGridView_PhieuNhap()
        {
            dv_phieunhap.DataSource = busPN.getPhieuNhap();
        }


        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaHang.SelectedValue != null)
            {
                System.Data.DataTable dtDonGia = busPN.getDonGia(cboMaHang.SelectedValue.ToString());

                if (dtDonGia.Rows.Count > 0)
                {
                    object maHangObj = dtDonGia.Rows[0][0].ToString();
                    if (maHangObj != DBNull.Value)
                    {
                        txt_dongia.Text = maHangObj.ToString();
                    }
                    else
                    {
                        txt_dongia.Text = "0";
                    }
                }
            }
            else
            {
                txt_dongia.Text = "0";

            }
        }

        //private void txt_thanhtien_TextChanged(object sender, EventArgs e)
        //{
        //    //CalculateSum();
        //}
        private void CalculateSum()
        {
            if (int.TryParse(txt_soluongPN.Text, out int n) &&
                float.TryParse(txt_dongia.Text, out float m))
            {
                float sum = n * m;
                txt_thanhtien.Text = sum.ToString();
            }
            else
            {
                txt_thanhtien.Text = "0";
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            float floatTamUng;
            bool isInt = int.TryParse(txt_soluongPN.Text.Trim().ToString(), out intSoLuong);
            bool isFloat = float.TryParse(txtTamUng.Text.Trim().ToString(), out floatTamUng);
            DateTime ngayNhap = dtpNgayNhap.Value;
            string ngayNhapFomated = ngayNhap.ToString("dd/MM/yyyy");
            try
            {
                if (
                    !string.IsNullOrWhiteSpace(cboMaHang.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(dtpNgayNhap.Text) ||
                    !string.IsNullOrWhiteSpace(txtTamUng.Text) ||
                    !string.IsNullOrWhiteSpace(txt_soluongPN.Text) ||
                    !string.IsNullOrWhiteSpace(txt_dongia.Text) ||
                    !string.IsNullOrWhiteSpace(txtThanhToan.Text) ||
                    !string.IsNullOrWhiteSpace(txt_thanhtien.Text) ||
                    !string.IsNullOrWhiteSpace(cboNhaCungCap.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(cboNguoiDung.SelectedValue.ToString()))
                {
                    if (!isInt || int.Parse(txt_soluongPN.Text) < 0 ||
                        !isFloat || float.Parse(txtTamUng.Text) < 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_soluongPN.Focus();
                        return;
                    }
                    else
                    {
                        DTO_PhieuNhap pn = new DTO_PhieuNhap(ngayNhapFomated, float.Parse(txtTamUng.Text), float.Parse(txtThanhToan.Text), cboNhaCungCap.SelectedValue.ToString(), cboNguoiDung.SelectedValue.ToString());
                        if (cboMaPhieuNhap.SelectedValue == null)
                        {
                            //them phieu nhap + chi tiet phieu nhap
                            if (busPN.insertPhieuNhap(pn))
                            {
                                getLayMaPhieuNhap();
                                DTO_PhieuNhap ctpn = new DTO_PhieuNhap(cboMaPhieuNhap.SelectedValue.ToString(), cboMaHang.SelectedValue.ToString(), int.Parse(txt_soluongPN.Text), float.Parse(txt_dongia.Text), float.Parse(txt_thanhtien.Text));
                                if (busPN.insertChiTietPhieuNhap(ctpn))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadGridView_PhieuNhap();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            System.Data.DataTable dtSoLuong = busPN.getSoLuong(cboMaPhieuNhap.SelectedValue.ToString(), cboMaHang.SelectedValue.ToString());

                            if (dtSoLuong != null && dtSoLuong.Rows.Count > 0)
                            {
                                object soLuongObj = dtSoLuong.Rows[0][0].ToString();
                                object thanhTienObj = dtSoLuong.Rows[0][1].ToString();
                                if (dtSoLuong.Rows.Count > 0)
                                {
                                    if (soLuongObj != DBNull.Value)
                                    {

                                        //neu sp da ton tai trong phieu nhap
                                        int soLuongSP = Convert.ToInt32(soLuongObj) + int.Parse(txt_soluongPN.Text);
                                        float thanhTien = Convert.ToSingle(thanhTienObj) + Convert.ToSingle(txt_thanhtien.Text) - Convert.ToSingle(txtTamUng.Text);

                                        DTO_PhieuNhap ctpn_soLuong = new DTO_PhieuNhap(cboMaPhieuNhap.SelectedValue.ToString(), cboMaHang.SelectedValue.ToString(), soLuongSP, float.Parse(txt_dongia.Text), thanhTien);

                                        if (busPN.insertSoLuongSp(ctpn_soLuong))
                                        {
                                            MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            LoadGridView_PhieuNhap();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }

                            else
                            {
                                //them cthd
                                DTO_PhieuNhap ctpn = new DTO_PhieuNhap(cboMaPhieuNhap.SelectedValue.ToString(), cboMaHang.SelectedValue.ToString(), int.Parse(txt_soluongPN.Text), float.Parse(txt_thanhtien.Text));

                                if (busPN.insertChiTietPhieuNhap(ctpn))
                                {
                                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadGridView_PhieuNhap();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void ban_capnhat_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            float floatTamUng;
            bool isInt = int.TryParse(txt_soluongPN.Text.Trim().ToString(), out intSoLuong);
            bool isFloat = float.TryParse(txtTamUng.Text.Trim().ToString(), out floatTamUng);
            DateTime ngayNhap = dtpNgayNhap.Value;
            string ngayNhapFomated = ngayNhap.ToString("dd/MM/yyyy");
            try
            {
                if (
                    !string.IsNullOrWhiteSpace(cboMaHang.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(dtpNgayNhap.Text) ||
                    !string.IsNullOrWhiteSpace(txtTamUng.Text) ||
                    !string.IsNullOrWhiteSpace(txt_soluongPN.Text) ||
                    !string.IsNullOrWhiteSpace(txt_dongia.Text) ||
                    !string.IsNullOrWhiteSpace(txtThanhToan.Text) ||
                    !string.IsNullOrWhiteSpace(txt_thanhtien.Text) ||
                    !string.IsNullOrWhiteSpace(cboNhaCungCap.SelectedValue.ToString()) ||
                    !string.IsNullOrWhiteSpace(cboNguoiDung.SelectedValue.ToString()))
                {
                    if (!isInt || int.Parse(txt_soluongPN.Text) < 0 ||
                        !isFloat || float.Parse(txtTamUng.Text) < 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lớn hơn 0", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_soluongPN.Focus();
                        return;
                    }
                    else
                    {
                        DTO_PhieuNhap pn = new DTO_PhieuNhap(cboMaPhieuNhap.SelectedValue.ToString(), ngayNhapFomated, float.Parse(txtTamUng.Text), float.Parse(txtThanhToan.Text), cboNhaCungCap.SelectedValue.ToString(), cboNguoiDung.SelectedValue.ToString());

                        if (cboMaPhieuNhap.SelectedValue.ToString() != null)
                        {

                            //sua hoa don + chi tiet hoa don
                            if (busPN.updatePhieuNhap(pn))
                            {
                                System.Data.DataTable dtSoLuong = busPN.getSoLuong(cboMaPhieuNhap.SelectedValue.ToString(), cboMaHang.SelectedValue.ToString());

                                //object soLuongObj = dtSoLuong.Rows[0][0].ToString();
                                //object thanhTienObj = dtSoLuong.Rows[0][1].ToString();

                                //int soluongsp = Convert.ToInt32(soLuongObj) + int.Parse(txt_soluongPN.Text);
                                //float thanhTien = Convert.ToSingle(thanhTienObj) + Convert.ToSingle(txt_thanhtien.Text) - Convert.ToSingle(txtThanhToan.Text);

                                DTO_PhieuNhap ctpn_soLuong = new DTO_PhieuNhap(cboMaPhieuNhap.SelectedValue.ToString(), cboMaHang.SelectedValue.ToString(), int.Parse(txt_soluongPN.Text), float.Parse(txt_dongia.Text), float.Parse(txt_thanhtien.Text));
                                if (busPN.insertSoLuongSpLan2(ctpn_soLuong))
                                {
                                    MessageBox.Show("Sửa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadGridView_PhieuNhap();
                                }
                                else
                                {
                                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }



        private void lbl_thanhtien_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void dv_phieunhap_Click(object sender, EventArgs e)
        {
            getLayMaPhieuNhap();
            if (dv_phieunhap.Rows.Count > 1)
            {
                string maPN = dv_phieunhap.CurrentRow.Cells[0].Value.ToString();
                int index = cboMaPhieuNhap.FindStringExact(maPN);

                if (index != -1)
                {
                    cboMaPhieuNhap.SelectedIndex = index;
                }
                DateTime ngayNhap;
                if (DateTime.TryParseExact(dv_phieunhap.CurrentRow.Cells[1].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayNhap))
                {
                    dtpNgayNhap.Value = ngayNhap;
                }
                else
                {
                    // Xử lý lỗi định dạng ngày tháng không hợp lệ
                }
                string maHang = dv_phieunhap.CurrentRow.Cells[2].Value.ToString();
                int index2 = cboMaHang.FindStringExact(maHang);

                if (index2 != -1)
                {
                    cboMaHang.SelectedIndex = index2;
                }
                txt_soluongPN.Text = dv_phieunhap.CurrentRow.Cells[3].Value.ToString();
                txt_dongia.Text = dv_phieunhap.CurrentRow.Cells[4].Value.ToString();
                txt_thanhtien.Text = dv_phieunhap.CurrentRow.Cells[5].Value.ToString();
                txtTamUng.Text = dv_phieunhap.CurrentRow.Cells[6].Value.ToString();
                txtThanhToan.Text = dv_phieunhap.CurrentRow.Cells[7].Value.ToString();
                string maNCC = dv_phieunhap.CurrentRow.Cells[8].Value.ToString();

                int index8 = cboNhaCungCap.FindStringExact(maNCC);

                if (index8 != -1)
                {
                    cboNhaCungCap.SelectedIndex = index8;
                }
                string maND = dv_phieunhap.CurrentRow.Cells[9].Value.ToString();

                int index9 = cboNguoiDung.FindStringExact(maND);

                if (index9 != -1)
                {
                    cboNguoiDung.SelectedIndex = index9;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        private void lbl_thanhtien_Click(object sender, EventArgs e)
        {
            CalculateSum();
        }


        private void cboMaPhieuNhap_Click(object sender, EventArgs e)
        {
            getLayMaPhieuNhap();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Tạo một Workbook mới
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

            // Tạo một Worksheet mới
            Microsoft.Office.Interop.Excel.Worksheet sheet = null;
            sheet = workbook.Sheets["Sheet1"];
            sheet = workbook.ActiveSheet;

            // Đặt tiêu đề cho các cột
            for (int i = 1; i <= dv_phieunhap.Columns.Count; i++)
            {
                sheet.Cells[1, i] = dv_phieunhap.Columns[i - 1].HeaderText;
            }

            // Thêm dữ liệu từ DataGridView vào Worksheet
            for (int i = 0; i < dv_phieunhap.Rows.Count; i++)
            {
                for (int j = 0; j < dv_phieunhap.Columns.Count; j++)
                {
                    if (dv_phieunhap.Rows[i].Cells[j].Value != null)
                    {
                        sheet.Cells[i + 2, j + 1] = dv_phieunhap.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            // Lưu Workbook vào một tệp Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Đóng Workbook và Excel
            workbook.Close();
            excel.Quit();
        }


        private void CalculateSumThanhToan()
        {
            if (float.TryParse(txt_thanhtien.Text, out float n) &&
                float.TryParse(txtTamUng.Text, out float m))
            {
                float sum = n - m;
                txtThanhToan.Text = sum.ToString();
            }
            else
            {
                txtThanhToan.Text = "0";
            }
        }

        private void lblThanhToan_Click(object sender, EventArgs e)
        {
            CalculateSumThanhToan();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maPN = cboMaPhieuNhap.SelectedValue.ToString();
            string maH = cboMaHang.SelectedValue.ToString();
            DialogResult result = MessageBox.Show("Bạn có muốn xóa toàn bộ hóa đơn?", "confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (maPN != null && maH != null)
                {
                    busPN.deletefullCTPN(maPN);
                    busPN.deletePN(maPN);
                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridView_PhieuNhap();
                    getLayMaPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                if (maPN != null && maH != null)
                {
                    busPN.deleteCTPN(maH, maPN);
                    MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridView_PhieuNhap();
                    getLayMaPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ptb_timPN_Click(object sender, EventArgs e)
        {
            string tenND = txt_timkiemPN.Text;

            System.Data.DataTable ds = busPN.searchPhieuNhap(tenND);

            if (ds.Rows.Count > 0)
            {
                dv_phieunhap.DataSource = ds;
                dv_phieunhap.Columns[0].HeaderText = "Mã Phiếu Nhập";
                dv_phieunhap.Columns[1].HeaderText = "Ngày Nhập";
                dv_phieunhap.Columns[2].HeaderText = "Tên Hàng";
                dv_phieunhap.Columns[3].HeaderText = "Số Lượng";
                dv_phieunhap.Columns[4].HeaderText = "Đơn Giá";
                dv_phieunhap.Columns[5].HeaderText = "Thành Tiền";
                dv_phieunhap.Columns[6].HeaderText = "Tạm Ứng";
                dv_phieunhap.Columns[7].HeaderText = "Thanh Toán";
                dv_phieunhap.Columns[8].HeaderText = "Nhà Cung Cấp";
                dv_phieunhap.Columns[8].HeaderText = "Người Dùng";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp có tên " + tenND);
            }
        }

        private void cbx_locPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_locPN.SelectedItem == "Hàng")
            {
                dv_phieunhap.DataSource = busPN.LocHang();
            }
            else if (cbx_locPN.SelectedItem == "Nhà cung cấp")
            {
                dv_phieunhap.DataSource = busPN.LocNhaCungCap();
            }
            else
            {
                dv_phieunhap.DataSource = busPN.LocNguoiDung();
            }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                System.Data.DataTable data = LoadDataFromExcel(filePath);
                dv_phieunhap.DataSource = data;
                //SaveDataToDatabase(data);
            }
        }
        private System.Data.DataTable LoadDataFromExcel(string filePath)
        {
            System.Data.DataTable data = new System.Data.DataTable();

            string connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1;\"", filePath);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                System.Data.DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (schemaTable.Rows.Count > 0)
                {
                    string sheetName = schemaTable.Rows[0]["TABLE_NAME"].ToString();
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [" + sheetName + "]", connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(data);
                }
            }

            return data;
        }

        //private void SaveDataToDatabase1(System.Data.DataTable data)
        //{
        //    string connectionString = "Data Source=DESKTOP-CRTPNUI\\QUICUTE;Initial Catalog=DUAN1_QUANLYKHO;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        foreach (DataRow row in data.Rows)
        //        {
        //            string query = "update phieu_nhap set ngay_nhap = @ngay_nhap, tam_ung = @tam_ung, thanh_toan = @thanh_toan, ma_ncc = @mancc, ma_nd = @mand where ma_phieu_nhap = @maPN";

        //            SqlCommand command = new SqlCommand(query, connection);

        //            // Thiết lập giá trị cho các tham số của truy vấn
        //            command.Parameters.AddWithValue("@maPN", row["Mã Phiếu Nhập"]);
        //            command.Parameters.AddWithValue("@ngay_nhap", row["Ngày Nhập"]);
        //            command.Parameters.AddWithValue("@tam_ung", row["Tạm Ứng"]);
        //            command.Parameters.AddWithValue("@thanh_toan", row["Thanh Toán"]);
        //            command.Parameters.AddWithValue("@mancc", row["Nhà Cung Cấp"]);
        //            command.Parameters.AddWithValue("@mand", row["Người Dùng"]);
        //            command.ExecuteNonQuery();

        //        }
        //    }
        //}
        private void SaveDataToDatabase(System.Data.DataTable data)
        {
            string connectionString = "Data Source=DESKTOP-CRTPNUI\\QUICUTE;Initial Catalog=DUAN1_QUANLYKHO;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                for (int i = 0; i < dv_phieunhap.Rows.Count; i++)
                {
                    connection.Open();
                    //string insertQuery = "INSERT INTO phieu_nhap (ngay_nhap, tam_ung, thanh_toan, ma_ncc, ma_nd) VALUES (@ngay_nhap, @tam_ung, @thanh_toan, @mancc, @mand);" +
                    //                                     "INSERT INTO chi_tiet_phieu_nhap (ma_phieu_nhap, ma_hang, so_luong, don_gia, thanh_tien) VALUES (@ma_phieu_nhap, @ma_hang, @so_luong, @don_gia, @thanh_tien)";

                    string insertQuery = "UPDATE phieu_nhap SET ngay_nhap = @ngay_nhap, tam_ung = @tam_ung, thanh_toan = @thanh_toan, ma_ncc = @mancc, ma_nd = @mand WHERE ma_phieu_nhap = @ma_phieu_nhap;" +
                      "UPDATE chi_tiet_phieu_nhap SET so_luong = @so_luong, don_gia = @don_gia, thanh_tien = @thanh_tien WHERE ma_phieu_nhap = @ma_phieu_nhap AND ma_hang = @ma_hang";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    // Thiết lập giá trị cho các tham số của truy vấn
                    insertCommand.Parameters.AddWithValue("@ma_phieu_nhap", dv_phieunhap.Rows[i].Cells[1].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@ngay_nhap", dv_phieunhap.Rows[i].Cells[2].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@tam_ung", dv_phieunhap.Rows[i].Cells[7].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@thanh_toan", dv_phieunhap.Rows[i].Cells[8].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@mancc", dv_phieunhap.Rows[i].Cells[9].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@mand", dv_phieunhap.Rows[i].Cells[10].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@ma_hang", dv_phieunhap.Rows[i].Cells[3].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@so_luong", dv_phieunhap.Rows[i].Cells[4].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@don_gia", dv_phieunhap.Rows[i].Cells[5].Value.ToString());
                    insertCommand.Parameters.AddWithValue("@thanh_tien", dv_phieunhap.Rows[i].Cells[6].Value.ToString());

                    insertCommand.ExecuteNonQuery();

                }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            cboMaPhieuNhap.Text = "";
            cboMaHang.Text = "";
            dtpNgayNhap.Text = "";
            cboNguoiDung.Text = "";
            cboNhaCungCap.Text = "";
            txtTamUng.Text = "";
            txt_dongia.Text = "";
            txtThanhToan.Text = "";
            txt_soluongPN.Text = "";
            txt_thanhtien.Text = "";
        }
    }
}
