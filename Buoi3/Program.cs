using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class Program
    {

        struct SinhVien
        {
            public string MaSV;
            public string HoTen;
            public string QueQuan;
            public string SDT;
            public string GioiTinh;
        }
        static void Main(string[] args)
        {
            /*string a, b, c;
            Console.Write("Nhap gia tri a  ");
            a =  Console.ReadLine();

            Console.Write("Nhap gia tri b ");
            b = Console.ReadLine();

            Console.Write("Nhap gia tri c ");
            c = Console.ReadLine();

            Console.WriteLine("Gia tri nguoc lai " +c +b +a);

            int i,s,sum;
            Console.Write("Nhap gia tri i = ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri s = ");
            s = Convert.ToInt32(Console.ReadLine());
            if( i % 2 ==0)
            {
                Console.WriteLine("i la so chan " );
            }
            else
            {
                Console.WriteLine("i la so le");
            }
            sum = s + i;
            Console.WriteLine("Tong sum = " + sum);*/


            SinhVien[] sinhVien = new SinhVien[12];

            sinhVien[0] = new SinhVien { MaSV = "SV1", HoTen = "Tran Dinh Thang" , QueQuan = "Nam Dinh", SDT = "0986555571", GioiTinh = "Nam"};
            sinhVien[1] = new SinhVien { MaSV = "SV2", HoTen = "Pham Thai Cong", QueQuan = "Ha Noi", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[2] = new SinhVien { MaSV = "SV3", HoTen = "Tran Thien Nhan", QueQuan = "Tien Giang", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[3] = new SinhVien { MaSV = "SV4", HoTen = "Le Quang Vu", QueQuan = "Ha Noi", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[4] = new SinhVien { MaSV = "SV5", HoTen = "Do Huy Viet Hung", QueQuan = "Bac giang", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[5] = new SinhVien { MaSV = "SV6", HoTen = "Tran Duc Duong", QueQuan = "Thanh Hoa", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[6] = new SinhVien { MaSV = "SV7", HoTen = "Le Anh Tan", QueQuan = "Lao Cai", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[7] = new SinhVien { MaSV = "SV8", HoTen = "Pham Viet Hoang", QueQuan = "Ha Noi", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[8] = new SinhVien { MaSV = "SV9", HoTen = "Phan Quang Huy", QueQuan = "Ha Noi", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[9] = new SinhVien { MaSV = "SV10", HoTen = "Vu Trung Hieu", QueQuan = "Ha Noi", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[10] = new SinhVien { MaSV = "SV11", HoTen = "Nguyen Huy Hoang", QueQuan = "Ha Noi", SDT = "0986555571", GioiTinh = "Nam" };
            sinhVien[11] = new SinhVien { MaSV = "SV12", HoTen = "Nguyen Thai Duong", QueQuan = "Nam Dinh", SDT = "0986555571", GioiTinh = "Nam" };

            Console.WriteLine("{0,-3}, {1,-15}, {2,-9}, {3,-10},{4,-3}", "MaSV", "HoTen", "QueQuan", "SDT", "GioiTinh");
            //in thong tin man hinh tat ca cac ban trong lop
            //lam bai tap trong buoi2 56,51,49
            foreach (var i in sinhVien)
            {
                Console.WriteLine("{0,-3}, {1,-15}, {2,-9}, {3,-10}, {4,-3}",
                    i.MaSV,
                    i.HoTen,
                    i.QueQuan,
                    i.SDT,
                    i.GioiTinh);
            }
        }
       
    }
}
