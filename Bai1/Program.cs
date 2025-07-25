//bai1 hàm tìm số lớn nhát trong 3 số thực dược nhập từ bàn phím
using System;
namespace bai1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai: "); 
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ ba: ");
            double c = double.Parse(Console.ReadLine());
            double max = a;
            if (b > max)
                max = b;

            if (c > max)
                max = c;
            Console.WriteLine("Số lớn nhất là: " + max);
        }
    }
}