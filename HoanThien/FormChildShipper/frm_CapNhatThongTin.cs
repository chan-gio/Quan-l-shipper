using HoanThien.FormChildCustomer;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace HoanThien.FormChildShipper
{
    public partial class frm_CapNhatThongTin : Form
    {


        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_CapNhatThongTin()
        {
            InitializeComponent();
        }
        private frm_TaiKhoan formTK; 
        
        public void SetFormTK (frm_TaiKhoan moi)
        {
            this.formTK = moi;
        }
        private const int LengthSDT = 10;
        private const int LengthCCCD = 12;


        private void btn_luu_Click(object sender, EventArgs e)
        {

            if (DoiTen_tb.Texts == "") MessageBox.Show("Tên không được để trống ");
            else if (!Doiemail_tb.Texts.Contains("@gmail.com")) MessageBox.Show("Không đúng kiểu email. Email phải có '@gmail.com'.");

            else if (DoiSdt_tb.Texts.Length > LengthSDT) MessageBox.Show("Số điện thoại phải 10 số");
            else if (DoiSdt_tb.Texts.Length < LengthSDT) MessageBox.Show("Số điện thoại phải 10 số");

            else if (DoiCCCD_tb.Texts.Length > LengthCCCD) MessageBox.Show("CCCD phải 12 số");
            else if (DoiCCCD_tb.Texts.Length < LengthCCCD) MessageBox.Show("CCCD phải 12 số");

            else if (DoiCCCD_tb.Texts == "") MessageBox.Show("CCCD không được để trống ");
            else if (Doiemail_tb.Texts == "") MessageBox.Show("Email không được để trống ");
            else if (DoiSdt_tb.Texts == "") MessageBox.Show("SĐT không được để trống ");
            else if (DoiDiaChi_tb.Texts == "") MessageBox.Show("Địa chỉ không được để trống ");
            else
            {
                try
                {

                    var maSP = BienSP.MaSP;
                    //code lưu trữ thông tin khóa học theo dữ liệu đã chỉnh sửa
                    Shipper editObj = db.Shippers.Where(o => o.MaSP.Equals(maSP)).FirstOrDefault();
                    editObj.tenShipper = DoiTen_tb.Texts;
                    editObj.sdtShipper = DoiSdt_tb.Texts;
                    editObj.cccd = DoiCCCD_tb.Texts;
                    editObj.emailSP = Doiemail_tb.Texts;
                    editObj.DiaChiSP = DoiDiaChi_tb.Texts;



                    String Doi_ten = DoiTen_tb.Texts;
                    String Doi_sDTSP = DoiSdt_tb.Texts;
                    String Doi_cCCD = DoiCCCD_tb.Texts;
                    String Doi_emailSP = Doiemail_tb.Texts;
                    String Doi_diachiSP = DoiDiaChi_tb.Texts;



                    MessageBox.Show("Sửa thành công");
                    BienSP.Ten = Doi_ten;
                    BienSP.SDTSP = Doi_sDTSP;
                    BienSP.EmailSP = Doi_emailSP;
                    BienSP.CCCD = Doi_cCCD;
                    BienSP.DiachiSP = Doi_diachiSP;

                    if (formTK != null)
                    {
                        formTK.load();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công");

                }

                db.SubmitChanges();
            }

        }

        private void frm_capnhat_load(object sender, EventArgs e)
        {
            DoiTen_tb.Texts = BienSP.Ten;
            DoiSdt_tb.Texts = BienSP.SDTSP;
            DoiCCCD_tb.Texts = BienSP.CCCD;
            Doiemail_tb.Texts = BienSP.EmailSP;
            DoiDiaChi_tb.Texts = BienSP.DiachiSP;
        }

        private void DoiSdt_tb__TextChanged(object sender, EventArgs e)
        {

        }

        private void DoiSdt_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DoiCCCD_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Doiemail_tb_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Doiemail_tb__TextChanged(object sender, EventArgs e)
        {
        }
    }
}
