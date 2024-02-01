using HoanThien.RJControls;
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

namespace HoanThien.FormChildShipper
{
    public partial class frm_VanChuyen : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_VanChuyen()
        {
            InitializeComponent();
        }

        private void loadData_4_DSDonHang_dgv()
        {
            String ma = BienSP.MaSP;
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
            String command = "SELECT * FROM DonHang WHERE MaSP ='" + ma +"' AND Tinhtrangdonhang = N'Đang vận chuyển'";
            DataSet ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dap = new SqlDataAdapter(command, connection);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            dataGridView1.Columns["Tinhtrangdonhang"].Visible = false;
            dataGridView1.Columns["MaSP"].Visible = false;
            dataGridView1.Columns["MaKH"].Visible = false;
            dataGridView1.Columns["MaQL"].Visible = false;
            dataGridView1.Columns["Thoidiemgiaohang"].Visible = false;
        }
     

        private void btn_dagiao_Click(object sender, EventArgs e)
        {
            try
            {
           
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        SqlCommand command = new SqlCommand("UPDATE DonHang SET Tinhtrangdonhang = N'Đã hoàn thành', Thoidiemgiaohang = @Thoidiemgiaohang WHERE MaDon = @MaDon", connection);
                        string thoiDiemGiaoHang = DateTime.Now.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@MaDon", row.Cells["MaDon"].Value);
                        command.Parameters.AddWithValue("@Thoidiemgiaohang", thoiDiemGiaoHang);
                        int result = command.ExecuteNonQuery();
                        db.SubmitChanges();
                        connection.Close();
                    }
                    MessageBox.Show("Giao hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData_4_DSDonHang_dgv();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần hoàn thành !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_chitietdonhang_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    BienSP.Madonhang = Convert.ToString(row.Cells["MaDon"].Value);
                    frm_chitietdonhang ctdh = new frm_chitietdonhang();
                    ctdh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần xem chi tiết !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frm_VanChuyen_Load_1(object sender, EventArgs e)
        {
            loadData_4_DSDonHang_dgv();
        }

        private void btn_huydon_Click_1(object sender, EventArgs e)
        {
            try
            {
                String ma = null;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        SqlCommand command = new SqlCommand("UPDATE DonHang SET MaSP = Null, Tinhtrangdonhang = 'Chưa hoàn thành' WHERE MaDon = @MaDon ", connection);
                        command.Parameters.AddWithValue("@MaDon", row.Cells["MaDon"].Value);
                        command.ExecuteNonQuery();
                        Console.WriteLine(ma);
                        ; db.SubmitChanges();
                        connection.Close();
                    }
                    MessageBox.Show("Hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData_4_DSDonHang_dgv();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng cần hủy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_huydon_Resize(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "abc")
                {
                    f.Height = dataGridView1.Height;
                    f.Width = dataGridView1.Width;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_donhangdanhan_Click(object sender, EventArgs e)
        {

        }
    }
}
