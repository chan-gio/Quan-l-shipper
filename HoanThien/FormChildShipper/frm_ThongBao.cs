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
    public partial class frm_ThongBao : Form
    {
        String ma = BienSP.MaSP;
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
        public frm_ThongBao()
        {
            InitializeComponent();
        }

        private void lbl_donhangdanhan_Click(object sender, EventArgs e)
        {

        }
        private void loadData_4_DonHangDaGiao_dgv()
        {

            String command = "SELECT * FROM DonHang WHERE MaSP ='" + ma + "' AND Tinhtrangdonhang = N'Đã hoàn thành'";
            DataSet ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dap = new SqlDataAdapter(command, connection);
            dap.Fill(ds);
            DonHangDaGiao_dgv.DataSource = ds.Tables[0];
            DonHangDaGiao_dgv.Refresh();
            DonHangDaGiao_dgv.Columns["Tinhtrangdonhang"].Visible = false;
            DonHangDaGiao_dgv.Columns["MaSP"].Visible = false;
            DonHangDaGiao_dgv.Columns["MaKH"].Visible = false;
            DonHangDaGiao_dgv.Columns["MaQL"].Visible = false;
        }


        private void frm_ThongBao_Load(object sender, EventArgs e)
        {
            loadData_4_DonHangDaGiao_dgv();
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            int count = 0;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM DonHang WHERE MaSP ='" + ma + "' AND Tinhtrangdonhang = N'Đã hoàn thành' And  month(Thoidiemgiaohang) = @Thang  AND year(Thoidiemgiaohang) = @Nam ", connection);
            connection.Open();
            command.Parameters.AddWithValue("@Thang", Thang_cbbox.Texts);
            command.Parameters.AddWithValue("@Nam", Nam_cb.Texts);

            count = (int)command.ExecuteScalar();
            MessageBox.Show($"Số đơn hàng đã giao trong tháng là: {count}");
            connection.Close();
        }
    }
}
