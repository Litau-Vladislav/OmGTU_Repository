namespace Prim
{
    class Program
    {
        static void Main()
        {
            int n = 8; 
            double[,] mat = new double[n, n];
            int[] V = new int[n];
            List<double> ostov = new List<double>();
            List<int> U = [0];
            double ans = 0;
            List<int> v = new List<int>();
            List<int> u = new List<int>();
            for (int i = 0; i < n; i++)
            {
                V[i] = i+1;
            }
            mat[0, 1] = 2;
            mat[0, 2] = 2;
            mat[0, 4] = 7;
            mat[1, 3] = 9;
            mat[1, 4] = 2;
            mat[1, 2] = 2;
            mat[2, 4] = 5;
            mat[3, 4] = 10;
            mat[3, 6] = 2;
            mat[3, 5] = 5;
            mat[3, 7] = 16;
            mat[4, 6] = 9;
            mat[5, 7] = 17;
            mat[6, 7] = 17;
            while (U.Count != V.Length)
            {
                double rmin = double.PositiveInfinity;
                int noj = 0;
                int noi = 0;
                for (int i = 0; i < U.Count; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (U.Contains(j))
                        {
                            continue;
                        }
                        else
                        {
                            if (mat[U[i], j] < rmin && mat[U[i], j] != 0)
                            {
                                rmin = mat[U[i], j];
                                noi = U[i];
                                noj = j;
                            }
                        }
                    }
                }
                mat[noi, noj] = double.PositiveInfinity;
                mat[noj, noi] = double.PositiveInfinity;
                v.Add(noi); 
                u.Add(noj);
                U.Add(noj);
                ostov.Add(rmin); 
            }

            for (int i = 0; i<ostov.Count; i++)
            {
                ans += ostov[i];
            }
            Console.WriteLine("Длина остовного дерева: " + ans);
            Console.WriteLine("Ребро \tВес");
            for (int i = 0; i < ostov.Count; i++)
            {
                Console.WriteLine((v[i] + 1) + " - " + (u[i] + 1) + "\t" + ostov[i]);
            }
        }
    }
}