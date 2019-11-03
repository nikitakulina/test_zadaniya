using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string symb = "1234567890";
            for (int i = 0; i < symb.Length; i++)
            {
                if (text.Contains(symb[i])) text = text.Replace(symb[i],' ');
            }
            Console.WriteLine("Получившаяся строка - " + text);
        }
    }
}
