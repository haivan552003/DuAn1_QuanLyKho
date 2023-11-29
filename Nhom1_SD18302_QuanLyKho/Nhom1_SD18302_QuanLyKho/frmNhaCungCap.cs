using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_SD18302_QuanLyKho
{
    public partial class frmNhaCungCap : Form
    {
        BUS_NhaCungCap busncc = new BUS_NhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
            LoadGridView_NhaCungCap();
            cboMaND.DataSource = busncc.getNguoiDung();
            cboMaND.DisplayMember = "ten_nd";
            cboMaND.ValueMember = "ma_nd";
        }

        private void dv_PX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadGridView_NhaCungCap()
        {
            dv_NCC.DataSource = busncc.getNhaCungCap();
            txtMaNCC.Enabled = false;
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tenNcc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_sdtncc.Text))
            {
                MessageBox.Show("Vui lòng nhập sdt.");
                return;
            }

            DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txt_tenNcc.Text, richTextBox1.Text, txt_sdtncc.Text, cboMaND.SelectedValue.ToString());
            if (busncc.insertNhaCungCap(ncc))
            {
                MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView_NhaCungCap(); // refresh datagridview
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dv_NCC_Click(object sender, EventArgs e)
        {
            if (dv_NCC.Rows.Count > 1)
            {
                txtMaNCC.Enabled = false;
                txtMaNCC.Text = dv_NCC.CurrentRow.Cells[0].Value.ToString();
                txt_tenNcc.Text = dv_NCC.CurrentRow.Cells[1].Value.ToString();
                richTextBox1.Text = dv_NCC.CurrentRow.Cells[2].Value.ToString();
                txt_sdtncc.Text = dv_NCC.CurrentRow.Cells[3].Value.ToString();

                string maNd = dv_NCC.CurrentRow.Cells[4].Value.ToString();

                int index = cboMaND.FindStringExact(maNd);

                if (index != -1)
                {
                    cboMaND.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_capnhatNcc_Click(object sender, EventArgs e)
        {
            DTO_NhaCungCap ncc = new DTO_NhaCungCap(txtMaNCC.Text, txt_tenNcc.Text, richTextBox1.Text, txt_sdtncc.Text, cboMaND.SelectedValue.ToString());
            if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (busncc.updateNhaCungCap(ncc))
                {
                    MessageBox.Show("Sửa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Resetvalue();
                    LoadGridView_NhaCungCap();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_xoaNCC_Click(object sender, EventArgs e)
        {
            if (dv_NCC.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MaNCC = dv_NCC.SelectedRows[0].Cells[0].Value.ToString();
                    if (busncc.deleteNhaCungCap(MaNCC))
                    {
                        MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Resetvalue();
                        LoadGridView_NhaCungCap();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ptb_timNCC_Click(object sender, EventArgs e)
        {
            string tenNCC = txt_timNCC.Text; // Get the text from the search input field

            DataTable ds = busncc.searchNhaCungCap(tenNCC);

            if (ds.Rows.Count > 0)
            {
                dv_NCC.DataSource = ds;  // Update the DataGridView with the search results
                dv_NCC.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
                dv_NCC.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
                dv_NCC.Columns[2].HeaderText = "Địa chỉ";
                dv_NCC.Columns[3].HeaderText = "Số Điện Thoại";
                dv_NCC.Columns[4].HeaderText = "Tên Người Dùng";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp có tên " + tenNCC);
            }
            //Resetvalue(); // You may need to implement a method or logic to reset the form values
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem == "A - Z")
            {
                dv_NCC.DataSource = busncc.LocNhaCungCapA_Z();
            }
            else
            {
                dv_NCC.DataSource = busncc.LocNhaCungCapZ_A();
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
                dv_NCC.DataSource = data;
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
            for (int i = 1; i <= dv_NCC.Columns.Count; i++)
            {
                sheet.Cells[1, i] = dv_NCC.Columns[i - 1].HeaderText;
            }

            // Thêm dữ liệu từ DataGridView vào Worksheet
            for (int i = 0; i < dv_NCC.Rows.Count; i++)
            {
                for (int j = 0; j < dv_NCC.Columns.Count; j++)
                {
                    if (dv_NCC.Rows[i].Cells[j].Value != null)
                    {
                        sheet.Cells[i + 2, j + 1] = dv_NCC.Rows[i].Cells[j].Value.ToString();
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

        private void btn_lammoiNCC_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txt_tenNcc.Text = "";
            cboMaND.Text = "";
            richTextBox1.Text = "";
            txt_sdtncc.Text = "";
        }
    }
}
