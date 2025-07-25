//7. Viết hàm nhập, xuất mảng 1 chiều các số nguyên.
using System;
namespace bai7
{
    class Program
    {
        static void NhapMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XuatMang(int[] arr)
        {
            Console.WriteLine("Cac phan tu trong mang la:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
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
            NhapMang(arr);
            XuatMang(arr);
        }
    }
}
