using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNB9
{
    internal class BTVN
    {
      public static int[] NhapDuLieuMang(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void InDuLieuMang(int[] arr)
        {
            Console.WriteLine("Dữ liệu mảng là:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

       static int TimSoNhoNhat(int[] arr)
        {
       
            int min = arr[0];
           

            for (int i = 0; i < arr.Length; i++) {
                
                if (arr[i] < min)
                {
                    min = arr[i];
                }
              
            }
            return min;
        }
        static int TimSoLonNhat(int[] arr)
        {

            int max = arr[0];


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < max)
                {
                    max = arr[i];
                }

            }
            return max;
        }

        static List<int> TimCacSoChan(int[] arr)
        {
            List<int> soChan = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    soChan.Add(arr[i]);
                }
            }
            return soChan;
        }

        static List<int> TimCacSoLe(int[] arr)
        {
            List<int> soLe = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    soLe.Add(arr[i]);
                }
            }
            return soLe;
        }

        static List<int> TimCacSoDuong(int[] arr)
        {
            List<int> soDuong = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    soDuong.Add(arr[i]);
                }
            }
            return soDuong;
        }


        public static void MainChay()
        {
         
            Console.Write("Nhập số lượng phần tử N: ");
            int n = int.Parse(Console.ReadLine());

            // Nhập dữ liệu cho mảng
            int[] arr = NhapDuLieuMang(n);
            InDuLieuMang(arr);
            Console.WriteLine("Số nhỏ nhất: " + TimSoNhoNhat(arr));
            Console.WriteLine("Số lớn nhất: " + TimSoLonNhat(arr));

            List<int> soChan = TimCacSoChan(arr);
            Console.WriteLine("Các số chẵn: " + string.Join(", ", soChan));

            // Tìm các số lẻ
            List<int> soLe = TimCacSoLe(arr);
            Console.WriteLine("Các số lẻ: " + string.Join(", ", soLe));

            List<int> soDuong = TimCacSoDuong(arr);
            Console.WriteLine("Các số dương: " + string.Join(", "), soDuong);

        }
    }
}
