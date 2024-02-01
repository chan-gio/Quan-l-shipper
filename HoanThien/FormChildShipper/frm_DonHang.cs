using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using HoanThien.RJControls;

namespace HoanThien.FormChildShipper
{

    public partial class frm_DonHang : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_DonHang()
        {
            InitializeComponent();

        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjLogin2_Click(object sender, EventArgs e)
        {

        }
        private void loadData_4_DSDonHang_dgv()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
            String command = "SELECT * FROM DonHang WHERE MaSP='' or MaSP is Null";
            DataSet ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dap = new SqlDataAdapter(command, connection);
            dap.Fill(ds);
            DanhSachDonHang_dgv.DataSource = ds.Tables[0];
            DanhSachDonHang_dgv.Refresh();
            DanhSachDonHang_dgv.Columns["Tinhtrangdonhang"].Visible = false;
            DanhSachDonHang_dgv.Columns["MaSP"].Visible = false;
            DanhSachDonHang_dgv.Columns["MaKH"].Visible = false;
            DanhSachDonHang_dgv.Columns["MaQL"].Visible = false;
            DanhSachDonHang_dgv.Columns["Thoidiemgiaohang"].Visible = false;


        }
        private void frm_DonHang_Load(object sender, EventArgs e)
        {
            loadData_4_DSDonHang_dgv();

        }

        private void DanhSachDonHang_dgv_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void rjLogin1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DanhSachDonHang_dgv.SelectedRows.Count > 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                    connection.Open();
                    foreach (DataGridViewRow row in DanhSachDonHang_dgv.SelectedRows)
                    {
                        SqlCommand command = new SqlCommand("UPDATE DonHang SET MaSP = @MaSP, Tinhtrangdonhang = N'Đang vận chuyển' WHERE MaDon = @MaDon", connection);
                        command.Parameters.AddWithValue("@MaSP", BienSP.MaSP);
                        command.Parameters.AddWithValue("@MaDon", row.Cells["MaDon"].Value);
                        int result = command.ExecuteNonQuery();
                        db.SubmitChanges();
                        connection.Close();
                    }
                    MessageBox.Show("Nhận hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData_4_DSDonHang_dgv();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần nhận !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frm_DonHang_Resize(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "frm_QuanLyKhoaHoc")
                {
                    f.Height = DanhSachDonHang_dgv.Height;
                    f.Width = DanhSachDonHang_dgv.Width;
                }
            }
        }
    }

}

