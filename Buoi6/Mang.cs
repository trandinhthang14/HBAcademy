using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    internal class Mang
    {
        public static void Mang1() 
        {
            int[] a = new int[5] ;
            int[] a1 = new int[5];
            int[] ac = new int[5];
            int[] al = new int[5];



            Console.Write("Nhap so phan tu mang :  ");

            int i, n, sum = 0, sumc=0 ,suml=0, dem = 0, demd= 0, dema= 0, x , p , d, max, min, j=0, k=0, g, tmp;

            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);

            for ( i = 0; i<n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (i = 0; i < n; i++) {
                Console.WriteLine(" {0} ", a[i]);

            }

            Console.WriteLine("Mang nguoc lai : ");
            for ( i = n - 1 ; i >= 0; i--) {
                Console.WriteLine (" {0} ", a[i]);
            }


            for(i = 0; i< a.Length; i++)
            {
                sum += a[i];
                dem +=1;
            }
            Console.WriteLine("Tong cac phan tu : {0} ", sum);

            // tinh tong cac so chan le, dem so duong so am trong mang
            for ( i = 0; i < a.Length; i++)
            {
                if (a[i] %2 == 0) {

                    sumc += a[i];
                    dem += 1;

                }
                else
                {
                    suml += a[i];
                    dem += 1;
                }
                if (a[i] >= 0) { 
                
                    demd += 1;
                }
                else
                {
                    dema += 1;
                }

            }
            Console.WriteLine("Tong cac phan tu chan : {0} ", sumc);
            Console.WriteLine("Tong cac phan le : {0} ", suml);
            Console.WriteLine("Dem cac phan tu duong: {0} ", demd);
            Console.WriteLine("Dem cac phan tu am: {0} ", dema);

            Console.Write("Nhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri can chen phan tu moi nay: ");
            p = Convert.ToInt32(Console.ReadLine());

            /* di chuyen vi tri cac phan tu ben phai cua mang */
            for (i = n; i >= p; i--)
            {
                a[i] = a[i - 1];
            }  
            /* chen gia tri vao vi tri da cho */
            a[p - 1] = x;

            Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
            for (  i = 0; i <= n; i++)
                Console.Write("{0} ", a[i]);
            Console.Write("\n\n");

            Console.Write("Nhap vi tri can xoa phan tu moi nay: ");
            d = Convert.ToInt32(Console.ReadLine());

            /* xac dinh vi tri cua i trong mang*/
            i = 0;
            while (i != d - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < n)
            {
                a[i] = a[i + 1];
                i++;
            }
            
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(" {0}", a[i]);
            }


            //tim gia tri lon nhat nho nhat
            max = a[0];
            min = a[0];

            for (i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }


                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.Write("\n phan tu lon nhat: {0}\n ", max);
            Console.Write("\n phan tu nho nhat: {0}\n", min);

            /* sao chep cac phan tu trong mang arr1 vao trong mang arr2.*/
            for (i = 0; i < n; i++)
            {
                a1[i] = a[i];
            }

            //in mang sao chep
            Console.Write("\n\nCac phan tu trong mang sao la:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a1[i]);
            }


            //in  mang chan, le
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    ac[j] = a[i];
                    j++;//dem cac phan tu chan
                }
                else
                {
                    al[k] = a[i];
                    k++;//dem cac phan tu le
                }
            }

            Console.Write("\nCac phan tu chan la: \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", ac[i]);
            }
            Console.Write("\nCac phan tu chan la: \n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", al[i]);
            }


            //sap xep mang tang dan giam dan
            for (i = 0; i < n; i++)
            {
                for (g = i + 1; g < n; g++)
                {
                    if (a[i] < a[g])
                    {
                        //cach trao doi gia tri
                        tmp = a[i];
                        a[i] = a[g];
                        a[g] = tmp;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }


            for (i = 0; i < n; i++)
            {
                for (g = i + 1; g < n; g++)
                {
                    if (a[i] > a[g])
                    {
                        //cach trao doi gia tri
                        tmp = a[i];
                        a[i] = a[g];
                        a[g] = tmp;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\n");
        }
    }
}
