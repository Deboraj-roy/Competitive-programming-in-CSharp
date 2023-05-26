namespace C
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static bool IsConnected(string[] strings)
        {
            int n = strings.Length;
            var adjList = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                adjList[i] = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;
                    int diffCount = 0;
                    for (int k = 0; k < strings[i].Length; k++)
                    {
                        if (strings[i][k] != strings[j][k]) diffCount++;
                        if (diffCount > 1) break;
                    }
                    if (diffCount == 1) adjList[i].Add(j);
                }
            }
            var visited = new bool[n];
            void DFS(int u)
            {
                visited[u] = true;
                foreach (int v in adjList[u])
                {
                    if (!visited[v]) DFS(v);
                }
            }
            DFS(0);
            for (int i = 0; i < n; i++)
            {
                if (!visited[i]) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            var strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }
            Console.WriteLine(IsConnected(strings) ? "Yes" : "No");
        }
    }

}