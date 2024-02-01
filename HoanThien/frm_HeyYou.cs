using HoanThien;
using HoanThien.FormChildShipper;
using HoanThien.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HoanThien
{
    public partial class frm_HeyYou : Form
    {

        public frm_HeyYou()
        {
            InitializeComponent();
        }

        private void DangNhap_btn_Click(object sender, EventArgs e)
        {

        }

        private void frm_HeyYou_Load(object sender, EventArgs e)
        {

        }

        private void Main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void MatKhau_txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjLogin4_Click(object sender, EventArgs e)
        {
            frm_QuenMK quenMK = new frm_QuenMK();
            quenMK.Show();
        }

        private void DangKy_btn_Click(object sender, EventArgs e)
        {   
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.Show();
        }

        private void DangNhap_btn_Click_1(object sender, EventArgs e)
        {
            if (LoaiTK_cbbox.Texts == "Shipper")
            {

                if (TaiKhoan_txt.Texts == "")
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản");
                    return;
                }
                if (MatKhau_txt.Texts == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                    return;
                }
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM Shipper WHERE TaiKhoanSP=@TaiKhoanSP AND MatKhauSP=@MatKhauSP", connection);
                connection.Open();
                command.Parameters.AddWithValue("@TaiKhoanSP", TaiKhoan_txt.Texts);
                command.Parameters.AddWithValue("@MatKhauSP", MatKhau_txt.Texts);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        BienSP.MaSP = reader.GetString(0);
                        BienSP.EmailSP = reader.GetString(1);
                        BienSP.Ten = reader.GetString(2);
                        BienSP.CCCD = reader.GetString(3);
                        BienSP.SDTSP = reader.GetString(4);
                        BienSP.TenTK = reader.GetString(5);
                        BienSP.MkSP = reader.GetString(6);
                        BienSP.DiachiSP = reader.GetString(7);

                    }
                    //Đóng form đăng nhập
                    this.Hide();
                    MessageBox.Show("đăng nhập thành công");

                    //Mở form chính
                    FormShipper mainForm = new FormShipper();
                    mainForm.Show();
                    reader.Close();
                    connection.Close();


                    connection.Open();
                    object storedShipperCode = command.ExecuteScalar();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }


            else if (LoaiTK_cbbox.Texts == "Quản Lý")
            {
                if (TaiKhoan_txt.Texts == "")
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản");
                    return;

                }
                if (MatKhau_txt.Texts == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                    return;

                }
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM QuanLy WHERE TaiKhoanQL=@TaiKhoanQL AND MatKhauQL=@MatKhauQL", connection);
                connection.Open();
                command.Parameters.AddWithValue("@TaiKhoanQL", TaiKhoan_txt.Texts);
                command.Parameters.AddWithValue("@MatKhauQL", MatKhau_txt.Texts);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    //Đóng form đăng nhập
                    this.Hide();
                    MessageBox.Show("đăng nhập thành công");

                    //Mở form chính
                    FormAdmin mainForm = new FormAdmin();
                    mainForm.Show();
                    reader.Close();
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }

            else if (LoaiTK_cbbox.Texts == "Khách Hàng")
            {
                if (TaiKhoan_txt.Texts == "")
                {
                    MessageBox.Show("Bạn chưa nhập tài khoản");
                    return;

                }
                if (MatKhau_txt.Texts == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                    return;

                }
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
                SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE TaiKhoanKH=@TaiKhoanKH AND MatKhauKH=@MatKhauKH", connection);
                connection.Open();
                command.Parameters.AddWithValue("@TaiKhoanKH", TaiKhoan_txt.Texts);
                command.Parameters.AddWithValue("@MatKhauKH", MatKhau_txt.Texts);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        BienKH.MaKH = reader.GetString(0);
                        BienKH.Ten = reader.GetString(1);
                        BienKH.EmailKH = reader.GetString(2);
                        BienKH.SDTKH = reader.GetString(3);
                        BienKH.TenTK = reader.GetString(4);
                        BienKH.MKhauKH = reader.GetString(5);
                    }

                    //Đóng form đăng nhập
                    this.Hide();
                    MessageBox.Show("đăng nhập thành công");

                    //Mở form chính
                    FormKhachHang KH = new FormKhachHang();
                    KH.Show();
                    reader.Close();
                    connection.Close();


                    connection.Open();
                    object storedShipperCode = command.ExecuteScalar();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
 
            else if (LoaiTK_cbbox.Texts == "Khách Hàng")
            {
             MessageBox.Show("bạn chưa chọn loại tài khoản");
            }
        }
    }
}
