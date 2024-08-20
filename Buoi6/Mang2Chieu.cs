using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class Mang2Chieu
    {
        public static void Mang2()
        {
            int i, j, sum = 0;
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] Tong2matran = new int[3, 3];
            int[] tonghang = new int[3];
            int[] tongcot = new int[3];

            Console.Write("\nDoc va in mang hai chieu trong C#:\n");


            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap cac phan tu vao trong mang hai chieu:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());

                   
                }
            }
            //in mang 2 chieu
            Console.Write("\nIn mang hai chieu 1: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
                  
            }



            // tinh tong duong cheo chinh
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                   if ( i == j) //duong cheo chinh
                    {
                        sum += arr1[i, j];
                    }
                }
            }

            Console.Write("\nTong cac phan tu tren duong cheo chinh la: {0}\n", sum);

            //su dung mang 1 chieu luu ket qua
            /* tinh tong cac hang */
            for (i = 0; i < 3; i++)
            {
                tonghang[i] = 0;
                for (j = 0; j < 3; j++)
                    tonghang[i] = tonghang[i] + arr1[i, j];
            }

            /* tinh tong cac cot */
            for (i = 0; i < 3; i++)
            {
                tongcot[i] = 0;
                for (j = 0; j < 3; j++)
                    tongcot[i] = tongcot[i] + arr1[j, i];
            }

            Console.Write("Tong cua cac hang va cac cot trong ma tran la:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    Console.Write("{0}    ", arr1[i, j]);
                Console.Write("{0}    ", tonghang[i]);

                Console.Write("\n");
            }
            for (j = 0; j < 3; j++)
            {
                Console.Write("{0}   ", tongcot[j]);
            }


            // nhap them mang 2 chieu
            Console.Write("Nhap cac phan tu vao trong mang hai chieu 2:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());


                }
            }

            Console.Write("\nIn mang hai chieu 2: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr2[i, j]);

            }
            /* cong hai ma tran */
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    Tong2matran[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nMa tran tong cua hai ma tran tren la: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", Tong2matran[i, j]);
            }



            Console.Write("\n\n");
        }
    }
}
