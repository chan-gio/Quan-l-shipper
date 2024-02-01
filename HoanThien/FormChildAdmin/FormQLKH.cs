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

namespace HoanThien.Forms
{
    public partial class FormQLKH : Form
    {
        private string connectionString = "Data Source=LAPTOP-DFSF0MK1\\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True";
        private string MaKH;

        public FormQLKH()
        {
            InitializeComponent();
            LayDSKH();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtEmailKH.Text) || string.IsNullOrEmpty(txtSDTKH.Text) || string.IsNullOrEmpty(txtTaiKhoanKH.Text) || string.IsNullOrEmpty(txtMatKhauKH.Text) || string.IsNullOrEmpty(txtDiaChiKH.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các trường.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Dừng việc thêm thông tin nếu có textbox rỗng
                    }
                    if (!txtEmailKH.Text.EndsWith("@gmail.com"))
                    {
                        MessageBox.Show("Vui lòng nhập định dạng email hợp lệ (VD: example@gmail.com).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Dừng việc thêm thông tin nếu định dạng email không hợp lệ
                    }

                    // Kiểm tra giá trị số và độ dài của số điện thoại
                    if (!int.TryParse(txtSDTKH.Text, out int phoneNumber) || txtSDTKH.Text.Length != 10)
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (10 chữ số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Dừng việc thêm thông tin nếu số điện thoại không hợp lệ
                    }

                    string query = "INSERT INTO KhachHang VALUES (@MaKH, @TenKH, @EmailKH, @SDTKH, @TaiKhoanKH, @MatKhauKH, @DiaChiKH)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    command.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    command.Parameters.AddWithValue("@EmailKH", txtEmailKH.Text);
                    command.Parameters.AddWithValue("@SDTKH", txtSDTKH.Text);
                    command.Parameters.AddWithValue("@TaiKhoanKH", txtTaiKhoanKH.Text);
                    command.Parameters.AddWithValue("@MatKhauKH", txtMatKhauKH.Text);
                    command.Parameters.AddWithValue("@DiaChiKH", txtDiaChiKH.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thông tin khách hàng thành công");
                    ClearInputFields();
                    LayDSKH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE KhachHang SET TenKH = @TenKH, EmailKH = @EmailKH, SDTKH = @SDTKH, TaiKhoanKH = @TaiKhoanKH, MatKhauKH = @MatKhauKH, DiaChiKH = @DiaChiKH WHERE MaKH = @MaKH";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                    command.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    command.Parameters.AddWithValue("@EmailKH", txtEmailKH.Text);
                    command.Parameters.AddWithValue("@SDTKH", txtSDTKH.Text);
                    command.Parameters.AddWithValue("@TaiKhoanKH", txtTaiKhoanKH.Text);
                    command.Parameters.AddWithValue("@MatKhauKH", txtMatKhauKH.Text);
                    command.Parameters.AddWithValue("@DiaChiKH", txtDiaChiKH.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                    ClearInputFields();
                    LayDSKH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        private void XoaKhachHang(string MaKH)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKH", MaKH);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu KH: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int rowIndex = DGVKhachHang.CurrentRow.Index;
            if (rowIndex >= 0 && DGVKhachHang.Rows.Count > rowIndex)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khach hang này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = DGVKhachHang.Rows[rowIndex];
                    string MaKH = selectedRow.Cells["MaKH"].Value.ToString();

                    XoaKhachHang(MaKH);
                    LayDSKH();
                    
                }
            }
        }

        private void LayDSKH()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM KhachHang";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGVKhachHang.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void ClearInputFields()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtEmailKH.Clear();
            txtSDTKH.Clear();
            txtTaiKhoanKH.Clear();
            txtMatKhauKH.Clear();
            txtDiaChiKH.Clear();
        }

        private void rjPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtEmailKH.Text = row.Cells["EmailKH"].Value.ToString();
                txtSDTKH.Text = row.Cells["SDTKH"].Value.ToString();
                txtTaiKhoanKH.Text = row.Cells["TaiKhoanKH"].Value.ToString();
                txtMatKhauKH.Text = row.Cells["MatKhauKH"].Value.ToString();
                txtDiaChiKH.Text = row.Cells["DiaChiKH"].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LayDSKH();
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
