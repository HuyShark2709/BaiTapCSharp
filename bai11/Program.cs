//nhập 1 mảng từ bàn phím đếm các phần tử trong đó chia cho 3 bằng 5
using System;
namespace bai11
{
    class program
    {
        static void Main()
        {
            Console.Write("nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
               Console.Write($"nhap phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            foreach (int x in arr)
            {
                if (x/3 == 5)
                {
                    count++;
                }
            }
            Console.WriteLine($"so phan tu chia cho 3 bang 5 la: {count}");
        }

    }
}