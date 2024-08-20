using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Buoi8
{
    internal class List
    {
        public static void List1() {

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Thang chist");
            arrayList.Add(true);

            ArrayList arrayList2 = new ArrayList(arrayList);
            arrayList2.Add(DateTime.Parse("1/4/2000"));
            arrayList2[1] = "Nam dinh";

            arrayList.Reverse();

            for (int i = 0; i < arrayList.Count; i++) {

                Console.Write(arrayList[i]);
                Console.Write("-");


            }
            Console.WriteLine();
            foreach(object obj in arrayList2)
            {
                Console.Write(obj.ToString());
                Console.Write("-");
            }

            Console.WriteLine();

            arrayList.RemoveAt(2);
            arrayList2.RemoveRange(2,2);
            arrayList2.Remove(1);

            for (int i = 0; i < arrayList.Count; i++)
            {

                Console.Write(arrayList[i]);
                Console.Write("-");


            }

            bool exists = arrayList.Contains("Thang chist");
            Console.WriteLine($"co ton tai trong 1: {exists}");
            Console.WriteLine();
            foreach (object obj in arrayList2)
            {
                Console.Write(obj.ToString());
                Console.Write("-");
            }
        }





        public static void List2() {

            List<int> l1 = new List<int>();
            l1.Add(1);
            List<char> l2 = new List<char>() {'a', 'b' };


            int n;
            List<int> l3 = new List<int>();

            Console.WriteLine("Nhap so phan tu ds ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong ds:\n", n);

            for (int i = 0; i < n; i++) {

                Console.Write("Nhập số thứ " + i + ": ");
                int num = int.Parse(Console.ReadLine());
                l3.Add(num);

            }

            foreach (int obj in l3)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
            l3.Sort();//tang dan
            foreach (int obj in l3)
            {
                Console.Write(obj + " ");
            }
            l3.Reverse();
            Console.WriteLine();
            foreach (int obj in l3)
            {
                Console.Write(obj + " ");
            }
            //l3.RemoveAll(x => x==5);
            Console.WriteLine() ;
            for (int i = 0; i < l3.Count; i++) {

                if (l3[i] == 5) { 
                    
                    l3.RemoveAt(i);//xoa tai vi tri
                    i--;
                }
            }
            for (int i = 0; i < l3.Count; i++)
            {
                Console.Write(l3[i] + " ");
            }
            Console.WriteLine();
            foreach (int obj in l3)
            {
                Console.Write(obj + " ");
            }

        }
        public static void Stack() { 
        
        Stack sk = new Stack();
        Stack<int> sk2 = new Stack<int>();

            sk.Push(1);
            sk.Push("Chist");

            sk.Push(DateTime.Parse("1/2/2000"));

            foreach (object obj in sk)
            {
                //Console.WriteLine(obj);
            }
            int sl = sk.Count;
            for (int i = 0; i < sl; i++) {
                Console.WriteLine(); sk.Pop();
            }

           
            //Console.WriteLine(sk.Peek());    

        }


        public static void Dictionary()
        {
            int n;
            Dictionary<string, string> dic= new Dictionary<string, string>();
            Console.Write("Nhap so ds: ");
            n = Convert.ToInt32(Console.ReadLine());
           /* dic.Add("099999983","A");
            dic.Add("099996644", "b");
            dic.Add("099996622", "c");*/

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin thứ " + i + ": ");
                Console.Write("SDT: ");
                string sdt = Console.ReadLine();
                Console.Write("Ten: ");
                string ten = Console.ReadLine();    
                dic.Add(sdt, ten);
            }


            for (int i = 0; i < dic.Count; i++) { 
            
                Console.WriteLine("Thong tin: {0}, {1}",dic.ElementAt(i).Value,dic.ElementAt(i).Key ) ;
            }
            foreach(KeyValuePair<string, string> temp in dic)
            {
                Console.WriteLine("{0}, {1}",temp.Value,temp.Key);
            }

         
            Console.WriteLine("Nhap ho ten kiem tra");
            string tenkt = Console.ReadLine();
        

          if (dic.ContainsValue(tenkt))
            {
                Console.WriteLine("Ton tai ten " +tenkt+" trong ds");
            }
            else
            {
                Console.WriteLine("Ko ton tai");
            }

            Console.WriteLine("Nhap ho ten xoa");
            string tenDele = Console.ReadLine();
            string sdtDele = null;

            foreach (var entry in dic)
            {
                if (entry.Value == tenDele)
                {
                    sdtDele = entry.Key;
                    break;
                }
            }

            if (sdtDele != null)
            {
                dic.Remove(sdtDele);
                Console.WriteLine("Da xoa sdt cua" + tenDele);
            }
            else
            {
                Console.WriteLine("ko tim thay ten");
            }

            // Bước 6: Xóa cả danh sách
           dic.Clear();
            Console.WriteLine("Xoa all.");
        }

        public static void Ship()
        {
            Queue<int> shipQueue = new Queue<int>(); // Hàng đợi các tàu chờ
            int totalProcessedShips = 0; // Tổng số tàu đã chuyển hàng
            Random random = new Random();

            Console.WriteLine("Bắt đầu mô phỏng bến tàu chở hàng trong 100 giây...");

            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < 100)
            {
                // Kiểm tra xem có tàu nào cần xử lý không
                if (shipQueue.Count > 0)
                {
                    int processingTime = random.Next(3000, 7001); // Mất 3-7 giây để chuyển hàng
                    Thread.Sleep(processingTime);

                    shipQueue.Dequeue(); // Xử lý một tàu trong hàng đợi
                    totalProcessedShips++;
                    Console.WriteLine("Một tàu đã hoàn thành việc chuyển hàng. Tổng số tàu đã chuyển hàng: " + totalProcessedShips);
                    Console.WriteLine("Tổng số tàu đang chờ: " + shipQueue.Count);
                }

                // Kiểm tra xem có tàu mới nào cập bến không
                int nextShipTime = random.Next(5000, 10001); // Tạo tàu mới sau 5-10 giây
                if ((DateTime.Now - startTime).TotalMilliseconds >= nextShipTime)
                {
                    shipQueue.Enqueue(1); // Thêm tàu vào hàng đợi
                    Console.WriteLine("Một tàu mới vừa cập bến. Tổng số tàu chờ: " + shipQueue.Count);
                    startTime = DateTime.Now; // Cập nhật lại thời gian bắt đầu
                }
            }

            Console.WriteLine("Kết thúc mô phỏng.");
            Console.WriteLine("Tổng số tàu đã chuyển hàng: " + totalProcessedShips);
            Console.WriteLine("Tổng số tàu còn lại trong hàng chờ: " + shipQueue.Count);

        }

        public static void Ship2()
        {
            // Khởi tạo các biến
            int thoiGianDenTauTiepTheo = 5; // Giây
            int thoiGianChuyenHang = 3; // Giây
            int soTauDaChuyenHang = 0;
            int soTauDangCho = 0;
            int thoiGianHienTai = 0;

            while (true)
            {
                // Kiểm tra xem có tàu mới đến không
                if (thoiGianHienTai >= thoiGianDenTauTiepTheo)
                {
                    soTauDangCho++;
                    Console.WriteLine($"Tàu mới đến lúc {thoiGianHienTai} giây. Tổng số tàu đang chờ: {soTauDangCho}");

                    // Bắt đầu một thread để mô phỏng việc chuyển hàng
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(thoiGianChuyenHang * 1000); // Chuyển đổi giây thành mili giây
                        soTauDangCho--;
                        soTauDaChuyenHang++;
                        Console.WriteLine($"Tàu đã chuyển hàng xong lúc {thoiGianHienTai + thoiGianChuyenHang} giây.");
                    });
                    thread.Start();

                    // Tính toán thời điểm tàu tiếp theo đến
                    thoiGianDenTauTiepTheo += new Random().Next(5, 11); // Tạo khoảng cách đến tàu tiếp theo ngẫu nhiên từ 5 đến 10 giây
                }

                // Hiển thị thông tin
                Console.WriteLine($"Thời gian hiện tại: {thoiGianHienTai} giây. Tổng số tàu đã chuyển hàng: {soTauDaChuyenHang}, Tổng số tàu đang chờ: {soTauDangCho}");

                // Tăng thời gian hiện tại
                thoiGianHienTai++;
                Thread.Sleep(1000);
            }


        }
    }

 }


    

