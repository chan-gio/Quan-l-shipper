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
    public partial class FormKh : Form
    {
        public FormKh()
        {
            InitializeComponent();
        }

        public void load()
        {
            txt_TenTK.Texts = BienKH.TenTK;
            txt_Ten.Texts = BienKH.Ten;
            txt_Email.Texts = BienKH.EmailKH;
            txt_SDT.Texts = BienKH.SDTKH;
            if (txt_Ten.Texts == "" || txt_TenTK.Texts == "" || txt_Email.Texts == "" || txt_SDT.Texts == "")
            {
                MessageBox.Show("Vui lòng cập nhật thông tin của bạn");
            }
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thongtincanhan ttcn = new thongtincanhan();
            ttcn.Show();
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjLogin4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }



        private void FormKh_Load(object sender, EventArgs e)
        {
            txt_TenTK.Texts = BienKH.TenTK;
            txt_Ten.Texts = BienKH.Ten;
            txt_Email.Texts = BienKH.EmailKH;
            txt_SDT.Texts = BienKH.SDTKH;
            txt_SDT.KeyPress += SDT_KeyPress;
            txt_TenTK.ReadOnly = true;
            txt_Ten.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_SDT.ReadOnly = true;

        }
        private void rjLogin1_Click(object sender, EventArgs e)
        {
            thongtincanhan thongtin = new thongtincanhan();
            thongtin.SetFormKh(this);
            thongtin.ShowDialog();
        }

        private void btn_DoiMk_Click(object sender, EventArgs e)
        {
            frm_DoiMKKH doiMKKH = new frm_DoiMKKH();
            doiMKKH.ShowDialog();
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            load();
        }

        private void TenTK__TextChanged(object sender, EventArgs e)
        {

        }

        private void SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            else if (txt_SDT.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


    }
}


