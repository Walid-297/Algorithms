using System;
using System.Collections.Generic;

public class BreadthFirstSearch
{
    private int totalVertices;
    private List<int>[] adjacencyList;

    public BreadthFirstSearch(int vertices)
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

    public void Traverse(int startVertex)
    {
        bool[] visited = new bool[totalVertices];
        Queue<int> queue = new Queue<int>();

        // Initialize the traversal from the start vertex
        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        Console.Write("BFS Traversal Path: ");

        while (queue.Count > 0)
        {
            // Dequeue a vertex from the queue and print it
            int current = queue.Dequeue();
            Console.Write($"{current} ");

            // Explore all adjacent neighbors of the current vertex
            foreach (int neighbor in adjacencyList[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
        Console.WriteLine();
    }
}