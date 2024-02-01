//using HoanThien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace HoanThien.FormChildCustomer
{
    public partial class FormCthd : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-DFSF0MK1\\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True";
        private DataTable originalDataTable;


        public FormCthd()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadDonHangData();

            // Gán dữ liệu ban đầu vào originalDataTable
            originalDataTable = (DataTable)dataGridView1.DataSource;
        }

        private void FormCthd_Load(object sender, EventArgs e)
        {
            LoadDonHangData();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            SearchDon();
        }

        private void LoadDonHangData()
        {
            string query = "SELECT * FROM DonHang WHERE Tinhtrangdonhang = N'Chưa hoàn thành'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            // Ẩn cột maKH
            dataGridView1.Columns["maKH"].Visible = false;

            // Ẩn cột maSP
            dataGridView1.Columns["maSP"].Visible = false;

            // Ẩn cột maQL
            dataGridView1.Columns["maQL"].Visible = false;

            dataGridView1.Columns["Thoidiemgiaohang"].Visible = false;


            dataGridView1.Columns["MaDon"].HeaderText = "Mã đơn";

            dataGridView1.Columns["TenHang"].HeaderText = "Tên hàng";

            dataGridView1.Columns["TenNguoiNhan"].HeaderText = "Người nhận";

            dataGridView1.Columns["SDTNN"].HeaderText = "SĐT";

            dataGridView1.Columns["Diachinhanhang"].HeaderText = "Địa chỉ nhận";

            dataGridView1.Columns["DiaChigiaohang"].HeaderText = "Địa chỉ giao";

            dataGridView1.Columns["Tinhtrangdonhang"].HeaderText = "Tình trạng đơn";

            dataGridView1.Columns["Loai_Hang"].HeaderText = "Loại Hàng";

            dataGridView1.Columns["Thoidiemdathang"].HeaderText = "Thời điểm đặt";

        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                Txmadon.Text = Convert.ToString(row.Cells["MaDon"].Value);
                ThoiDiemNhan.Text = Convert.ToString(row.Cells["Thoidiemdathang"].Value);
                Txtenhang.Text = Convert.ToString(row.Cells["TenHang"].Value);
                Txloaihang.Text = Convert.ToString(row.Cells["Loai_Hang"].Value);
                Txnguoinhan.Text = Convert.ToString(row.Cells["TenNguoiNhan"].Value);
                Txsdt.Text = Convert.ToString(row.Cells["SDTNN"].Value);
                Txdiachigiao.Text = Convert.ToString(row.Cells["DiaChiGiaoHang"].Value);
                Txdiachinhan.Text = Convert.ToString(row.Cells["Diachinhanhang"].Value);
                Txdiachigiao.Text = Convert.ToString(row.Cells["DiaChiGiaoHang"].Value);
                Txtinhtrang.Text = Convert.ToString(row.Cells["Tinhtrangdonhang"].Value);
            }
        }

        private void SearchDon()
        {
            string searchTerm = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM DonHang WHERE Tinhtrangdonhang = N'Chưa hoàn thành'";

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += $" AND (MaDon LIKE '%{searchTerm}%' OR TenNguoiNhan LIKE '%{searchTerm}%')"; // Tìm kiếm theo tên các cột trong bảng

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                if (dataTable.Rows.Count == 0) // Nếu không có giá trị nào trong DataTable
                {
                    MessageBox.Show("Đơn hàng không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập vào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchDon();
        }

        private void Txloaihang_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCthd_Load_1(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = originalDataTable;
        }
        // Xóa đơn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một hàng trong DataGridView hay chưa
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy chỉ số hàng đã chọn
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Lấy giá trị của cột MaDon trong hàng đã chọn
                string maDon = dataGridView1.Rows[rowIndex].Cells["MaDon"].Value.ToString();

                // Xóa đơn hàng từ CSDL
                XoaDonHang(maDon);

                // Xóa hàng đã chọn khỏi DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Xóa đơn hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hãy chọn một đơn hàng để xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XoaDonHang(string maDon)
        {
            // Thực hiện xóa đơn hàng với mã đơn tương ứng trong CSDL
            string query = $"DELETE FROM DonHang WHERE MaDon = '{maDon}'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void rjPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThoiDiemNhan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
