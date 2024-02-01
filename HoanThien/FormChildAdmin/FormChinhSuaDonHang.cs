using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HoanThien.Forms
{
    public partial class FormChinhSuaDonHang : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=LAPTOP-DFSF0MK1\\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True";  // Thay thế YOUR_CONNECTION_STRING bằng chuỗi kết nối tới cơ sở dữ liệu của bạn
        private string maDon;

        public FormChinhSuaDonHang(string maDon)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            this.maDon = maDon;
        }

        private void FormChinhSuaDonHang_Load(object sender, EventArgs e)
        {
            LoadDonHangData();
        }

        private void LoadDonHangData()
        {
            string query = "SELECT * FROM DonHang WHERE MaDon = @MaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@MaDon", maDon);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                // Hiển thị thông tin đơn hàng lên các điều khiển trên form
                txtMaDon.Text = dataTable.Rows[0]["MaDon"].ToString();
                txtTenHang.Text = dataTable.Rows[0]["TenHang"].ToString();
                txtDiaChiNhanHang.Text = dataTable.Rows[0]["Diachinhanhang"].ToString();
                txtMaSP.Text = dataTable.Rows[0]["MaSP"].ToString();
                // ...
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenHang = txtTenHang.Text.Trim();
            string diaChi = txtDiaChiNhanHang.Text.Trim();
            string maSP = txtMaSP.Text.Trim();
            // ...

            string updateQuery = "UPDATE DonHang SET TenHang = @TenHang, Diachinhanhang = @DiaChi, MaSP = @MaSP WHERE MaDon = @MaDon";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@TenHang", tenHang);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@MaDon", maDon);
                if (string.IsNullOrEmpty(maSP)) 
                {
                    command.Parameters.AddWithValue("@MaSP", DBNull.Value); // 
                }
                else
                {
                    command.Parameters.AddWithValue("@MaSP", maSP);
                }

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã cập nhật thông tin đơn hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin đơn hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void txtMaDon_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
