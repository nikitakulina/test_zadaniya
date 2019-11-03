using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("НОД - {0}, НОК - {1}.", Nod(a, b).ToString(), Nok(a, b).ToString());
        }

        static int Nod(int first, int second)
        {
            int result = 0;
            if (first > second)
            {
                for (int i = second; i > 0; i--)
                    if ((first % i == 0) & (second % i == 0))
                    {
                        result = i;
                        break;
                    }
            }
            else
            {
                for (int i = first; i > 0; i--)
                    if ((first % i == 0) & (second % i == 0))
                    {
                        result = i;
                        break;
                    }
            }
            return result;
        }

        static int Nok(int first, int second)
        {
            int result,add;
            if (first>second)
            {
                add = first;
                result = first;
                while ((result % second != 0) | (result % first != 0)) result += add;
            }
            else
            {
                add = second;
                result = second;
                while ((result % second != 0) | (result % first != 0)) result += add;
            }
            return result;
        }
    }
}
