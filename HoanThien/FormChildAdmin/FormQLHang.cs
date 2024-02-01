using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HoanThien.Forms
{
    public partial class FormQLHang : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-DFSF0MK1\\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True";  // Kết nối tới cơ sở dữ liệu

        public FormQLHang()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadMaKHData();
            LoadDonHangData();
            LoadMaSPData();
        }



        private void LoadDonHangData()
        {
            string query = "SELECT * FROM DonHang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVDonHang.DataSource = dataTable;
            // Đổ dữ liệu vào ComboBox cmbTinhTrang và cmbLoaiHang
            cmbTinhTrang.Items.Clear();
            cmbLoaiHang.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                string tinhTrang = row["Tinhtrangdonhang"].ToString();
                string loaiHang = row["Loai_Hang"].ToString();

                if (!cmbTinhTrang.Items.Contains(tinhTrang))
                {
                    cmbTinhTrang.Items.Add(tinhTrang);
                }
                if (!cmbLoaiHang.Items.Contains(loaiHang))
                {
                    cmbLoaiHang.Items.Add(loaiHang);
                }
            }
        }

        private void LoadMaKHData()
        {
            string queryMaKH = "SELECT DISTINCT MaKH FROM DonHang";
            SqlCommand commandMaKH = new SqlCommand(queryMaKH, connection);
            connection.Open();
            SqlDataReader readerMaKH = commandMaKH.ExecuteReader();
            while (readerMaKH.Read())
            {
                cmbMaKH.Items.Add(readerMaKH["MaKH"].ToString());
            }
            connection.Close();
        }
        private void LoadMaSPData()
        {
            string queryMaSP = "SELECT DISTINCT MaSP FROM DonHang";
            SqlCommand commandMaSP = new SqlCommand(queryMaSP, connection);
            connection.Open();
            SqlDataReader readerMaSP = commandMaSP.ExecuteReader();
            while (readerMaSP.Read())
            {
                cmbMaSP.Items.Add(readerMaSP["MaSP"].ToString());
            }
            connection.Close();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (DGVDonHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maDon = DGVDonHang.SelectedRows[0].Cells["MaDon"].Value.ToString();
                    string deleteQuery = "DELETE FROM DonHang WHERE MaDon = @MaDon";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MaDon", maDon);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa đơn hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDonHangData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa đơn hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (DGVDonHang.SelectedRows.Count > 0)
            {
                string maDon = DGVDonHang.SelectedRows[0].Cells["MaDon"].Value.ToString();
                // Hiển thị form chỉnh sửa đơn hàng với mã đơn hàng đã chọn

                FormChinhSuaDonHang formChinhSua = new FormChinhSuaDonHang(maDon);
                formChinhSua.ShowDialog();

                // Sau khi chỉnh sửa đơn hàng, cập nhật lại danh sách đơn hàng
                LoadDonHangData();
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maSP = cmbMaSP.SelectedItem?.ToString();
            string maKH = cmbMaKH.SelectedItem?.ToString();
            string tinhTrang = cmbTinhTrang.SelectedItem?.ToString();
            string loaiHang = cmbLoaiHang.SelectedItem?.ToString();

            string query = "SELECT * FROM DonHang WHERE 1=1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);


            if (string.IsNullOrEmpty(tinhTrang) && string.IsNullOrEmpty(loaiHang) && string.IsNullOrEmpty(maKH) && string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn tiêu chí để lọc đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!string.IsNullOrEmpty(maSP))
            {
                query += " AND MaSP = @MaSP";
                adapter.SelectCommand.Parameters.AddWithValue("@MaSP", maSP);
            }

            if (!string.IsNullOrEmpty(maKH))
            {
                query += " AND MaKH = @MaKH";
                adapter.SelectCommand.Parameters.AddWithValue("@MaKH", maKH);
            }

            if (!string.IsNullOrEmpty(tinhTrang))
            {
                query += $" AND Tinhtrangdonhang = N'{tinhTrang}'";
            }

            if (!string.IsNullOrEmpty(loaiHang))
            {
                query += $" AND Loai_Hang = N'{loaiHang}'";
            }
            adapter.SelectCommand.CommandText = query;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGVDonHang.DataSource = dataTable;
    }



        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset các giá trị trong các điều khiển
            cmbMaKH.SelectedItem = null;
            cmbTinhTrang.SelectedItem = null;
            cmbMaSP.SelectedItem = null;
            cmbLoaiHang.SelectedItem = null;
            LoadDonHangData();
            DGVDonHang.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ThongKeHang()
        {
            string query = "SELECT Tinhtrangdonhang, Loai_Hang, COUNT(*) AS SoLuong FROM DonHang GROUP BY Tinhtrangdonhang, Loai_Hang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Xóa dữ liệu cũ trong biểu đồ
            chartThongKe.Series.Clear();

            // Tạo một series mới cho biểu đồ
            Series series = new Series("Thống kê đơn hàng", (int)SeriesChartType.Column);

            // Đổ dữ liệu từ DataTable vào series
            foreach (DataRow row in dataTable.Rows)
            {
                string tinhTrang = row["Tinhtrangdonhang"].ToString();
                string loaiHang = row["Loai_Hang"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                // Thêm data point vào series
                series.Points.AddXY(tinhTrang + " - " + loaiHang, soLuong);
            }

            // Thêm series vào biểu đồ
            chartThongKe.Series.Add(series);
            // Cấu hình biểu đồ
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chartThongKe.ChartAreas[0].AxisX.Interval = 1;
            chartThongKe.ChartAreas[0].AxisY.Title = "Số lượng";
            chartThongKe.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chartThongKe.ChartAreas[0].AxisY.Minimum = 0;
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartThongKe.Legends[0].Enabled = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeHang();
        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormQLHang_Load_1(object sender, EventArgs e)
        {
            LoadDonHangData();
            DGVDonHang.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
