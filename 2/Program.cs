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

        static int Fibonachi(int first, int second,int count)
        {
            for (int i = second; i < count; i++)
            {
                if (i == first+second)
                {
                    Console.Write("{0} ", i);
                    return Fibonachi(second, i, count);
                }
            }
            return 0;
        }
    }
}
