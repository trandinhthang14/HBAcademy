using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class AAdd
    {

        public static void CountPT()
        {
            int[] arr1 = new int[10];
            int[] fr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];

            int[] ac = new int[10];
            int[] al = new int[10];
            int n,n2,n3, i, j, bien_dem, l =0, k = 0, p, temp = 0;


            Console.Write("\nDem so lan xuat hien cua tung phan tu trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }

            for (i = 0; i < n; i++)
            {

                Console.WriteLine("\n{0} ", arr1[i]);

            }
            for (i = 0; i < n; i++)
            {
                bien_dem = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                        fr1[j] = 0;
                    }
                }
                if (fr1[i] != 0)
                {
                    fr1[i] = bien_dem;
                }
            }
            Console.Write("\nTan suat xuat hien cua tung phan tu trong mang la: \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("Phan tu {0} xuat hien {1} lan\n", arr1[i], fr1[i]);
                }
            }

            //in  mang chan, le
            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    ac[l] = arr1[i];
                    l++;//dem cac phan tu chan
                }
                else
                {
                    al[k] = arr1[i];
                    k++;//dem cac phan tu le
                }
            }

            Console.Write("\nCac phan tu chan la: \n");
            for (i = 0; i < l; i++)
            {
                Console.Write("{0} ", ac[i]);
            }
            Console.Write("\nCac phan tu le la: \n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", al[i]);
            }


            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap {0} phan tu vao trong mang arr2:\n", n2);
            for (i = 0; i < n2; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (i = 0; i < n2; i++)
            {

                Console.WriteLine("\n{0} ", arr2[i]);

            }

            /* kich co cua mang tron = tong kich co cua mang arr1 va mang arr2 */
            n3 = n + n2;

            /*chen cac phan tu cua hai mang arr1 va arr2 vao mang thu ba */
            for (i = 0; i < n; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < n2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }
            /* sap xep theo thu tu tang dan*/
            for (i = 0; i < n3; i++)
            {
                for (p = 0; p < n3 - 1; p++)
                {

                    if (arr3[p] >= arr3[p + 1])
                    {
                        temp = arr3[p + 1];
                        arr3[p + 1] = arr3[p];
                        arr3[p] = temp;
                    }
                }
            }
            /*in mang arr3*/
            Console.Write("\nMang tron da duoc sap xep theo thu tu tang dan:\n");
            for (i = 0; i < n3; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

        }
        public static void SSMang2Chieu()
        {
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int i, j, h1, c1, h2, c2, ss = 1;

            Console.Write("\nSo sanh hai ma tran trong C#:\n ");
            Console.Write("----------------------------------\n");

            Console.Write("Nhap so hang cua ma tran thu nhat: ");
            h1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran thu nhat: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so hang cua ma tran thu hai: ");
            h2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran thu hai: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap cac phan tu cua ma tran thu nhat:\n");
            for (i = 0; i < h1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Nhap cac phan tu cua ma tran thu hai:\n");

            for (i = 0; i < h2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("In ma tran thu nhat:\n");
            for (i = 0; i < h1; i++)
            {
                for (j = 0; j < c1; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            Console.Write("In ma tran thu hai:\n");
            for (i = 0; i < h2; i++)
            {
                for (j = 0; j < c2; j++)
                    Console.Write("{0}  ", arr2[i, j]);
                Console.Write("\n");
            }

            /* so sanh xem hai ma tran co bang nhau khong */

            if (h1 != h2 && c1 != c2)
            {
                Console.Write("Khong the so sanh hai ma tran nay:\n");
            }
            else
            {
                Console.Write("Co the so sanh hai ma tran nay: \n");
                for (i = 0; i < h1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        if (arr1[i, j] != arr2[i, j])
                        {
                            ss = 0;
                            break;
                        }
                    }
                }
                if (ss == 1)
                    Console.Write("Hai ma tran bang nhau.\n\n");
                else
                    Console.Write("Hai ma tran khong bang nhau\n\n");
            }

        }

       
     }
}
