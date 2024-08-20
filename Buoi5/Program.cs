using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5
{
    internal class Program
    {
        static string NumberToWords(int number)
        {
            if (number == 0) return "không";
            if (number < 0) return "âm " + NumberToWords(Math.Abs(number));

            return ConvertNumberToWords(number);
        }

        static string ConvertNumberToWords(int number)
        {
            if (number == 0) return "";

            if (number < 10) return OneDigitToWord(number);
            if (number < 20) return TeenToWord(number);
            if (number < 100) return TensToWord(number);
            if (number < 1000) return HundredsToWord(number);
            if (number < 1000000) return ThousandsToWord(number);

            return MillionsToWord(number);
        }

        static string OneDigitToWord(int number)
        {
            switch (number)
            {
                case 1: return "một";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bốn";
                case 5: return "năm";
                case 6: return "sáu";
                case 7: return "bảy";
                case 8: return "tám";
                case 9: return "chín";
                default: return "";
            }
        }

        static string TeenToWord(int number)
        {
            switch (number)
            {
                case 10: return "mười";
                case 11: return "mười một";
                case 12: return "mười hai";
                case 13: return "mười ba";
                case 14: return "mười bốn";
                case 15: return "mười lăm";
                case 16: return "mười sáu";
                case 17: return "mười bảy";
                case 18: return "mười tám";
                case 19: return "mười chín";
                default: return "";
            }
        }

        static string TensToWord(int number)
        {
            string result = "";
            int tens = number / 10;
            int ones = number % 10;

            switch (tens)
            {
                case 2: result = "hai mươi"; break;
                case 3: result = "ba mươi"; break;
                case 4: result = "bốn mươi"; break;
                case 5: result = "năm mươi"; break;
                case 6: result = "sáu mươi"; break;
                case 7: result = "bảy mươi"; break;
                case 8: result = "tám mươi"; break;
                case 9: result = "chín mươi"; break;
            }

            if (ones > 0)
            {
                result += " " + OneDigitToWord(ones);
            }

            return result;
        }

        static string HundredsToWord(int number)
        {
            int hundreds = number / 100;
            int remainder = number % 100;
            string result = OneDigitToWord(hundreds) + " trăm";

            if (remainder > 0)
            {
                result += " " + ConvertNumberToWords(remainder);
            }

            return result;
        }

        static string ThousandsToWord(int number)
        {
            int thousands = number / 1000;
            int remainder = number % 1000;
            string result = ConvertNumberToWords(thousands) + " nghìn";

            if (remainder > 0)
            {
                result += " " + ConvertNumberToWords(remainder);
            }

            return result;
        }

        static string MillionsToWord(int number)
        {
            int millions = number / 1000000;
            int remainder = number % 1000000;
            string result = ConvertNumberToWords(millions) + " triệu";

            if (remainder > 0)
            {
                result += " " + ConvertNumberToWords(remainder);
            }

            return result;
        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.Write("Nhập vào một số: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Số {0} được đọc là: {1}", number, NumberToWords(number));
            }
            else
            {
                Console.WriteLine("Vui lòng nhập vào một số hợp lệ!");
            }


            //ReNhanh.UCLN_BCNN();
        }
    }
}
