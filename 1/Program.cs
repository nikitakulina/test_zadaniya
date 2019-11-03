using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n>1)
            {
                for (int i = 2; i <= n; i++)
                {
                    int count = 1;
                    for (int j = 1; j <= i/2; j++)
                        if (i % j == 0) count += 1;
                    if (count == 2) Console.Write("{0} ",i.ToString());
                }            
            }
        }
    }
}
