// Viết hàm tính tổng của dãy số sau: S(n) = 1 + 2 + 3 + ...+n(trong đó n là số nguyên dương).
using System;
namespace bai4
{
    class Program
    {
        public static int TinhTong(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;//tong = tong + i;
            }
            return tong;
        }
        public static void Main()
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui long nhap so nguyen duong.");
            }
            else
            {
                int tong = TinhTong(n);
                Console.WriteLine($"Tong cua day so S({n}) = 1 + 2 + ... + {n} la: {tong}");
            }
        }
    }
}