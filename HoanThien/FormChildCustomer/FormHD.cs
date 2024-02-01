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
using System.Windows.Forms;

namespace HoanThien.FormChildCustomer
{
    public partial class FormHD : Form
    {
        public FormHD()
        {
            InitializeComponent();
        }

        // Con trỏ để tạo hóa đơn 
        public delegate void BenNhanHang
            (
            bool NhStatus,
            String StrNguoigui,
            String StrSdt,
            String StrDiaChi,
            String StrNguoinhan,
            String StrSdtNn,
            String StrDiaChiNn,
            String StrTenHang,
            String StrLoaiHang,
            String StrGiaTri

            );

        public BenNhanHang DNhanhang;

        private void button6_Click(object sender, EventArgs e)
        {
            if (TxtNguoiGui.Text == "")
            {
                MessageBox.Show
                (
                    "Bạn chưa nhập họ tên!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                TxtNguoiGui.Focus();
                return;
            }
            string nguoiGui = TxtNguoiGui.Text;
            Regex NG = new Regex(@"^[\p{L}\s]+$");
            if (!NG.IsMatch(nguoiGui))
            {
                MessageBox.Show("Tên bạn không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtNguoiGui.Focus();
                return;
            }

            //SDT nguoi gui
            else if (TxtSdtNg.Text == "")
            {
                MessageBox.Show
                (
                    "Bạn chưa nhập số điện thoại!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                );
                return;
            }
            if (!int.TryParse(TxtSdtNg.Text, out int strsdtng) || TxtSdtNg.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Dừng việc thêm thông tin nếu số điện thoại không hợp lệ
            }

            //Dia chi nguoi gui
            else if (TxtDiaChiNg.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập địa chỉ!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtDiaChiNg.Focus();
                return;
            }
            string diaching = TxtDiaChiNg.Text;
            Regex diachiNG = new Regex(@"^[a-zA-Z0-9\p{L}\s]+$");
            if (!diachiNG.IsMatch(diaching))
            {
                MessageBox.Show("Địa chỉ lấy hàng không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtDiaChiNg.Focus();
                return;
            }

            //Nguoi nhan
            else if (TxtNguoiNhan.Text == "")
            {
                MessageBox.Show
                    (
                    "Bạn chưa nhập họ tên người nhận!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                TxtNguoiNhan.Focus();
                return;
            }
            string nguoinhan = TxtNguoiNhan.Text;
            Regex NN = new Regex(@"^[\p{L}\s]+$");
            if (!NN.IsMatch(nguoinhan))
            {
                MessageBox.Show("Tên người nhận không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtNguoiNhan.Focus();
                return;
            }

            //SDT nguoi nhan
            else if (TxtSdtNn.Text == "")
            {
                MessageBox.Show
                (
                    "Bạn chưa nhập số điện thoại người nhận!", "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                );
                return;
            }


            else
            {
                String StrNguoigui = TxtNguoiGui.Text;
                String StrSdt = TxtSdtNg.Text;
                String StrDiaChi = TxtDiaChiNg.Text;
                String StrNguoinhan = TxtNguoiNhan.Text;
                String StrSdtNn = TxtSdtNn.Text;
                String StrDiaChiNn = TxtDiaChiNn.Text;
                String StrTenHang = TxtTenHang.Text;
                String StrLoaiHang = TxtLoaiHang.Text;



                MessageBox.Show("Bạn tạo đơn hàng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các giá trị trên formHoaDon để chuẩn bị cho đơn hàng tiếp theo


                HoaDon f = new HoaDon();
                f.ThongTinHh(true, TxtNguoiGui.Text, TxtSdtNg.Text, TxtDiaChiNg.Text, TxtNguoiNhan.Text, TxtSdtNn.Text, TxtDiaChiNn.Text, TxtTenHang.Text, TxtLoaiHang.Text);
                f.ShowDialog();
            }

        }
        private void FormHD_Load(object sender, EventArgs e)
        {

        }

        private void TxtSdtNg_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSdtNn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNguoiGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtNguoiNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtNguoiGui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TxtNguoiNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}

