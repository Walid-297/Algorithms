using System;
using System.Collections.Generic;

public class DepthFirstSearch
{
    private int totalVertices;
    private List<int>[] adjacencyList;

    public DepthFirstSearch(int vertices)
    {
        totalVertices = vertices;
        adjacencyList = new List<int>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int source, int destination)
    {
        // Undirected graph representation
        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source);
    }

    // Main driver for DFS traversal
    public void Traverse(int startVertex)
    {
        bool[] visited = new bool[totalVertices];

        Console.Write("DFS Traversal Path: ");
        DFSRecursive(startVertex, visited);
        Console.WriteLine();
    }

    // Recursive helper method that executes the deep search
    private void DFSRecursive(int currentVertex, bool[] visited)
    {
        // Mark the current node as visited and print it
        visited[currentVertex] = true;
        Console.Write($"{currentVertex} ");

        // Recur for all adjacent vertices that have not been visited yet
        foreach (int neighbor in adjacencyList[currentVertex])
        {
            if (!visited[neighbor])
            {
                DFSRecursive(neighbor, visited);
            }
        }
    }
}
