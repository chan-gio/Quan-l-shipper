using HoanThien;
using HoanThien.FormChildShipper;
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


namespace HoanThien
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
        private void LoaiTK_cbbox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangKyTK_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhapLaiMK_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void DangKy_btn_Click(object sender, EventArgs e)
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

                    if (LoaiTK_cbbox.Texts == "Shipper")
                    {
                        // Kiểm tra tài khoản Shipper đã tồn tại chưa
                        string selectShipperQuery = "SELECT COUNT(*) FROM Shipper WHERE TaiKhoanSP = @TaiKhoanSP";
                        command.Parameters.AddWithValue("@TaiKhoanSP", DangKyTK_txt.Texts);
                        command.Connection = connection;
                        command.CommandText = selectShipperQuery;

                        int shipperCount = (int)command.ExecuteScalar();
                        if (shipperCount > 0)
                        {
                            MessageBox.Show("Tài khoản Shipper đã tồn tại!");
                            return;
                        }

                        // Thực hiện truy vấn INSERT vào bảng Shipper

                        string csdl = "insert into Shipper(MaSP, TaiKhoanSP, MatKhauSP, emailSP, tenShipper, cccd, sdtShipper,DiaChiSP) values(@MaSP, @TaiKhoanSP, @MatKhauSP,@emailSP, @tenShipper, @cccd, @sdtShipper, @DiaChiSP)";
                        string MaSP = TaoMaMoi("SP");
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@MaSP", MaSP);
                        command.Parameters.AddWithValue("@TaiKhoanSP", DangKyTK_txt.Texts);
                        command.Parameters.AddWithValue("@MatKhauSP", DangKyMK_txt.Texts);
                        command.Parameters.AddWithValue("@emailSP", "");
                        command.Parameters.AddWithValue("@tenShipper", "");
                        command.Parameters.AddWithValue("@cccd", "");
                        command.Parameters.AddWithValue("@sdtShipper", "");
                        command.Parameters.AddWithValue("@DiaChiSP", "");
                        command.Connection = connection;
                        command.CommandText = csdl;
                        
                    }
                    else if (LoaiTK_cbbox.Texts == "KhachHang")
                    {
                        // Kiểm tra tài khoản KhachHang đã tồn tại chưa
                        string selectKhachHangQuery = "SELECT COUNT(*) FROM KhachHang WHERE TaiKhoanKH = @TaiKhoanKH";
                        command.Parameters.AddWithValue("@TaiKhoanKH", DangKyTK_txt.Texts);
                        command.Connection = connection;
                        command.CommandText = selectKhachHangQuery;

                        int khachHangCount = (int)command.ExecuteScalar();
                        if (khachHangCount > 0)
                        {
                            MessageBox.Show("Tài khoản Khách hàng đã tồn tại!");
                            return;
                        }

                        // Thực hiện truy vấn INSERT vào bảng KhachHang
                        string csdl = "insert into KhachHang(MaKH, TaiKhoanKH, MatKhauKH, TenKH, emailKH, SDTKH) values(@MaKH, @TaiKhoanKH, @MatKhauKH, @TenKH, @emailKH, @SDTKH)";
                        string MaKH = TaoMaMoi("KH");
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@MaKH", MaKH);
                        command.Parameters.AddWithValue("@TaiKhoanKH", DangKyTK_txt.Texts);
                        command.Parameters.AddWithValue("@MatKhauKH", DangKyMK_txt.Texts);
                        command.Parameters.AddWithValue("@TenKH", "");
                        command.Parameters.AddWithValue("@emailKH", "");
                        command.Parameters.AddWithValue("@SDTKH", "");
                        command.Connection = connection;
                        command.CommandText = csdl;
                    }

                    else
                    {
                        MessageBox.Show("Vui lòng chọn loại tài khoản");
                    }

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thàng công!");
                    }
                    else
                    {

                        MessageBox.Show("Đăng ký tài khoản thất bại!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private string TaoMaMoi(string prefix)
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
                    newCode = prefix + randomString;
                    string query = "";
                    if (prefix == "SP")
                    {
                        query = "SELECT COUNT(*) FROM Shipper WHERE MaSP = @MaSP";

                    }
                    else if (prefix == "KH")
                    {
                        query = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSP", newCode);
                    command.Parameters.AddWithValue("@MaKH", newCode);
                    int count = (int)command.ExecuteScalar();
                    trungma = (count > 0);
                }

                return newCode;
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HeyYou frmDN = new frm_HeyYou();
            frmDN.Show();
        }


    }
}
