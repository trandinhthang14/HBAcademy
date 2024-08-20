using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9
{
    internal class Class1
    {
        public static void Tong(int a, int b)
        {
            int sum = 0, tich = 0;
             sum = a + b;

            Console.WriteLine("Tong {0}", sum);

        }
        public static void Tich()
        {
            int a, tich = 0;
            int b;
            Console.Write("Nhap a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = int.Parse(Console.ReadLine());

            tich = a * b;
            Console.WriteLine("Tich a, b {0} ", tich);
        }
        public static void Hello()
        {
             Console.WriteLine("Nhap n : ");
            int i;
            int  n = int.Parse(Console.ReadLine());



            for (i = 0; i <=n; i++) {
                Console.WriteLine("i : {0} ", i);
                if (i == n) 
                    for (int j = 0; j < 10; j++) 
                    {
                
                         Console.WriteLine("Hello"); 
                    }
            }


        }
    }
}
