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

namespace HoanThien.FormChildCustomer
{
    public partial class FormLichSu : Form
    {
        public FormLichSu()
        {
            InitializeComponent();
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            loadData_4_datahienthi();
        }
        private void loadData_4_datahienthi()
        {
            string makh = BienKH.MaKH;
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
            String command = "SELECT * FROM DonHang WHERE MaKH ='" + makh + "' AND Tinhtrangdonhang = N'Đã hoàn thành'";
            DataSet ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dap = new SqlDataAdapter(command, connection);
            dap.Fill(ds);
            datahienthi.DataSource = ds.Tables[0];
            datahienthi.Refresh();
            //DonHangDaNhan_dgv.Columns["Tinhtrangdonhang"].Visible = false;
            //DonHangDaNhan_dgv.Columns["MaSP"].Visible = false;
            datahienthi.Columns["MaKH"].Visible = false;
            datahienthi.Columns["MaQL"].Visible = false;
        }

        private void datahienthi_Resize_1(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "abc")
                {
                    f.Height = datahienthi.Height;
                    f.Width = datahienthi.Width;
                }
            }
        }

        private void datahienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
