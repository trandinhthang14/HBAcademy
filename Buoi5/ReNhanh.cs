using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class ReNhanh
    {
        public static void KiemTRa ()
        {
            int a, b;
            Console.Write("Nhap a: ");
            a =  int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());

            if (a>0){

                if (b > 0) {
                    Console.WriteLine("Ca 2 so deu duong a = {0}, b = {1}", a, b);
                }
                else
                {
                    Console.WriteLine("so a duong b am");
                }

            }
            else
            {
                if (b > 0)
                {
                    Console.WriteLine("so a am");
                }
                else {
                    Console.WriteLine("Ca 2 am");
                   }

            }

        }



        public static void KiemTra2() {

            int a, b, c;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && b > c)
            {

                Console.WriteLine(" a lon nhat");

            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b lon nhat"); 
                }
                else { Console.WriteLine("C lon nhat"); }
            }

        }


        public static void KiemTra3() 
        {
            int a, b;
            char toantu;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap toan tu: ");
            toantu = char.Parse(Console.ReadLine());
          
            switch (toantu)
            {
                case '+':
                    Console.WriteLine("Tong 2 so la: {0}", a + b);
                    break;
                case '-':
                    Console.WriteLine("Hieu 2 so la: {0} , {1}", a - b, b - a);
                    break;
                case '/':
                    Console.WriteLine("Thuong 2 so la: {0} , {1} ", a/b , b/a);
                    break;
                case '*':
                    Console.WriteLine("Tich 2 so la: {0} ", a * b);
                    break;
                default:
                    Console.WriteLine("Khong hop le");
                    break;
            }
        }
        public static void VongLap()
        {
            int i = 0,n, sum = 0;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            /*while (n>0)
            {

                sum = sum + n;
                n--;

            }
            Console.WriteLine("Tong day so : {0} ", sum);*/


            while (i<=n) {

                sum = sum + i;
                i++;
                
            }
            Console.WriteLine("Tong day so : {0} ", sum);

        }
        public static void VongLap2() {
            int n, sum = 0;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <=n; i++) { 
                sum += i;
                
            }
            Console.WriteLine("Tong day so {0}", sum);
        }

        public static void VongLap3() {

            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            bool b = true;

            if (n == 2) {
                b = true;
            }
            for (int i = 2; i < n-1; i++) 
            {
                if (n % i == 0)
                {
                    b = false;
                    break;
                }
             
            }

            if (b)
            {
                Console.WriteLine("la so nguyen to");
            }
            else
            {
                Console.WriteLine("ko la so nguyen to");
            }
        }

        public static void ThuaSo() 
        {
            int number = 0;
            bool validInput = false;

            // Loop until a valid input is entered
            do
            {
                Console.Write("Nhap mot so nguyen duong: ");
                validInput = int.TryParse(Console.ReadLine(), out number) && number > 1;

                if (!validInput)
                    Console.WriteLine("Du lieu khong hop le. Vui long nhap lai.");
            } while (!validInput);

            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");
                    number /= i;
                }
            }
          
            Console.Write("Cac thua so nguyen to cua {0} là: ", number);

        }

        public static void TinhThu()
        {
            while (true)
            {
                Console.Write("Nhập ngày tháng năm (dd/MM/yyyy) hoặc 'thoat' để kết thúc: ");
                string ngayThangNam = Console.ReadLine();

                if (ngayThangNam.ToLower() == "thoat")
                {
                    break;
                }
                DateTime ngay;
                if (DateTime.TryParseExact(ngayThangNam, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngay))
                {
                    Console.WriteLine($"Thứ của ngày {ngayThangNam} là: {ngay.DayOfWeek}");

                    int ngayTrongThang = ngay.Day;
                    int thang = ngay.Month;
                    int nam = ngay.Year;
                    if (thang < 3)
                    {
                        nam--;
                        thang += 12;
                    }
                    int K = nam / 100;
                    int J = nam - 100 * K;
                    int h = (ngayTrongThang + (13 * (thang + 1)) / 5 + J + J / 4 + K / 4 - 2 * K) % 7;
                    Console.WriteLine($"Thứ của ngày {ngayThangNam}: {LayTenThu(h)}");
                }
                else
                {
                    Console.WriteLine("Định dạng ngày tháng năm không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

        static string LayTenThu(int h)
        {
            switch (h)
            {
                case 0: return "Thứ Bảy";
                case 1: return "Chủ Nhật";
                case 2: return "Thứ Hai";
                case 3: return "Thứ Ba";
                case 4: return "Thứ Tư";
                case 5: return "Thứ Năm";
                case 6: return "Thứ Sáu";

                default: return "Không hợp lệ";
            }
        }
        static int UCLN(int a, int b) => b == 0 ? a : UCLN(b, a % b);

        public static void UCLN_BCNN()
        {
         
            int a, b;
            do
            {
                Console.Write("Nhap so nguyen duong a: ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);
            do
            {
                Console.Write("Nhap so nguyen duong b: ");
            } while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

            int ucln = (a % b);
            int bcnn = (a * b) / ucln;

            Console.WriteLine(ucln == 1 ? "Hai số nguyên tố cùng nhau" : $"Ước số chung lớn nhất: {ucln}");
            Console.WriteLine($"Bội số chung nhỏ nhất: {bcnn}");
        }

        public static void IN()
        {


        }
    }
}
