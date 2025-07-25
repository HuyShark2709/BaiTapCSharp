//8. Viết hàm tìm giá trị đầu tiên có chữ số đầu tiên là chữ số lẻ trong mảng 1 chiều các số nguyên
using System;

namespace bai8
{
    class Program
    {
        // Ham kiem tra chu so dau tien co phai la so le khong
        static bool LaSoLeDauTien(int n)
        {
            n = Math.Abs(n); // bo dau am
            while (n >= 10)
            {
                n /= 10; // chia de lay chu so dau tien
            }
            return n % 2 != 0; // kiem tra so le
        }

        // Tim gia tri dau tien co chu so dau tien la le
        static int TimGiaTriDauTienSoLeDauTien(int[] arr)
        {
            foreach (int item in arr)
            {
                if (LaSoLeDauTien(item))
                {
                    return item;
                }
            }
            return -1;
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

            int ketQua = TimGiaTriDauTienSoLeDauTien(arr);
            if (ketQua != -1)
            {
                Console.WriteLine($"Gia tri dau tien co chu so dau tien la so le: {ketQua}");
            }
            else
            {
                Console.WriteLine("Khong co gia tri nao co chu so dau tien la so le trong mang.");
            }
        }
    }
}
