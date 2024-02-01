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

namespace HoanThien.FormChildShipper
{
    public partial class frm_chitietdonhang : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_chitietdonhang()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_chitietdonhang_Load(object sender, EventArgs e)
        {
            try
            {
                var MaDon = BienSP.Madonhang;
                //code lưu trữ thông tin khóa học theo dữ liệu đã chỉnh sửa
                DonHang editObj = db.DonHangs.Where(o => o.MaDon.Equals(MaDon)).FirstOrDefault();
                ht_tenhang_txt.Texts = editObj.TenHang;
                ht_diachi_txt.Texts = editObj.DiaChigiaohang;
                ht_loaihang_txt.Texts = editObj.Loai_Hang;
                ht_tennguoinhan_txt.Texts = editObj.TenNguoiNhan;
                ht_madonhang_txt.Texts = editObj.MaDon;
                ht_sdt_txt.Texts = editObj.SDTNN;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xem được đơn hàng");

            }
        }
    }
}
