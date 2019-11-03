using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string s1 = Console.ReadLine();
            s1.ToLower();
            string s2 = "";
            for (int i = s1.Length - 1; i >= 0; i--) s2 += s1[i];
            if (s1 == s2) Console.WriteLine("Введенное слово является палиндромном");
            else Console.WriteLine("Введенное слово не является палиндромном");
        }
    }
}
