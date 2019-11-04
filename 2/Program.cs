using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1, b = 1;
            Fibonachi(a, b, n);
        }

        static void Fibonachi(int first, int second,int count)
        {
            Console.Write("{0} {1} ", first, second);
            for (int i = second; i < count; i++)
            {
                if (i == first + second)
                {
                    Console.Write("{0} ", i);
                    first = second;
                    second = i;
                }
            }
        }
    }
}
