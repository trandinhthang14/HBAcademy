using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Buoi7
{

    internal class Chuoi
    {

        public static void ChuoiString()
        {
            // Gán giá trị 1 hằng
            string str1 = "Hello";

            // Nối nhiều chuỗi với nhau
            string str2 = "World";
            string str3 = str1 + " " + str2;

            // Sử dụng các phương thức trả về một chuỗi
            string str4 = str3.ToUpper(); // Chuyển thành chữ hoa
            string str5 = str3.ToLower();
            string str6 = str3.Substring(0, str3.Length - 1);
            string strp = "Thang\' chist\0 lop\\^";


            Console.WriteLine("str4 "+ str4[2]);
            Console.WriteLine("str5 " + str5);
            Console.WriteLine("str6 " + str6);
            Console.WriteLine("strp " + strp);
        }

        public static void ChuoiString2()
        {
            g:
            Console.WriteLine("Nhap mot chuoi khoang 20 tu:");
            
            string  str = Console.ReadLine();
           
            if (str.Length >= 18 && str.Length <= 22)
            {
                Console.WriteLine("Hien thi");
                Console.WriteLine(str);
            }
            else {
                goto g;
            }

            Console.WriteLine(" Nhap so sanh:");
            char char1 = char.Parse(Console.ReadLine());
            if (str.Contains(char1))
            {
                Console.WriteLine("Ki tu nam trong chuoi");
            }
            else {
                Console.WriteLine("Ki tu ko trong chuoi");

            }

            Console.WriteLine("Nhập một từ bất kỳ: ");
            string word = Console.ReadLine();
            bool containsWord = str.Contains(word);

            Console.WriteLine($"Chuỗi có chứa từ '{word}': {containsWord}");

            // 1. Kiểm tra trong str có ký tự số, chữ thường, chữ hoa hay không
            bool hasDigit = Regex.IsMatch(str, @"\d");
            bool hasLower = Regex.IsMatch(str, @"[a-z]");
            bool hasUpper = Regex.IsMatch(str, @"[A-Z]");

            Console.WriteLine($"Có ký tự số: {hasDigit}");
            Console.WriteLine($"Có ký tự chữ thường: {hasLower}");
            Console.WriteLine($"Có ký tự chữ hoa: {hasUpper}");


            // 4. Kiểm tra str có tính đối xứng hay không
            string reversedStr = new string(str.ToCharArray().Reverse().ToArray());
            bool isPalindrome = str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"Chuỗi có đối xứng: {isPalindrome}");

            // 5. Tính số từ trong str
            int wordCount = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine($"Số từ trong chuỗi: {wordCount}");
            // 6. Cắt tất cả dấu cách đầu chuỗi, cuối chuỗi, cả chuỗi
            string trimmedStr = str.Trim();
            Console.WriteLine($"Chuỗi sau khi cắt dấu cách: '{trimmedStr}'");



            Console.WriteLine("Nhap mot chuoi:");
            string str2 = Console.ReadLine();


            Console.WriteLine(" ki tu dem:");
            char char2 = char.Parse(Console.ReadLine());
            int dem = 0;

            for (int i = 0; i < str.Length; i++) { 
                if (str[i] == char2) { dem++; }
            }

         
            /*
            foreach (char c in str) { 
            
                if (c == char1) { dem++;
            }*/

            Console.WriteLine("{0}",dem);
        }


        public static void ChuoiString3() { 

           /* StringBuilder stringBuilder = new StringBuilder();
            string str = Console.ReadLine();
            stringBuilder.Append(str);*/

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("Worlds");


            // Xóa dữ liệu bằng cách thiết lập lại chiều dài của StringBuilder
            sb.Clear();
            Console.WriteLine("Sau khi xóa dữ liệu: " + sb.ToString());

            sb.AppendFormat("Xin chào {0}, chào mừng đến với {1}!", "bạn", "thế giới ");

            int mid = 0;

            mid = sb.Length/2;
           
            sb.Insert(mid, "Chisat");
            sb.Remove(3, 5); 
            sb.Replace("a","e");
            Console.WriteLine(sb);
        }



        public static void ChuoiString4() {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập tên tiếng Việt: ");
            string input = Console.ReadLine();

            // Loại bỏ khoảng trắng đầu và cuối, tách từ và chuẩn hóa
            string[] words = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                // Viết hoa chữ cái đầu và viết thường các chữ cái còn lại
                words[i] = char.ToUpper(words[i][0], CultureInfo.CurrentCulture) + words[i].Substring(1).ToLower(CultureInfo.CurrentCulture);
            }

            // Ghép các từ đã chuẩn hóa thành một chuỗi
            string normalizedString = string.Join(" ", words);

            Console.WriteLine($"Chuỗi sau khi chuẩn hóa: '{normalizedString}'");
        }
        public static void ChuoiString5()
        {

            Console.OutputEncoding = Encoding.UTF8;

            StringBuilder sb =  new StringBuilder();
            sb.Append("  Nguyen    Van a   ");

            while (sb[0] == ' ' ) {

                sb.Remove(0,1);
            }
            while (sb[sb.Length - 1] == ' ')
            {

                sb.Remove(sb.Length - 1, 1);
            }
            for (int i = 0; i < sb.Length; i++) {

                if (sb[i] == ' ') {

                    while (sb[i +1] == ' ')
                    {
                        sb.Remove(i + 1 , 1);
                    }
                
                }
            
            }



            Console.WriteLine(sb.ToString());
        }


    }
}
