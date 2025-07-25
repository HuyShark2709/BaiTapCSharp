//6. Viết hàm kiểm tra tam giác, khi nhập 3 cạnh của 1 tam giác,
using System;
namespace bai6
{
    class Program
    {
        public static bool KiemTraTamGiac(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        public static void Main()
        {
            Console.Write("Nhap canh a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            double c = double.Parse(Console.ReadLine());
            if (KiemTraTamGiac(a, b, c))
            {
                Console.WriteLine("Day la 3 canh cua mot tam giac.");
            }
            else
            {
                Console.WriteLine("Day khong phai la 3 canh cua mot tam giac.");
            }
        }
    }
}