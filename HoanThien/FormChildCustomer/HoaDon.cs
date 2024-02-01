using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThien.FormChildCustomer
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        public void ThongTinHh
              (
              bool NhStatus,
              String StrNguoigui,
              String StrSdt,
              String StrDiaChi,
              String StrNguoinhan,
              String StrSdtNn,
              String StrDiaChiNn,
              String StrTenHang,
              String StrLoaiHang

              )
        {
            if (NhStatus)
            {
                HoTenNg.Text = StrNguoigui;
                SdtNg.Text = StrSdt;
                DiaChiNg.Text = StrDiaChi;
                HoTenNn.Text = StrNguoinhan;
                SdtNn.Text = StrSdtNn;
                DiaChiNn.Text = StrDiaChiNn;
                TenHang.Text = StrTenHang;
                LoaiHang.Text = StrLoaiHang;
            }
            else
            {

            }
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
           
            //this.reportViewer1.RefreshReport();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjLogin1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Sqlketnoi.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;

                    string csdl = "INSERT INTO DonHang (MaDon, TenHang, TenNguoiNhan, SDTNN, Diachinhanhang, DiaChigiaohang,  Tinhtrangdonhang,Thoidiemgiaohang ,Thoidiemdathang, Loai_Hang) VALUES (@MaDon, @TenHang, @NguoiNhan, @SdtNn, @DiaChiNhan, @DiaChiGiao,  @tinhtrangdon,@Thoidiemgiaohang ,@Thoidiemdathang ,@LoaiHang)";

                    string Madon = TaoMaMoi("DH");
                    string thoiDiemDat = DateTime.Now.ToString("yyyy-MM-dd");
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@MaDon", Madon);
                    command.Parameters.AddWithValue("@TenHang", TenHang.Text);
                    command.Parameters.AddWithValue("@NguoiNhan", HoTenNn.Text);
                    command.Parameters.AddWithValue("@SdtNn", SdtNn.Text);
                    command.Parameters.AddWithValue("@DiaChiNhan", DiaChiNn.Text);
                    command.Parameters.AddWithValue("@DiaChiGiao", DiaChiNg.Text);
                    command.Parameters.AddWithValue("@tinhtrangdon", "Chưa hoàn thành");
                    command.Parameters.AddWithValue("@Thoidiemgiaohang", thoiDiemDat);
                    command.Parameters.AddWithValue("@Thoidiemdathang", thoiDiemDat);
                    command.Parameters.AddWithValue("@LoaiHang", LoaiHang.Text);
                    command.CommandText = csdl;


                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Lưu đơn thành công!");
                        this.Close();
                       
                    }
                    else
                    {

                        MessageBox.Show("Lưu đơn thất bại!");
                        this.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private string TaoMaMoi(string Don)
        {
            string newCode = "";
            using (SqlConnection connection = Sqlketnoi.GetConnection())
            {
                connection.Open();

                bool trungma = true;
                while (trungma)
                {
                    Random random = new Random();
                    string randomString = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 4)
                                                     .Select(s => s[random.Next(s.Length)]).ToArray());
                    newCode = Don + randomString;
                    string query = "";
                    if (Don == "DH")
                    {
                        query = "SELECT COUNT(*) FROM DonHang WHERE MaDon = @MaDon";

                    }
              
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaDon", newCode);
                    int count = (int)command.ExecuteScalar();
                    trungma = (count > 0);
                }

                return newCode;
            }
        }
    }


}

    


