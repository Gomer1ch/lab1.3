using System;

namespace Лаба_1_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, x, x1, x2, dx, a, c;

            Console.Write("Введите начало интервала x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите конец интервала x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длинну шага dx=");
            dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c=");
            c = Convert.ToDouble(Console.ReadLine());
            for (x = x1; x <= x2; x = x + dx)
            {
                if (c < 0 & a != 0) F = -a * x * x;
                else
                    if (c > 0 & a == 0) F = (a - x) / (c * x);
                else
                    F = x / c;
                Console.WriteLine("x=" + x + " F=" + F);
            }
            Console.ReadKey();
        }
    }
}
