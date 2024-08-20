using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTVNB9
{
    internal class BTVN2
    {
        static int TimGiaTriNhoNhat(int a, int b)
        {
            return a < b ? a : b;
        }

        // Hàm tính giá trị trung bình của 4 số (gọi hàm bằng giá trị)
        static double TinhGiaTriTrungBinh(int a, int b, int c, int d)
        {
            return (a + b + c + d) / 4.0;
        }

        public static void MainStart()
        {
            // Nhập các số từ bàn phím
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Nhập d : ");
            int d = int.Parse(Console.ReadLine());

           int min =  TimGiaTriNhoNhat(a , b);
            Console.WriteLine("Giá trị nhỏ nhất giữa {0} và {1} là: {2}", a, b, min);
            double tb = (double)TinhGiaTriTrungBinh(a ,b, c, d);
            Console.WriteLine("Giá trị TB : {0}", tb);

        }

        static void TimGiaTriNhoNhat(ref int a, ref int b, ref int minValue)
        {
            minValue = a < b ? a : b;
        }

        // Hàm tính giá trị trung bình của 4 số (gọi hàm bằng tham chiếu)
        static void TinhGiaTriTrungBinh(ref int a, ref int b, ref int c, ref int d, ref double averageValue)
        {
            averageValue = (a + b + c + d) / 4.0;
        }
        public static void MainStart1() {

            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Nhập d : ");
            int d = int.Parse(Console.ReadLine());

            int minValue = 0;
            double averageValue = 0;

            TimGiaTriNhoNhat(ref  a, ref  b, ref  minValue);
            Console.WriteLine("Giá trị nhỏ nhất giữa {0} và {1} là: {2}", a , b, minValue);
            TinhGiaTriTrungBinh(ref a, ref b, ref c, ref d, ref averageValue);
            Console.WriteLine("Giá trị TB : {0} ", averageValue); 
        }

        static void TimGiaTriNhoNhat(int a, int b, out int minValue)
        {
            minValue = a < b ? a : b;
        }

        // Hàm tính giá trị trung bình của 4 số (gọi hàm bằng out)
        static void TinhGiaTriTrungBinh(int a, int b, int c, int d, out double averageValue)
        {
            averageValue = (a + b + c + d) / 4.0;
        }
        static void TimGiaTriNhoNhat4(int a, int b, int c, int d, out int minValue1)
        {
            minValue1 = a;

            if (b < minValue1)
            {
                minValue1 = b;
            }

            if (c < minValue1)
            {
                minValue1 = c;
            }

            if (d < minValue1)
            {
                minValue1 = d;
            }
        }

        public static void MainStart2()
        {
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Nhập d : ");
            int d = int.Parse(Console.ReadLine());

            int minValue , minValue1;
            double averageValue ;

            TimGiaTriNhoNhat(a, b, out minValue);
            TimGiaTriNhoNhat4(a, b, c, d, out minValue1);
            Console.WriteLine("Giá trị nhỏ nhất giữa {0} và {1} là: {2}", a, b, minValue);
            Console.WriteLine("Giá trị nhỏ nhất {0} ", minValue1);

            TinhGiaTriTrungBinh( a,  b,  c,  d,out  averageValue);
            Console.WriteLine("Giá trị TB : {0} ", averageValue);
        }

        static void InLoiChao()
        {
            Console.WriteLine("Chào mừng bạn đến với chương trình!");
        }

        // Hàm in ra thông điệp sau 5 giây
        static void InThongDiepSau5Giay()
        {
            // Đợi 5 giây
            Thread.Sleep(5000);
            Console.WriteLine("Welcome to HB Academy");
        }
        public static void MainHello()
        {
            InLoiChao();
            InThongDiepSau5Giay();
        }
    }
}
