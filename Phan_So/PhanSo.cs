using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Phan_So
{
    class PhanSo
    {
        private double tu; //tu so
        private double mau; //mau so
        PhanSo[] ps;
        int n; //bien chua so luong phan so
        public PhanSo() { }
        //ham nhap 1 phan so
        public void nhap1PS()
        {
            Console.WriteLine("\nNhap tu: ");
            tu = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("\nNhap mau: ");
                mau = Convert.ToDouble(Console.ReadLine());
            } while (mau == 0);

        }
        //ham xuat 1 phan so
        public void xuat1PS()
        {
            if (tu == 0 || mau == 1)
                Console.WriteLine("{0}", tu);
            else
                Console.WriteLine("{0}/{1}", tu, mau);
        }
        //ham nhap danh sach phan so
        public void nhapDSPS()
        {

            Console.WriteLine("Nhap so luong phan so: ");
            n = Convert.ToInt32(Console.ReadLine());
            ps = new PhanSo[n];

            for (int i = 0; i < n; i++)
            {
                ps[i] = new PhanSo();
                Console.WriteLine("Nhap phan so thu {0}:", i + 1);
                ps[i].nhap1PS();
                ps[i] = ps[i].rutGon();
                Console.WriteLine("----------");
            }
        }
        //ham xuat danh sach phan so
        public void xuatDSPS()
        {
            Console.WriteLine("\nDanh sach cac phan so da nhap la: ");
            for (int i = 0; i < n; i++)
            {
                ps[i].xuat1PS();
                Console.WriteLine("\t");
            }
        }
        //ham tim UCLN
        public double UCLN(double a, double b)
        {
            /*a = Math.Abs(tu);
            b = Math.Abs(mau);*/
            while (a != b && a != 0 && b != 0)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        //ham rut gon phan so dua tren UCLN
        public PhanSo rutGon()
        {
            PhanSo r = new PhanSo();
            double a = UCLN(tu, mau);
            r.tu = tu / a;
            r.mau = mau / a;
            return r;
        }
        //cai dat toan tu cong cho phep tong day ps
        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.tu = ps1.tu * ps2.tu + ps1.mau + ps2.tu;
            ps.mau = ps1.mau * ps2.mau;
            return ps;
        }
        //cai dat toan tu tru cho phep hieu day ps
        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.tu = ps1.tu * ps2.tu - ps1.mau + ps2.tu;
            ps.mau = ps1.mau * ps2.mau;
            return ps;
        }
        //cai dat toan tu nhan cho phep tich day ps
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.tu = ps1.tu * ps2.tu;
            ps.mau = ps1.mau * ps2.mau;
            return ps;
        }
        //cai dat toan tu chia cho phep chia thuong ps
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps = new PhanSo();
            ps.tu = ps1.tu * ps2.mau;
            ps.mau = ps1.mau * ps2.tu;
            return ps;
        }
        //ham tinh tong day cac phan so
        public PhanSo Tong()
        {
            PhanSo tong = ps[0];
            for (int i = 0; i < n; i++)
            {
                tong = tong + ps[i];
            }
            tong.rutGon();
            return tong;
        }
        //ham tinh hieu day cac phan so
        public PhanSo Hieu()
        {
            PhanSo hieu = ps[0];
            for (int i = 0; i < n; i++)
            {
                hieu = hieu - ps[i];
            }
            hieu.rutGon();
            return hieu;
        }
        //ham tinh tich day cac phan so
        public PhanSo Tich()
        {
            PhanSo tich = ps[0];
            for (int i = 0; i < n; i++)
            {
                tich = tich * ps[i];
            }
            tich.rutGon();
            return tich;
        }
        //ham tinh thuong day cac phan so
        public PhanSo Thuong()
        {
            PhanSo thuong = ps[0];
            for (int i = 0; i < n; i++)
            {
                thuong = thuong / ps[i];
            }
            thuong.rutGon();
            return thuong;
        }
        ~PhanSo() //destructor
        {
        }
    }
}
