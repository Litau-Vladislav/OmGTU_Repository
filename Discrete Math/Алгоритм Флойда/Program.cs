namespace AlgorythmOfFloyd
{
    class Program
    {
        static void Floyd(double[,] graph)
        {
            for (int k = 0; k < graph.GetLength(0); k++)
            {
                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    for (int j = 0; j < graph.GetLength(0); j++)
                        if (i != j && graph[i, j] > graph[i, k] + graph[k, j])
                        {
                            graph[i, j] = graph[i, k] + graph[k, j];
                        }
                }
            }
            Console.WriteLine("Кратчайшие расстояния между всеми парами вершин:\n");
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(0); j++)
                {
                    if (graph[i, j] == double.PositiveInfinity) Console.Write("INF    ");
                    else Console.Write(graph[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            double[,] graph =    {{0, 4, double.PositiveInfinity, double.PositiveInfinity, 4, 4, double.PositiveInfinity},
                               {double.PositiveInfinity, 0, double.PositiveInfinity, double.PositiveInfinity, -5, 4, double.PositiveInfinity},
                               {double.PositiveInfinity, -3, 0, 3, double.PositiveInfinity, 3, double.PositiveInfinity},
                               {double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, 0, double.PositiveInfinity, double.PositiveInfinity, 2},
                               {double.PositiveInfinity, double.PositiveInfinity, 9, double.PositiveInfinity, 0, double.PositiveInfinity, double.PositiveInfinity},
                               {double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, 1, double.PositiveInfinity, 0, double.PositiveInfinity},
                               {double.PositiveInfinity, double.PositiveInfinity, -4, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, 0}};
            Floyd(graph);
        }
    }
}