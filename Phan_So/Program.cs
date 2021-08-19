using System;

namespace Phan_So
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p = new PhanSo();
            p.nhapDSPS();
            p.xuatDSPS();

            Console.WriteLine("\n================PHEP TINH================");
            Console.WriteLine("\n1.Tinh tong day phan so__________________");
            Console.WriteLine("\n2.Tinh hieu day phan so__________________");
            Console.WriteLine("\n3.Tinh tich day phan so__________________");
            Console.WriteLine("\n4.Tinh thuong day phan so________________");
            Console.WriteLine("\n5.Nhan ESC de thoat______________________");

            char key;
            int a;
            Console.WriteLine("\nNhap lua chon phep tinh cho day phan so: ");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("\nTong day cac phan so la: ");
                        PhanSo tong = p.Tong();
                        tong.xuat1PS();
                        break;
                    case 2:
                        Console.WriteLine("\nHieu day cac phan so la: ");
                        PhanSo hieu = p.Hieu();
                        hieu.xuat1PS();
                        break;
                    case 3:
                        Console.WriteLine("\nTich day cac phan so la: ");
                        PhanSo tich = p.Tich();
                        tich.xuat1PS();
                        break;
                    case 4:
                        Console.WriteLine("\nThuong day cac phan so la: ");
                        PhanSo thuong = p.Thuong();
                        thuong.xuat1PS();
                        break;
                    //case 5: *chua lam duoc: nhan phim bat ky de tiep tuc va nhan esc de thoat*
                    default:
                        Console.WriteLine("\nGia tri nhap khong hop le! Moi nhap lai.");
                        break;
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
