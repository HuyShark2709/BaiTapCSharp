//nhập vô 1 mảng in ra các giá trị chia cho 2 dư 1 và lớn hơn 10,in số đầu tiên của giá trị đó
using System;
class Program
{

    static void Main()
    {
        Console.WriteLine("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int firstValue = -1;
        bool found = false;
        Console.WriteLine("Nhap cac phan tu trong mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 0; i++)
        {
            int x = arr[i];
            if (x % 2 == 1 && x> 10)
            {
               Console.WriteLine(x);
            }
        }
        int Sodautien = 0;
         while (Sodautien < n) 
        {
            int x = arr[Sodautien];
            if (x % 2 == 1 && x > 10)
            {
                firstValue = x;
                found = true;
                break;
            }
            Sodautien++;
        }
        if (found)
        {
            int ChusoDautien = firstValue;
            while (ChusoDautien >= 10)
            {
                ChusoDautien /= 10; 
            }
            Console.WriteLine($"Gia tri dau tien co chu so dau tien la: {ChusoDautien}");
        }
        else
        {
            Console.WriteLine("Khong co phan tu nao trong mang thoa");
        } 
        Console.WriteLine("Cac Phan Tu chia cho 2 du 1:.");
        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 1 && arr[i] > 10)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
