using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Globalization;

namespace HoanThien.Forms
{
    public partial class FormThongKe : Form
    {
        private string connectionString ="Data Source=LAPTOP-DFSF0MK1\\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True";

        public FormThongKe()
        {
            InitializeComponent();
            dataGridViewThongKe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void FormThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridViewThongKe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chartThongKe.ChartAreas[0].AxisX.Interval = 1;
            chartThongKe.Legends[0].Enabled = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Thống kê tổng số lượng đơn hàng của tất cả Shipper
                int tongDonHang = GetTongDonHang(connection);
                lblTongDon.Text = "" + tongDonHang;

                int tongShipper = GetTongShipper(connection);
                lblTongShipper.Text = "" + tongShipper;

                connection.Close();
            }

        }

        private void LoadData()
        {
            string query = "SELECT tenShipper, Shipper.MaSP, COUNT(*) AS SoLuongDonHang FROM Shipper " +
                           "INNER JOIN DonHang ON Shipper.MaSP = DonHang.MaSP " +
                           "GROUP BY tenShipper, Shipper.MaSP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewThongKe.DataSource = dataTable;
                    dataGridViewThongKe.Columns["MaSP"].Visible = true;

                    chartThongKe.Series.Clear();
                    Series series = new Series("Số lượng đơn hàng");
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string shipperName = row["tenShipper"].ToString();
                        int orderCount = Convert.ToInt32(row["SoLuongDonHang"]);
                        series.Points.AddXY(shipperName, orderCount);
                    }

                    chartThongKe.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private int GetTongShipper(SqlConnection connection)
        {
            int tongShipper = 0;

            string query = "SELECT COUNT(*) AS TongShipper FROM Shipper";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                tongShipper = Convert.ToInt32(command.ExecuteScalar());
            }

            return tongShipper;
        }

        private int GetTongDonHang(SqlConnection connection)
        {
            int tongDonHang = 0;

            string query = "SELECT COUNT(*) AS TongDonHang FROM DonHang";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                tongDonHang = Convert.ToInt32(command.ExecuteScalar());
            }

            return tongDonHang;
        }

        private void btnThongKeKhuVuc_Click(object sender, EventArgs e)
        {
            string query = "SELECT DiaChigiaohang, COUNT(*) AS SoLuongDonHang FROM DonHang " +
                           "GROUP BY DiaChigiaohang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewThongKe.DataSource = dataTable;


                    chartThongKe.Series.Clear();
                    Series series = new Series("Số lượng đơn hàng");
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string address = row["DiaChigiaohang"].ToString();
                        int orderCount = Convert.ToInt32(row["SoLuongDonHang"]);
                        series.Points.AddXY(address, orderCount);
                    }

                    chartThongKe.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThongKeLoaiHang_Click(object sender, EventArgs e)
        {
            string query = "SELECT Loai_Hang, COUNT(*) AS SoLuongDonHang FROM DonHang " +
                           "GROUP BY Loai_Hang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewThongKe.DataSource = dataTable;
                    chartThongKe.Series.Clear();
                    Series series = new Series("Số lượng đơn hàng");
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string productType = row["Loai_Hang"].ToString();
                        int orderCount = Convert.ToInt32(row["SoLuongDonHang"]);
                        series.Points.AddXY(productType, orderCount);
                    }

                    chartThongKe.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void btnThongKeTheoThoiDiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT Thoidiemdathang AS NgayDatHang, COUNT(*) AS SoLuongDonHang " +
                           "FROM DonHang " +
                           "GROUP BY Thoidiemdathang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewThongKe.DataSource = dataTable;
                    dataGridViewThongKe.Columns["NgayDatHang"].Visible = true;

                    chartThongKe.Series.Clear();
                    Series series = new Series("Số lượng đơn hàng");
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        DateTime date = Convert.ToDateTime(row["NgayDatHang"]);
                        int orderCount = Convert.ToInt32(row["SoLuongDonHang"]);
                        series.Points.AddXY(date, orderCount);
                    }

                    chartThongKe.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThongKeTinhTrang_Click(object sender, EventArgs e)
        {
            string query = "SELECT MaSP, COUNT(*) AS TONG_SO_DON_HANG FROM DonHang " +
                           "WHERE Tinhtrangdonhang = N'Đã hoàn thành' GROUP BY MaSP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewThongKe.DataSource = dataTable;
                    dataGridViewThongKe.Columns["TONG_SO_DON_HANG"].HeaderText = "Số đơn hoàn thành";

                    // Tính toán năng suất cho từng shipper
                    dataTable.Columns.Add("Năng Suất", typeof(double));
                    int totalOrders = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int orderCount = Convert.ToInt32(row["TONG_SO_DON_HANG"]);
                        totalOrders += orderCount;
                    }
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int orderCount = Convert.ToInt32(row["TONG_SO_DON_HANG"]);
                        double productivity = (orderCount / (double)totalOrders) * 100;
                        row["Năng Suất"] = productivity;
                    }

                    chartThongKe.Series.Clear();
                    Series series = new Series("Năng suất (%)");
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string shipperID = row["MaSP"].ToString();
                        double productivity = Convert.ToDouble(row["Năng Suất"]);
                        series.Points.AddXY(shipperID, productivity);
                    }

                    chartThongKe.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {

            string query = "SELECT MONTH(Thoidiemdathang) AS Thang, COUNT(*) * 20000 * 0.2 AS DoanhThu FROM DonHang " +
                   "GROUP BY MONTH(Thoidiemdathang) " +
                   "ORDER BY MONTH(Thoidiemdathang)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewThongKe.DataSource = dataTable;
                    dataGridViewThongKe.Columns["Thang"].HeaderText = "Tháng";
                    dataGridViewThongKe.Columns["DoanhThu"].HeaderText = "Doanh thu";
                    int TongDoanhThu = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int doanhThu = Convert.ToInt32(row["DoanhThu"]);
                        TongDoanhThu += doanhThu;
                    }
                    lblTongDoanhThu.Text = TongDoanhThu.ToString("N0") + "VNĐ";

                    chartDoanhThu.Series.Clear();
                    Series series = new Series("Doanh thu");
                    series.ChartType = SeriesChartType.Column;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int month = Convert.ToInt32(row["Thang"]);
                        int doanhThu = Convert.ToInt32(row["DoanhThu"]);
                        string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                        series.Points.AddXY(monthName, doanhThu);
                    }

                    chartDoanhThu.Series.Add(series);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


    }
}
