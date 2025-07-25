//bai 2 hàm kiểm tra 2 số thực cùng dấu hay khác dấu
using System;
namespace bai2
{
    class Program
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
           if (a * b > 0)
            {
                Console.WriteLine("Cung dau");
            }
            else if (a * b < 0)
            {
                Console.WriteLine("Khac dau");
            }
            else
            {
                Console.WriteLine("Mot trong hai so bang 0");
            }
        }
    }
}