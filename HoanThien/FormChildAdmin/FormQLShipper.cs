using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HoanThien.Forms
{
    public partial class FormQLShipper : Form
    {
        private bool isEditMode = false; 
        private int selectedRowIndex = -1; 
        private string connectionString = "Data Source=LAPTOP-DFSF0MK1\\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True"; // Chuỗi kết nối cơ sở dữ liệu

        public FormQLShipper()
        {
            InitializeComponent();
        }

       
        private void TextClear()
        {
            foreach (System.Windows.Forms.Panel pnl in PnlAdd.Controls.OfType<System.Windows.Forms.Panel>())
            {
                pnl.BackColor = Color.Gainsboro;
                foreach (System.Windows.Forms.TextBox txt in pnl.Controls.OfType<System.Windows.Forms.TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void InsertShipper(string maSP, string email, string tenShipper, string cccd, string sdtShipper, string taiKhoanSP, string matKhauSP, string diaChiSP)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Shipper (maSP, emailSP, tenShipper, cccd, sdtShipper, TaiKhoanSP, MatKhauSP, DiaChiSP) " +
                                   "VALUES (@MaSP, @Email, @TenShipper, @CCCD, @SDTShipper, @TaiKhoanSP, @MatKhauSP, @DiaChiSP)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSP);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@TenShipper", tenShipper);
                        command.Parameters.AddWithValue("@CCCD", cccd);
                        command.Parameters.AddWithValue("@SDTShipper", sdtShipper);
                        command.Parameters.AddWithValue("@TaiKhoanSP", taiKhoanSP);
                        command.Parameters.AddWithValue("@MatKhauSP", matKhauSP);
                        command.Parameters.AddWithValue("@DiaChiSP", diaChiSP);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chèn dữ liệu Shipper: " + ex.Message);
            }
        }

        private void UpdateShipper(string maSP, string email, string tenShipper, string cccd, string sdtShipper, string taiKhoanSP, string matKhauSP, string diaChiSP)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE Shipper SET emailSP = @Email, tenShipper = @TenShipper, cccd = @CCCD, sdtShipper = @SDTShipper, " +
                                   "TaiKhoanSP = @TaiKhoanSP, MatKhauSP = @MatKhauSP, DiaChiSP = @DiaChiSP WHERE MaSP = @MaSP";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@TenShipper", tenShipper);
                        command.Parameters.AddWithValue("@CCCD", cccd);
                        command.Parameters.AddWithValue("@SDTShipper", sdtShipper);
                        command.Parameters.AddWithValue("@TaiKhoanSP", taiKhoanSP);
                        command.Parameters.AddWithValue("@MatKhauSP", matKhauSP);
                        command.Parameters.AddWithValue("@DiaChiSP", diaChiSP);
                        command.Parameters.AddWithValue("@MaSP", maSP);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu Shipper: " + ex.Message);
            }
        }

        private void DeleteShipper(string maSP)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "DELETE FROM Shipper WHERE MaSP = @MaSP";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSP);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu Shipper: " + ex.Message);
            }
        }

        // Sự kiện click nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string email = txtEmail.Text;
            string tenShipper = txtTenSP.Text;
            string cccd = txtCCCD.Text;
            string sdtShipper = txtSDT.Text;
            string taiKhoanSP = txtUsername.Text;
            string matKhauSP = txtMatKhau.Text;
            string diaChiSP = txtDiaChi.Text;

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tenShipper) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(sdtShipper) || string.IsNullOrEmpty(taiKhoanSP) || string.IsNullOrEmpty(matKhauSP) || string.IsNullOrEmpty(diaChiSP))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các trường.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Vui lòng nhập định dạng email hợp lệ (VD: example@gmail.com).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (!int.TryParse(txtSDT.Text, out int phoneNumber) || txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (10 chữ số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cccdPattern = @"^\d{12}$";
            if (!Regex.IsMatch(txtCCCD.Text, cccdPattern))
            {
                MessageBox.Show("Vui lòng nhập căn cước công dân hợp lệ (12 chữ số).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


            if (isEditMode)
            {
                if (selectedRowIndex >= 0 && DGVShipper.Rows.Count > selectedRowIndex)
                {
                    DataGridViewRow selectedRow = DGVShipper.Rows[selectedRowIndex];
                    string CurrentmaSP = selectedRow.Cells["MaSP"].Value.ToString();

                    UpdateShipper(CurrentmaSP, email, tenShipper, cccd, sdtShipper, taiKhoanSP, matKhauSP, diaChiSP);
                    isEditMode = false;
                    selectedRowIndex = -1;
                    btnLuu.Text = "Thêm";
                    TextClear();
                    DGVShipper.Height = 467;
                    lblTitle.Text = "Quản Lý Shipper";
                    isEditMode = false;
                    selectedRowIndex = -1;
                }
            }
            else
            {
                InsertShipper(maSP, email, tenShipper, cccd, sdtShipper, taiKhoanSP, matKhauSP, diaChiSP);
                TextClear();
                DGVShipper.Height = 467;
                lblTitle.Text = "Quản Lý Shipper";
                isEditMode = false;
                selectedRowIndex = -1;
            }
            LoadData();
            TextClear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TextClear();
            DGVShipper.Height = 467;
            lblTitle.Text = "Quản Lý Shipper";
            isEditMode = false;
            selectedRowIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TextClear();
            DGVShipper.Height = 0;
            lblTitle.Text = "Bổ Sung Shipper";
            isEditMode = false;
            selectedRowIndex = -1;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TextClear();
            DGVShipper.Height = 0;
            lblTitle.Text = "Chỉnh Sửa Shipper";
            selectedRowIndex = DGVShipper.CurrentRow.Index;
            if (selectedRowIndex >= 0 && DGVShipper.Rows.Count > selectedRowIndex)
            {
                DataGridViewRow selectedRow = DGVShipper.Rows[selectedRowIndex];
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                string email = selectedRow.Cells["emailSP"].Value.ToString();
                string tenShipper = selectedRow.Cells["tenShipper"].Value.ToString();
                string cccd = selectedRow.Cells["cccd"].Value.ToString();
                string sdtShipper = selectedRow.Cells["sdtShipper"].Value.ToString();
                string taiKhoanSP = selectedRow.Cells["taiKhoanSP"].Value.ToString();
                string matKhauSP = selectedRow.Cells["matKhauSP"].Value.ToString();
                string diaChiSP = selectedRow.Cells["diaChiSP"].Value.ToString();

                txtMaSP.Text = maSP;
                txtEmail.Text = email;
                txtTenSP.Text = tenShipper;
                txtCCCD.Text = cccd;
                txtSDT.Text = sdtShipper;
                txtUsername.Text = taiKhoanSP;
                txtMatKhau.Text = matKhauSP;
                txtDiaChi.Text = diaChiSP;

                isEditMode = true;
                btnLuu.Text = "Lưu";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = DGVShipper.CurrentRow.Index;
                if (rowIndex >= 0 && DGVShipper.Rows.Count > rowIndex)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Shipper này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = DGVShipper.Rows[rowIndex];
                        string maSP = selectedRow.Cells["MaSP"].Value.ToString();

                        DeleteShipper(maSP);
                        LoadData();
                        TextClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            SearchShipper(searchText);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = txtSearch.Text.Trim();
                SearchShipper(searchText);
                e.Handled = true;
            }
        }

        private void SearchShipper(string searchText)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Shipper WHERE MaSP LIKE @SearchText OR emailSP LIKE @SearchText OR tenShipper LIKE @SearchText OR cccd LIKE @SearchText OR sdtShipper LIKE @SearchText";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DGVShipper.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm Shipper: " + ex.Message);
            }
        }
        private void FormQLShipper_Load(object sender, EventArgs e)
        {
            LoadData();
            DGVShipper.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Shipper";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DGVShipper.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Shipper: " + ex.Message);
            }
        }

        private void rjPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            SearchShipper(searchText);
        }


    }
}
