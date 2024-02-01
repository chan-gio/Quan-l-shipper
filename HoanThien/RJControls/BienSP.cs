using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace HoanThien.RJControls
{

    public class BienSP
    {
        private static string tenTK;
        private static string ten;
        private static string cCCD;
        private static string sDTSP;
        private static string maSP;
        private static string emailSP;
        private static string mkSP;
        private static string diachiSP;
        private static string madonhang;






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
        public static string CCCD
        {
            get { return cCCD; }
            set { cCCD = value; }
        }

        public static string SDTSP
        {
            get { return sDTSP; }
            set { sDTSP = value; }
        }

        public static string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public static string EmailSP
        {
            get { return emailSP; }
            set { emailSP = value; }
        }

        public static string MkSP
        {
            get { return mkSP; }
            set { mkSP = value; }
        }
        public static string DiachiSP
        {
            get { return diachiSP; }
            set { diachiSP = value; }
        }

        public static string Madonhang { get => madonhang; set => madonhang=value; }
    }
    }