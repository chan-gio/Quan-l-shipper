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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HoanThien.FormChildShipper
{
    public partial class frm_TaiKhoan : Form
    {
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {

            load();


        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            frm_CapNhatThongTin c = new frm_CapNhatThongTin();
            c.SetFormTK(this);
            c.ShowDialog();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            frm_doiMK d = new frm_doiMK();
            d.ShowDialog();
        }

        public void load()
        {
            TenTK_tb.Texts = BienSP.TenTK;
            Ten_tb.Texts = BienSP.Ten;
            Sdt_tb.Texts = BienSP.SDTSP;
            CCCD_tb.Texts = BienSP.CCCD;
            email_tb.Texts = BienSP.EmailSP;
            DiaChi_tb.Texts = BienSP.DiachiSP;
            if (TenTK_tb.Texts == "" || TenTK_tb.Texts == "" || Sdt_tb.Texts == "" || CCCD_tb.Texts == "" || email_tb.Texts == "" || DiaChi_tb.Texts == "")
                MessageBox.Show("Vui lòng cập nhật thông tin của bạn  ");
        }
    }
}
