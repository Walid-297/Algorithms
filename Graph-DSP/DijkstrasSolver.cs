using System;

public class DijkstrasSolver
{
    private const int INF = 999999;

    public DijkstrasSolver() { }

    public void FindShortestPaths(int[,] graph, int totalVertices, int sourceVertex)
    {
        int[] distances = new int[totalVertices];
        bool[] visited = new bool[totalVertices];

        // Initialize all distances as infinite and visited states as false
        for (int i = 0; i < totalVertices; i++)
        {
            distances[i] = INF;
            visited[i] = false;
        }

        // Distance from the source vertex to itself is always zero
        distances[sourceVertex] = 0;

        for (int count = 0; count < totalVertices - 1; count++)
        {
            // Pick the minimum distance vertex from the set of unvisited vertices
            int u = FindMinDistanceVertex(distances, visited, totalVertices);

            // Mark the picked vertex as processed
            visited[u] = true;

            // Update distance values of adjacent vertices of the picked vertex
            for (int v = 0; v < totalVertices; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && distances[u] != INF
                    && distances[u] + graph[u, v] < distances[v])
                {
                    distances[v] = distances[u] + graph[u, v];
                }
            }
        }

        PrintDistances(distances, totalVertices, sourceVertex);
    }

    private int FindMinDistanceVertex(int[] distances, bool[] visited, int totalVertices)
    {
        int min = INF;
        int minIndex = -1;

        for (int v = 0; v < totalVertices; v++)
        {
            if (!visited[v] && distances[v] <= min)
            {
                min = distances[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    private void PrintDistances(int[] distances, int totalVertices, int sourceVertex)
    {
        Console.WriteLine($"Shortest paths from Source Vertex {sourceVertex}:");
        Console.WriteLine("Vertex \t Distance from Source");

        for (int i = 0; i < totalVertices; i++)
        {
            string distanceStr = distances[i] == INF ? "INF" : distances[i].ToString();
            Console.WriteLine($"{i} \t\t {distanceStr}");
        }
    }
}