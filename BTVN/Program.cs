using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biến
            int x, y, z;
            double d, x1, x2;

            Console.WriteLine("----------------------------------------");

            Console.Write("Nhap gia tri cua x: ");
            x = Convert.ToInt32(Console.ReadLine());//Giá trị nhập vào, được đọc từ bàn phím dưới dạng chuỗi, sẽ được chuyển đổi sang số nguyên bằng Convert.ToInt32 và gán cho biến x.
            Console.Write("\nNhap gia tri cua y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua z: ");
            z = Convert.ToInt32(Console.ReadLine());

            d = y * y - 4 * x * z; //Tính delta
            
            if (x == 0)
            {
                double e =  (double) -z/y;
                Console.WriteLine("Phuong trinh bac 1 : {0}", e);
            }else
            {
                if (d == 0) // Điều kiện delta
                {
                    Console.WriteLine("Phuong trinh co mot nghiem duy nhat.");
                    x1 = -y / (2.0 * x);
                    x2 = x1;
                    Console.WriteLine("Nghiem duy nhat cua phuong trinh la = {0}", x1);
                }
                else if (d > 0)
                {
                    Console.WriteLine("Phuong trinh co hai nghiem thuc phan biet");

                    x1 = (-y + Math.Sqrt(d)) / (2 * x);//Tinh Gia trị X1,X2
                    x2 = (-y - Math.Sqrt(d)) / (2 * x);

                    Console.WriteLine("Nghiem thu nhat: x1 = {0}", x1); //In ra màn hình giá trị nghiệm
                    Console.WriteLine("Nghiem thu nhat: x2 = {0}", x2);
                }
                else
                    Console.WriteLine("Phuong trinh vo nghiem (hay khong co nghiem thuc nao)");

              
            }

            Console.ReadKey();

        }
    }
}
