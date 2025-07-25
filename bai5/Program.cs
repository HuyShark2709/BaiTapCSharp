//5. Viết hàm kiểm tra 1 số có phải là số nguyên tố hay không.
using System;
namespace bai5
{
    class Program
    {
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false; 
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false; 
            }
            return true;
        }
        public static void Main()
        {
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            if (KiemTraSoNguyenTo(n))
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}