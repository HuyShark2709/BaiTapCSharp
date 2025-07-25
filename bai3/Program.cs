// Viết hàm giải pt bậc nhất
using System;
namespace bai3
{
    class Program
    {
        public static void Main()
        {
         Double a = double.Parse(Console.ReadLine());
         Double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem x =" + x);
            }
        }
    }
}