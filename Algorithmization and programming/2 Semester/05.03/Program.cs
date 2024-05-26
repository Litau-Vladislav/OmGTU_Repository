namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> set1 = new List<int>();
            List<int> set2 = new List<int>();
            List<int> set3 = new List<int>();
            bool flag = true;
            Console.WriteLine("Заполните первое множество: ");
            while (flag)
            {
                Console.Write("Введите элемент первого множества (если вы закончили ввод элементов, введите <<->>: ");
                string n = Console.ReadLine();
                if (n != "-") set1.Add(Convert.ToInt32(n));
                else break;
            }
            Console.WriteLine("Заполните второе множество: ");
            while (flag)
            {
                Console.Write("Введите элемент второго множества (если вы закончили ввод элементов, введите <<->>: ");
                string n = Console.ReadLine();
                if (n != "-") set2.Add(Convert.ToInt32(n));
                else break;
            }
            Console.WriteLine("Заполните третье множество: ");
            while (flag)
            {
                Console.Write("Введите элемент третьего множества (если вы закончили ввод элементов, введите <<->>: ");
                string n = Console.ReadLine();
                if (n != "-") set3.Add(Convert.ToInt32(n));
                else break;
            }

            var per = set1.Intersect(set2);
            per = set3.Intersect(per);
            Console.WriteLine("Пересечение множеств: ");
            foreach (int i in per)
            {
                Console.Write(i+"  ");
            }
            Console.WriteLine();

            var ob = set1.Union(set2);
            ob = set3.Union(ob);
            Console.WriteLine("Объединение множеств: ");
            foreach (var i in ob)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            var dop1 = ob.Except(set1);
            Console.WriteLine("Дополнение первого множества до объединения всех множеств: ");
            foreach (var i in dop1)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            var dop2 = ob.Except(set2);
            Console.WriteLine("Дополнение второго множества до объединения всех множеств: ");
            foreach (var i in dop2)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            var dop3 = ob.Except(set3);
            Console.WriteLine("Дополнение третьего множества до объединения всех множеств: ");
            foreach (var i in dop3)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }
    }
}