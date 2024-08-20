using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    internal class ToanTu
    {
        public static void PhepGan()
        {
            int a;
            int b;
            Console.Write("Nhap so  nguyen : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = int.Parse(Console.ReadLine());
            a = a >> b;
            Console.WriteLine("So nguyen dich sang phai n bit:  {0}", a);
        }

    }
}
