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
    public partial class frm_doiMK : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_doiMK()
        {
            InitializeComponent();
        }

        private void rjLogin4_Click(object sender, EventArgs e)
        {
            frm_QuenMK quenMK = new frm_QuenMK();
            quenMK.Show();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-DFSF0MK1\SQLEXPRESS;Initial Catalog=QuanLyShipper;Integrated Security=True");
        private void btn_xacnhan_Click_1(object sender, EventArgs e)
        {
            if (txt_mkcu.Texts == "") MessageBox.Show("Chưa nhập mật khẩu cũ ");
            else if (txt_mkcu.Texts != BienSP.MkSP) MessageBox.Show("Mật khẩu cũ không chính xác ");
            else if (txt_mkmoi.Texts == "") MessageBox.Show("Chưa nhập mật khẩu mới ");
            else if (txt_nhaplaimkmoi.Texts == "") MessageBox.Show("Chưa nhập lại mật khẩu mới ");
            else if (txt_mkmoi.Texts != txt_nhaplaimkmoi.Texts) MessageBox.Show("Mật khẩu không trùng khớp ");

            else
            {
                try
                {
                    var maSP = BienSP.MaSP;
                    //code lưu trữ thông tin đổi mật khẩu
                    Shipper editObj = db.Shippers.Where(o => o.MaSP.Equals(maSP)).FirstOrDefault();
                    editObj.MatKhauSP = txt_mkmoi.Texts;

                    String DoiMK_SP = txt_mkmoi.Texts;

                    MessageBox.Show("Đổi thành công");
                    BienSP.MkSP = DoiMK_SP;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đổi không thành công");

                }

                db.SubmitChanges();


            }
        }
    }
}
