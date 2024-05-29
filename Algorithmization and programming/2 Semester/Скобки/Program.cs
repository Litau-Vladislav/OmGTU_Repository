using System;
using System.Collections;
using System.Collections.Generic;
namespace Skobki
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, char> Skobki = new Dictionary<char, char>();
            Skobki['('] = ')';
            Skobki['['] = ']';
            Skobki['{'] = '}';
            Stack<char> check = new Stack<char>();
            Console.WriteLine("Введите выражение: ");
            string str = Console.ReadLine();
            foreach (char s in str)
            {
                if (Skobki.ContainsKey(s))
                {
                    check.Push(s);
                }
                else if (Skobki.ContainsValue(s))
                {
                    if (check.Count == 0 || Skobki[check.Peek()] != s)
                    {
                        Console.WriteLine("Скобки расставленны неверно.");
                        check.Push(' ');
                        break;
                    }
                    if (check.Count != 0) check.Pop();
                }
            }
            if (check.Count == 0) Console.WriteLine("Скобки расставленны верно.");
        }
    }
}