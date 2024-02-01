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
    public partial class thongtincanhan : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public thongtincanhan()
        {
            InitializeComponent();
        }
        private FormKh formKh;

        public void SetFormKh(FormKh formKh)
        {
            this.formKh = formKh;
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (TenKH.Text == "") MessageBox.Show("Tên không được để trống ");
            else if (SDT.Text == "") MessageBox.Show("SĐT không được để trống ");
            else if (Email.Text == "") MessageBox.Show("Địa chỉ không được để trống ");
            else if (!Email.Text.Contains("@gmail.com")) MessageBox.Show("Không đúng kiểu email");
            else if (SDT.Text.Length < 10) MessageBox.Show("Số điện thoại phải có 10 số");
            else
            {
                try
                {

                    var maKH = BienKH.MaKH;
                    //code lưu trữ thông tin khóa học theo dữ liệu đã chỉnh sửa
                    KhachHang editObj = db.KhachHangs.Where(o => o.MaKH.Equals(maKH)).FirstOrDefault();
                    editObj.TenKH = TenKH.Text;
                    editObj.SDTKH = SDT.Text;
                    editObj.emailKH = Email.Text;



                    String Doi_ten = TenKH.Text;
                    String Doi_emailKH = Email.Text;
                    String Doi_SDTKH = SDT.Text;



                    MessageBox.Show("Sửa thành công");
                    BienKH.Ten = Doi_ten;
                    BienKH.SDTKH = Doi_SDTKH;
                    BienKH.EmailKH = Doi_emailKH;

                    if (formKh != null)
                    {
                        formKh.load();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công");

                }

                db.SubmitChanges();
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
           this.Hide();
           this.Close();   
        }
        private void thongtincanhan_Load(object sender, EventArgs e)
        {
            TenKH.Text = BienKH.Ten;
            SDT.Text = BienKH.SDTKH;
            Email.Text = BienKH.EmailKH;
            SDT.KeyPress += SDT_KeyPress;
        }

        private void SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // chỉ cho phép điền số
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else if (SDT.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                // Kiểm tra nếu độ dài của TextBox đã đạt tối đa và không phải là phím backspace
                // Loại bỏ ký tự không hợp lệ bằng cách không cho phép sự kiện KeyPress xảy ra
                e.Handled = true;
            }
        }
    }
}
