using HoanThien.FormChildCustomer;
using HoanThien.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThien.FormChildShipper
{
    public partial class frm_QuenMK : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_QuenMK()
        {
            InitializeComponent();
        }

        private void btn_xacnhanquenmk_Click(object sender, EventArgs e)
        {
            if (txt_quentaikhoan.Texts == "") { MessageBox.Show("Chưa nhập tài khoản"); return; };
            if (txt_quensdt.Texts == "") { MessageBox.Show("Chưa nhập số điện thoại"); return; };
            if (txt_quenemail.Texts == "") { MessageBox.Show("Chưa nhập email"); return; };
            int LengthSDT = 10;
            if (txt_quensdt.Texts.Length > LengthSDT) { MessageBox.Show("Số điện thoại phải 10 số"); return; }
            if (txt_quensdt.Texts.Length < LengthSDT) { MessageBox.Show("Số điện thoại phải 10 số"); return; }
            if (LoaiTK_cbbox.Texts == "Shipper")
            {
                using (SqlConnection connection = Sqlketnoi.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("SELECT * FROM Shipper WHERE TaiKhoanSP = @TaiKhoanSP", connection);
                    command.Parameters.AddWithValue("@TaiKhoanSP", txt_quentaikhoan.Texts);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        var TenTK = txt_quentaikhoan.Texts;
                        Shipper editObj = db.Shippers.Where(o => o.TaiKhoanSP.Equals(TenTK)).FirstOrDefault();
                        if (editObj.sdtShipper == txt_quensdt.Texts && editObj.emailSP == txt_quenemail.Texts)
                        {
                            MessageBox.Show("Mật khẩu cũ của bạn là '" + editObj.MatKhauSP + "'");
                        }
                        else
                        {
                            MessageBox.Show("Thông tin không trùng khớp");
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại tài khoản");
                    }
                }
            }
            else if (LoaiTK_cbbox.Texts == "KhachHang")
            {
                using (SqlConnection connection = Sqlketnoi.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE TaiKhoanKH = @TaiKhoanKH", connection);
                    command.Parameters.AddWithValue("@TaiKhoanKH", txt_quentaikhoan.Texts);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {

                        var TenTK = txt_quentaikhoan.Texts;
                        KhachHang editObj = db.KhachHangs.Where(o => o.TaiKhoanKH.Equals(TenTK)).FirstOrDefault();

                        if (editObj.SDTKH == txt_quensdt.Texts && editObj.emailKH == txt_quenemail.Texts)
                        {
                            MessageBox.Show("Mật khẩu cũ của bạn là '" + editObj.MatKhauKH + "'");
                        }
                        else
                        {
                            MessageBox.Show("Thông tin không trùng khớp");
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại tài khoản");
                    }
                }
            }
        }

        private void txt_quensdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
