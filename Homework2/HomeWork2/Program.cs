using System;

namespace HomeWork2
{
    class Program
    {
        static double segment1(double x, double r)
        {
            double a = -8;
            double b = -2;
            double y;
            y = Math.Sqrt(r * r - (x - a) * (x - a)) + b;
            return y;
        }
        static double segment2(double x)
        {
            double y;
            double k = 0.5;
            double b = 1;
            y = k * x + b;
            return y;
        }
        static double segment3(double x)
        {
            double y;
            y = (x - 6) * (x - 6);
            return y;
        }
        static void Main()
        {
            Console.WriteLine("Введите значение R - радиуса окружности: ");
            double r = double.Parse(Console.ReadLine());
            if (r < 2)
            {
                Console.WriteLine("Введенное значение R приведет к тому, что функция будет иметь область неопределенных значений");
            }
            for (double x = -10; x <= 8.01; x += 0.2)
            {
                if (x < -6)
                {
                    if (x>(-8-r)&&x<(-8+r))
                    {
                        Console.WriteLine("y({0:0.0}) = {1:0.00}", x, segment1(x, r));
                    }
                    else
                    {
                        Console.WriteLine("значение функции не определено");
                    }
                }
                else if (x < 2)
                {
                    Console.WriteLine("y({0:0.0}) = {1:0.00}", x, segment2(x));
                }
                else if (x < 6)
                {
                    Console.WriteLine("y({0:0.0}) = {1:0.00}", x, 0);
                }
                else if (x <= 8.01)
                {
                    Console.WriteLine("y({0:0.0}) = {1:0.00}", x, segment3(x));
                }
            }
        }
    }
}
