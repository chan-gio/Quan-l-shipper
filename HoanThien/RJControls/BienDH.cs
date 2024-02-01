using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace QuanLyShipper.RJControls
{ 	
    public class BienDH
    {
        private static string MaDon;
        private static string TenHang;
        private static string Diachinhanhang;
        private static string Diachigiaohang;
        private static string Thoidiemnhanhang;
        private static string Tinhtrangdonhang;
        private static string MaSP;
        private static string MaKH;
        private static string MaQL;
        private static string LoaiHang;

        public static string maDon { get => MaDon; set => MaDon = value; }
        public static string tenHang1 { get => TenHang; set => TenHang = value; }
        public static string diachinhanhang1 { get => Diachinhanhang; set => Diachinhanhang = value; }
        public static string diachigiaohang1 { get => Diachigiaohang; set => Diachigiaohang = value; }
        public static string thoidiemnhanhang1 { get => Thoidiemnhanhang; set => Thoidiemnhanhang = value; }
        public static string tinhtrangdonhang1 { get => Tinhtrangdonhang; set => Tinhtrangdonhang = value; }
        public static string maSP { get => MaSP; set => MaSP = value; }
        public static string maKH { get => MaKH; set => MaKH = value; }
        public static string maQL { get => MaQL; set => MaQL = value; }
        public static string loaiHang1 { get => LoaiHang; set => LoaiHang = value; }
    }
    public class Tinhtrangdonhang
    {
        protected string tinhtrang;

        public string Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
    }

    public class DaHoanThanh : Tinhtrangdonhang
    {
        public DaHoanThanh()
        {
            tinhtrang = "Đã hoàn thành";
        }
    }

    public class ChuaHoanThanh : Tinhtrangdonhang
    {
        public ChuaHoanThanh()
        {
            tinhtrang = "Chưa hoàn thành";
        }
    }

    public class DangVanChuyen : Tinhtrangdonhang
    {
        public DangVanChuyen()
        {
            tinhtrang = "Đang vận chuyển";
        }
    }

}
