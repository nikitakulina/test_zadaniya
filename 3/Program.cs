using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую координату 1-ого отрезка");
            Console.Write("x1-");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1-");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую координату 1-ого отрезка");
            Console.Write("x2-");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2-");
            double y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первую координату 2-ого отрезка");
            Console.Write("x3-");
            double x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3-");
            double y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую координату 2-ого отрезка");
            Console.Write("x4-");
            double x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4-");
            double y4 = Convert.ToInt32(Console.ReadLine());
            double vekt_1 = (x4 - x3) * (y1 - y3) - (y4 - y3) * (x1 - x3);
            double vekt_2 = (x4 - x3) * (y2 - y3) - (y4 - y3) * (x2 - x3);
            double vekt_3 = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
            double vekt_4 = (x2 - x1) * (y4 - y1) - (y2 - y1) * (x4 - x1);
            if ((vekt_1 * vekt_2 < 0) & (vekt_3 * vekt_4) < 0) Console.WriteLine("Отрезки имеют точку пересечения");
            else Console.WriteLine("Отрезки не имеют точку пересечения");
        }
    }
}
