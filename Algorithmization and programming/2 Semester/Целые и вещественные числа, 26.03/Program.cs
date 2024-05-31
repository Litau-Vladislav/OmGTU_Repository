namespace ConsoleApp44
{
    class Program
    {
        static void Slozhenie(int a, int b)
        {
            Console.WriteLine("Результат сложения: " + (a + b));
        }
        static void Raznost(int a, int b)
        {
            Console.WriteLine("Результат разности: " + (a - b));
        }
        static void Proizvedenie(int a, int b)
        {
            Console.WriteLine("Результат произведения: " + (a * b));
        }
        static void Delenie(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя.");
            }
            else if (a % b != 0)
            {
                Console.WriteLine("Деление с остатком. Целая часть от деления: " + (a / b));
            }
            else Console.WriteLine("Результат деления:  " + (a / b));
        }
        static void DSlozhenie(double a, double b)
        {
            Console.WriteLine("Результат сложения: " + (a + b));
        }
        static void DRaznost(double a, double b)
        {
            Console.WriteLine("Результат разности: " + (a - b));
        }
        static void DProizvedenie(double a, double b)
        {
            Console.WriteLine("Результат произведения: " + (a * b));
        }
        static void D_Delenie(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя.");
            }
            else Console.WriteLine("Результат деления: " + (a / b));
        }
        static void Main()
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine("Выберите, с каким типом чисел Вы ходите проводить вычисления: ");
                Console.WriteLine("1. Целые числа");
                Console.WriteLine("2. Вещественные числа");
                Console.WriteLine("0. Выход");
                string x = Console.ReadLine();
                Console.Clear();
                switch (x)
                {
                    case "1":
                        Console.WriteLine("Введите два целых числа: ");
                        int vib1 = Convert.ToInt32(Console.ReadLine());
                        int vib2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результаты вычислений для двух целых чисел: ");
                        Slozhenie(vib1, vib2);
                        Raznost(vib1, vib2);
                        Proizvedenie(vib1, vib2);
                        Delenie(vib1, vib2);
                        while (true)
                        {
                            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню.");
                            string back = Console.ReadLine();
                            if (back != null) break;
                        }
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Введите два вещественных числа: ");
                        double Dvib1 = Convert.ToDouble(Console.ReadLine());
                        double Dvib2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Результаты вычислений для двух вещественных чисел: ");
                        DSlozhenie(Dvib1, Dvib2);
                        DRaznost(Dvib1, Dvib2);
                        DProizvedenie(Dvib1, Dvib2);
                        D_Delenie(Dvib1, Dvib2);
                        while (true)
                        {
                            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню.");
                            string back = Console.ReadLine();
                            if (back != null) break;
                        }
                        Console.Clear();
                        break;
                    case "0":
                        a = false;
                        Console.Clear();
                        break;
                    case "":
                        a = false; 
                        Console.Clear(); 
                        break;
                    default:
                        Console.WriteLine("\nНе существует такого пункта в меню.");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}