//10. Viết hàm đếm số lượng số chân trong máng
using System;

namespace bai10
{
    class Program
    {
        static bool KiemTraSoChan(int n)
        {
            return n % 2 == 0;
        }
        static int DemSoChanTrongMang(int[] arr)
        {
            int dem = 0;
            foreach (int item in arr)
            {
                if (KiemTraSoChan(item))
                {
                    dem++;
                }
            }
            return dem;
        }
        static void Main()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("So luong phan tu phai la so nguyen duong.");
                return;
            }
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu trong mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int soChan = DemSoChanTrongMang(arr);
            Console.WriteLine($"So luong so chan trong mang la: {soChan}");
        }
    }
}
