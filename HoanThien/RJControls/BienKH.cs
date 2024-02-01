using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanThien.RJControls
{
    public class BienKH
    {
        private static string tenTK;
        private static string ten;
        private static string emailKH;
        private static string sDTKH;
        private static string maKH;
        private static string MkhauKH;

        public static string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public static string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        public static string EmailKH
        {
            get { return emailKH; }
            set { emailKH = value; }
        }
        public static string SDTKH
        {
            get { return sDTKH; }
            set { sDTKH = value; }
        }
        public static string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public static string MKhauKH { get => MkhauKH; set => MkhauKH = value; }
    }
}
