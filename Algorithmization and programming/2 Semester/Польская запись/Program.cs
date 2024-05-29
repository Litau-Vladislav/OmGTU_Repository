using System;
using System.Collections.Generic;

namespace Polskaya
{
    class Program
    {
        static void Main()
        {
            double x1, x2;
            string primer = "2 4 + 3 * 6 + 8 /";
            string[] pr = primer.Split(' ');
            Stack<string> stack = new Stack<string>();
            foreach (string p in pr)
            {
                if (p == "*" || p == "-" || p == "+" || p == "/")
                {
                    if (stack.Count != 2)
                    {
                        Console.WriteLine("Неверное количество чисел для операции.");
                    }
                    else
                    {
                        string operation2 = stack.Pop();
                        string operation1 = stack.Pop();
                        if (double.TryParse(operation1, out x1) && double.TryParse(operation2, out x2))
                        {
                            if (p == "+") stack.Push(Convert.ToString(x1 + x2));
                            else if (p == "-") stack.Push(Convert.ToString(x1 - x2));
                            else if (p == "*") stack.Push(Convert.ToString(x1 * x2));
                            else if (p == "/")
                            {
                                if (x2 == 0)
                                {
                                    Console.WriteLine("Делить на ноль нельзя.");
                                }
                                stack.Push(Convert.ToString(x1/x2));
                            }
                            else Console.WriteLine("Некорректная операция: " + p);
                        }
                        else
                        {
                            if (p == "+") stack.Push(Convert.ToString("(" + operation1 + " + " + operation2 + ")"));
                            else if (p == "-") stack.Push(Convert.ToString("(" + operation1 + " - " + operation2 + ")"));
                            else if (p == "-") stack.Push(Convert.ToString("(" + operation1 + " * " + operation2 + ")"));
                            else if (p == "-")
                            {
                                if (operation2 == "0")
                                {
                                    Console.WriteLine("Делить на ноль нельзя.");
                                }
                                stack.Push(Convert.ToString("(" + operation1 + "/" + operation2 + ")"));
                            }
                            else Console.WriteLine("Некорректная операция: " + p);
                        }
                    }
                }
                else stack.Push(p);
            }
            Console.WriteLine("Ответ: " + stack.Pop());
        }
    }
}