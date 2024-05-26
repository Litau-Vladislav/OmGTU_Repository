using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp44
{
    internal class Program
    {
        delegate void Slozhenie();
        delegate void Raznost();
        delegate void Proizvedenie();
        delegate void KvKoren();
        delegate void Delenie();
        delegate void Sin();
        delegate void Cos();
        static void Main()
        {
            Slozhenie sloz = Add;
            Raznost razn = Subtract;
            Proizvedenie proizv = Multiply;
            KvKoren KvKr = Koren;
            Delenie delen = Divide;
            Sin sin = Sinus;
            Cos cos = Cosinus;

            bool a = true;
            while (a)
            {
                Console.WriteLine("Выберите нужный Вам пункт в меню:");
                Console.WriteLine("1. Математические операции");
                Console.WriteLine("0. Выход\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bool b = true;
                        while (b)
                        { 
                        Console.WriteLine("Выберите математическую операцию: ");
                        Console.WriteLine("1. Сложение");
                        Console.WriteLine("2. Разность");
                        Console.WriteLine("3. Произведение");
                        Console.WriteLine("4. Извлечение квадратного корня");
                        Console.WriteLine("5. Деление");
                        Console.WriteLine("6. Синус угла");
                        Console.WriteLine("7. Косинус угла");
                        Console.WriteLine("0. Выход");
                        int x = Convert.ToInt32(Console.ReadLine());
                            if (x == 0)
                            {
                                b = false;
                                Console.Clear();
                            }
                        else if (x == 1) sloz();
                        else if (x == 2) razn();
                        else if (x == 3) proizv();
                        else if (x == 4) KvKr();
                        else if (x == 5) delen();
                        else if (x == 6) sin();
                        else if (x == 7) cos();
                            else Console.WriteLine("Такого пункта не существует в меню");
                        }

                        break;
                    case 0:
                        a = false;
                        break;
                    default:
                        Console.WriteLine("\nТакого пункта не существует в меню");
                        break;
                }
            }
        }

        static public void Add()
        {
            Console.Clear();
            Console.WriteLine("\nВведите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат сложения введенных чисел: " + (a + b));
        }
        static public void Subtract()
        {
            Console.Clear();
            Console.WriteLine("\nВведите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат разности введенных чисел: " + (a - b));
        }
        static public void Multiply()
        {
            Console.Clear();
            Console.WriteLine("\nВведите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат произведения введенных чисел: " + (a * b));
        }
        static public void Koren()
        {
            Console.Clear();
            Console.WriteLine("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Нельзя излвечь корень из отрицательного числа");
                return;
            }
            Console.WriteLine("Результат извлечения квадратного корня введенного числа: " + Math.Sqrt(a));
        }
        static public void Divide()
        {
            Console.Clear();
            Console.WriteLine("\nВведите два числа: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя");
                return;
            }
            Console.WriteLine("Результат деления введенных чисел " + (a / b));
        }
        static public void Sinus()
        {
            Console.Clear();
            Console.WriteLine("Введите угол, синус которого Вы хотите найти: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат извлечения квадратного корня введенного числа: " + Math.Sin(a));
        }
        static public void Cosinus()
        {
            Console.Clear();
            Console.WriteLine("Введите угол, косинус которого Вы хотите найти: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат извлечения квадратного корня введенного числа: " + Math.Cos(a));
        }
    }
}