using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    internal class Program
    {
        struct SinhVien
        {
           public string Name;
           public int Age;
        }
        static void Main(string[] args)
        {
            SinhVien Sv1, Sv2;

            Sv1.Name = "Name";
            Sv1.Age = 20;

            Sv2.Name = "Nam 2";
            Sv2.Age = 30;

            Console.WriteLine("Thong tin : {0} {1}", Sv1.Name, Sv1.Age); 
        }
    }
}
