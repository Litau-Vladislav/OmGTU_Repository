namespace PoiskVShirinu
{
    class Program
    {
        static void Bfs(int[,] graph, int start, int V, int[] KompSv)
        {
            int[] distance = new int[V];
            Queue<int> q = new Queue<int>();
            distance[start] = 0;
            q.Enqueue(start);
            while (q.Count > 0)
            {
                int vertex = q.Dequeue();
                for (int i = 0; i < V; i++)
                {
                    if (graph[vertex, i] == 1 && distance[i] == 0)
                    {
                        distance[i] = distance[vertex] + 1;
                        q.Enqueue(i);
                        KompSv[i] = KompSv[vertex];
                    }              
                }
            }
        }
        static void Main()
        {
            int V = 8;
            int[] ksv = new int[V];
            ksv[0] = 1;
            int[,] Graph = new int[V, V];
            Graph[0, 1] = 1; 
            Graph[0, 2] = 1; 
            Graph[0, 4] = 1; 
            Graph[1, 4] = 1;
            Graph[1, 2] = 1; 
            Graph[2, 4] = 1;
            Graph[3, 7] = 1;
            Graph[3, 6] = 1;
            Graph[3, 5] = 1;
            Graph[6, 7] = 1;
            Graph[5, 7] = 1;
            Bfs(Graph, 0, V, ksv);
            for (int i = 0; i < V;i++)
            {
                if (ksv[i] == 0)
                {
                    int min = int.MaxValue;
                    for (int j = 0; j < V; j++)
                    {
                        if (ksv[j] < min && ksv[j] != 0) min = ksv[j];
                    }
                    ksv[i] = min + 1;
                    Bfs(Graph, i, V, ksv);
                }
            }
            Console.WriteLine("Вершина \tКомпонента связности");
            for (int i = 0; i < V; i++)
            {
                Console.WriteLine(i + "\t\t\t" + ksv[i]);
            }
        }
    }
}