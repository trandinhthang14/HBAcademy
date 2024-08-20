using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập một ký tự và hiển thị mã Unicode của ký tự đó
            Console.Write("Nhap mot ky tu: ");
            char character = Console.ReadKey().KeyChar; //nhập một ký tự từ bàn phím. Console.ReadKey() đọc phím bấm của người dùng,
                                                        //và thuộc tính KeyChar của đối tượng trả về sẽ chứa ký tự vừa được nhập.
                                                        //Ký tự này được gán cho biến character.
            Console.WriteLine();
            Console.WriteLine($"Ma Unicode cua '{character}' la: {(int)character}");//in ra mã Unicode của ký tự vừa nhập. character được ép kiểu thành int để lấy mã Unicode tương ứng.

            //  Nhập một mã Unicode và hiển thị ký tự tương ứng
            Console.Write("Nhap mot ma Unicode: ");
            int unicode;
            while (!int.TryParse(Console.ReadLine(), out unicode))//Vòng lặp while này liên tục yêu cầu người dùng nhập một mã Unicode cho đến khi người dùng nhập đúng một số nguyên.
                                                                  //Console.ReadLine() đọc đầu vào từ người dùng dưới dạng chuỗi.
                                                                  //int.TryParse cố gắng chuyển đổi chuỗi thành số nguyên, nếu thành công, giá trị số nguyên được lưu vào unicode và vòng lặp dừng.
                                                                  //Nếu không thành công, chương trình sẽ yêu cầu người dùng nhập lại một số nguyên.
            {
                Console.Write("nhap mot so nguyen: ");
            }
            Console.WriteLine($"Ky tu cua ma Unicode {unicode} la: {(char)unicode}");//in ra ký tự tương ứng với mã Unicode đã nhập. unicode được ép kiểu thành char để lấy ký tự tương ứng

            // Hiển thị bảng mã Unicode từ 0 đến 255
            Console.WriteLine("Bang ma Unicode tu 0 đến 255:");
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"{i}: {(char)i}");//Vòng lặp for này chạy từ 0 đến 255. Trong mỗi lần lặp, biến i đại diện cho mã Unicode hiện tại. Dòng Console.WriteLine($"{i}: {(char)i}");
                                                     //in ra mã Unicode i và ký tự tương ứng (char)i. Kết quả là bảng mã Unicode từ 0 đến 255 được hiển thị ra màn hình.
            }
        }
    }
}
