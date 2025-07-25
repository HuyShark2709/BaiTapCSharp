//9. Viết hàm tỉnh tổng các phần tử trong mảng
using System;
namespace bai9
{
    class Program
    {
        static int TinhTongMang(int[] arr)
        {
            int tong = 0;
            foreach (int item in arr)//Duyệt từng phần tử trong mảng
            {
                tong += item; 
            }
            return tong;
        }
        static void Main()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Số lượng phần tử phải là số nguyên dương.");
                return;
            }
            int[] arr = new int[n];
            Console.WriteLine("Nhập các phần tử trong mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int tong = TinhTongMang(arr);
            Console.WriteLine($"Tổng các phần tử trong mảng là: {tong}");
        }
    }
}