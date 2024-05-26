namespace Menu0702
{
    internal class Obsh
    {
        static List<Auditorii> Auds;
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Menu.ShowTheMenu();
        }
        public class Menu
        {
            public Menu() { }
            public static void ShowTheMenu()
            {
                bool x = true;
                do
                {
                    Console.WriteLine(" 1. Создать базу данных \n 2. Добавить в базу данных аудиторию \n 3. Редактирование информации об аудитории по заданному номеру \n 4. Выборка аудиторий по количеству мест \n 5. Выборка аудиторий с проектором \n 6. Выборка аудиторий с пк и заданным кол-вом посадочных мест \n 7. Выборка аудиторий по номеру этажа \n 8. Вывод всех данных по аудиториям \n 9. Выход");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Auditorii.BD();
                            break;
                        case 2:
                            Auditorii.AddToBD();
                            break;
                        case 3:
                            Auditorii.Changing();
                            break;
                        case 4:
                            Auditorii.FindPlaces();
                            break;
                        case 5:
                            Auditorii.FindProjector();
                            break;
                        case 6:
                            Auditorii.FindPlacesPC();
                            break;
                        case 7:
                            Auditorii.FindFloor();
                            break;
                        case 8:
                            Auditorii.Info();
                            break;
                        case 9:
                            x = false;
                            break;

                    }
                }while (x);
            }
        }
        public class Auditorii
        {

            private string number;
            private int places;
            private bool projector;
            private int PC;


            public Auditorii(string number, int places, bool projector, int PC)
            {
                this.number = number;
                this.places = places;
                this.projector = projector;
                this.PC = PC;
            }


            public static void Print(Auditorii Auditorii)
            {
                Console.WriteLine("Номер аудитории: " + Auditorii.number + ". \nКоличество мест в аудитории: " + Auditorii.places + ". \nНаличие проектора в аудитории: " + Auditorii.projector + ". \nКоличество ПК в аудитории: " + Auditorii.PC);
            }


            public static void BD()
            {
                Auds = new List<Auditorii>();
                Console.WriteLine("База данных создана. Нажмите любую клавишу для перехода в меню.");
                Console.ReadKey();
                Console.Clear();
            }


            public static void AddToBD()
            {
                string number, HavingPr;
                int places;
                bool projector;
                int PC;
                Console.Write("Введите номер аудитории (первая цифра - этаж, вторая и третья цифры - номер аудитории): ");
                number = Console.ReadLine();
                for (int i = 0; i < Auds.Count; i++)
                {
                    if (Auds[i].number == number)
                    {
                        Console.WriteLine("Аудитория с таким номером уже добавлена в базу данных. Нажмите любую клавишу для перехода в меню. ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.Write("Введите количество мест в аудитории(числами): ");
                places = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите <<Да>>, если в аудитории есть проектор, или <<Нет>>, если в аудитории нет проектора: ");
                HavingPr = Console.ReadLine();
                if (HavingPr == "Да" || HavingPr == "да" || HavingPr == "дА" || HavingPr == "Да")
                {
                    projector = true;
                }
                else
                {
                    projector = false;
                }
                Console.Write("Введите количество компьютеров в аудитории: ");
                PC = Convert.ToInt32(Console.ReadLine());
                Auds.Add(new Auditorii(number, places, projector, PC));
                Console.Write("Введенная аудитория добавлена в базу данных. Нажмите любую клавишу для перехода в меню.");
                Console.ReadKey();
                Console.Clear();
            }


            public static void Changing()
            {
                Console.WriteLine("Введите номер аудитории, информацию о которой вы хотите отредактировать: ");
                string No = Console.ReadLine();
                int ch = 0;
                for (int i = 0; i < Auds.Count; i++)
                {
                    if (Auds[i].number == No)
                    {
                        string flag;
                        Console.Write("Введите отредактированный номер аудитории. Если редактирование не требуется, введите <<000>>: ");
                        flag = Console.ReadLine();
                        if (flag != "000")
                        {
                            Auds[i].number = flag;
                        }
                        Console.Write("Введите отредактированное количество мест в аудитории. Если редактирование не требуется, введите <<000>>: ");
                        flag = Console.ReadLine();
                        if (flag != "000")
                        {
                            Auds[i].places = Convert.ToInt32(flag);
                        }
                        Console.Write("Введите отредактированное наличие проектора в аудитории(<<Да>>, если в аудитории есть проектор, или <<Нет>>, если в аудитории нет проектора). Если редактирование не требуется, введите <<000>>: ");
                        flag = Console.ReadLine();
                        if (flag != "000")
                        {
                            string HavingPr = flag;
                            if (HavingPr == "Да" || HavingPr == "да" || HavingPr == "дА" || HavingPr == "Да")
                            {
                                Auds[i].projector = true;
                            }
                            else
                            {
                                Auds[i].projector = false;
                            }
                        }
                        Console.Write("Введите отредактированное количество компьютеров в аудитории. Если редактирование не требуется, введите <<000>>: ");
                        flag = Console.ReadLine();
                        if (flag != "000")
                        {
                            Auds[i].PC = Convert.ToInt32(flag);
                        }
                        ch = 1;
                    }
                }
                if (ch == 1)
                {
                    Console.WriteLine("Информация об аудитории отредактирована. Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (ch != 1)
                {
                    Console.WriteLine("В базе данных нет аудитории с введенным номером. Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


            public static void FindPlaces()
            {
                Console.Write("Введите необходимое количество мест: ");
                int pl = Convert.ToInt32(Console.ReadLine());
                int c = 0;
                for (int i = 0; i < Auds.Count; i++)
                {
                    if (Auds[i].places >= pl)
                    {
                        Print(Auds[i]);
                        c = 1;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine("Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (c != 1)
                {
                    Console.WriteLine("Аудитории не найдены. Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


            public static void FindProjector()
            {
                int pr = 0;
                for (int i = 0; i < Auds.Count; i++)
                {
                    if (Auds[i].projector == true)
                    {
                        Print(Auds[i]);
                        pr = 1;
                    }
                }
                if (pr == 1)
                {
                    Console.WriteLine("Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Аудиторий с проектором не найдено. Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


            public static void FindPlacesPC()
            {
                Console.WriteLine("Введите необходимое количество компьютеров в аудитории: ");
                int pc = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите необходимое количество мест в аудитории: ");
                int pl = Convert.ToInt32(Console.ReadLine());
                int c = 0;
                for (int i = 0; i < Auds.Count; i++)
                {
                    if (Auds[i].places >= pl && Auds[i].PC >= pc)
                    {
                        Print(Auds[i]);
                        c = 1;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine("Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (c != 1)
                {
                    Console.WriteLine("Аудитории не найдены. Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


            public static void FindFloor()
            {
                Console.WriteLine("Введите необходимый этаж: ");
                string floor = Console.ReadLine();
                int c = 0;
                for (int i = 0; i < Auds.Count; i++)
                {
                    char[] num = Auds[i].number.ToCharArray();
                    string n = Convert.ToString(num[0]);
                    if (floor == n)
                    {
                        Print(Auds[i]);
                        c = 1;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine("Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (c != 1)
                {
                    Console.WriteLine("Аудитории не найдены. Нажмите любую клавишу для перехода в меню.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            public static void Info()
            {
                for (int i = 0; i < Auds.Count; i++)
                {
                    Print(Auds[i]);
                }
                Console.WriteLine("Нажмите любую клавишу для перехода в меню.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}