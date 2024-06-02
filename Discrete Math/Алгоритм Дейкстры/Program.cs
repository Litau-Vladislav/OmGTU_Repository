using System;
using System.Collections.Generic;

class AlgorithmOfDijkstra
{
    public static void Dijkstra(int[,] graph, int source, int V)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }
        dist[source] = 0;
        for (int count = 0; count < V - 1; count++)
        {
            int min = int.MaxValue;
            int minI = -1;
            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && dist[v] <= min)
                {
                    min = dist[v];
                    minI = v;
                }
            }
            int u = minI;
            visited[u] = true;
            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }
        Console.WriteLine("Кратчайшее расстояние из начальной вершины до каждой другой:");
        Console.WriteLine("Номер вершины \t Расстояние до вершины");
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine((i + 1) + "\t\t\t" + dist[i]);
        }
    }

    static void Main()
    {
        int V = 7;
        int[,] graph = new int[V, V];
        graph[0, 2] = 11;
        graph[0, 3] = 15;
        graph[0, 4] = 7;
        graph[1, 4] = 14;
        graph[1, 5] = 18;
        graph[2, 1] = 9;
        graph[2, 3] = 13;
        graph[2, 4] = 7;
        graph[2, 5] = 11;
        graph[2, 6] = 22;
        graph[3, 5] = 11;
        graph[3, 6] = 16;
        graph[4, 5] = 8;
        graph[4, 6] = 23;
        graph[5, 6] = 19;
        Dijkstra(graph, 0, V);
    }
}