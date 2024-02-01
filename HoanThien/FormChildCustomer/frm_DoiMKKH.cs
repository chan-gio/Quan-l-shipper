using HoanThien.FormChildShipper;
using HoanThien.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoanThien.FormChildCustomer
{
    public partial class frm_DoiMKKH : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_DoiMKKH()
        {
            InitializeComponent();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_mkcu.Texts == "") MessageBox.Show("Chưa nhập mật khẩu cũ ");
            else if (txt_mkcu.Texts != BienKH.MKhauKH) MessageBox.Show("Mật khẩu cũ không chính xác ");
            else if (txt_mkmoi.Texts == "") MessageBox.Show("Chưa nhập mật khẩu mới ");
            else if (txt_nhaplaimkmoi.Texts == "") MessageBox.Show("Chưa nhập lại mật khẩu mới ");
            else if (txt_mkmoi.Texts != txt_nhaplaimkmoi.Texts) MessageBox.Show("Mật khẩu không trùng khớp ");

            else
            {
                try
                {
                    var maKH = BienKH.MaKH;
                    //code lưu trữ thông tin đổi mật khẩu
                    KhachHang editObj = db.KhachHangs.Where(o => o.MaKH.Equals(maKH)).FirstOrDefault();
                    editObj.MatKhauKH = txt_mkmoi.Texts;

                    String DoiMK_KH = txt_mkmoi.Texts;

                    MessageBox.Show("Đổi thành công");
                    BienKH.MKhauKH = DoiMK_KH;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đổi không thành công");

                }

                db.SubmitChanges();


            }
        }

        private void btn_quenmk_Click(object sender, EventArgs e)
        {
            frm_QuenMK quenMK = new frm_QuenMK();
            quenMK.Show();
        }
    }
}
