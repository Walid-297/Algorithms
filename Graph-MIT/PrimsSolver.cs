using System;

public class PrimsSolver
{
    private const int INF = 999999;

    public PrimsSolver() { }

    public void FindMST(int[,] graph, int totalVertices)
    {
        // Tracks vertices included in the Minimum Spanning Tree
        bool[] inMST = new bool[totalVertices];

        // Stores the minimum weight edge to connect each vertex to the MST
        int[] key = new int[totalVertices];

        // Parent array to store the constructed tree structure
        int[] parent = new int[totalVertices];

        // Initialize all keys as infinite and MST flags as false
        for (int i = 0; i < totalVertices; i++)
        {
            key[i] = INF;
            inMST[i] = false;
        }

        // Always include the first vertex in the MST first
        key[0] = 0;
        parent[0] = -1; // First node is always the root of MST

        for (int count = 0; count < totalVertices - 1; count++)
        {
            // Pick the minimum key vertex from the set of unvisited vertices
            int u = FindMinKeyVertex(key, inMST, totalVertices);

            // Add the picked vertex to the MST
            inMST[u] = true;

            // Update key values and parent index of adjacent vertices
            for (int v = 0; v < totalVertices; v++)
            {
                if (graph[u, v] != 0 && !inMST[v] && graph[u, v] < key[v])
                {
                    parent[v] = u;
                    key[v] = graph[u, v];
                }
            }
        }

        PrintMST(parent, graph, totalVertices);
    }

    private int FindMinKeyVertex(int[] key, bool[] inMST, int totalVertices)
    {
        int min = INF;
        int minIndex = -1;

        for (int v = 0; v < totalVertices; v++)
        {
            if (!inMST[v] && key[v] < min)
            {
                min = key[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    private void PrintMST(int[] parent, int[,] graph, int totalVertices)
    {
        Console.WriteLine("Edge \tWeight");
        int totalWeight = 0;

        for (int i = 1; i < totalVertices; i++)
        {
            Console.WriteLine($"{parent[i]} - {i} \t{graph[i, parent[i]]}");
            totalWeight += graph[i, parent[i]];
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Total Minimum Spanning Tree Weight: {totalWeight}");
    }
}