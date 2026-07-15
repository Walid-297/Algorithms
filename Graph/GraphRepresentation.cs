using System;
using System.Collections.Generic;

public class GraphRepresentation
{
    private int totalVertices;
    private int[,] adjacencyMatrix;
    private List<int>[] adjacencyList;

    public GraphRepresentation(int vertices)
    {
        totalVertices = vertices;
        adjacencyMatrix = new int[vertices, vertices];
        adjacencyList = new List<int>[vertices];

        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int source, int destination, int weight = 1)
    {
        adjacencyMatrix[source, destination] = weight;
        adjacencyList[source].Add(destination);
    }

    public void DisplayMatrix()
    {
        Console.WriteLine("Adjacency Matrix Representation:");
        for (int i = 0; i < totalVertices; i++)
        {
            for (int j = 0; j < totalVertices; j++)
            {
                Console.Write(adjacencyMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void DisplayList()
    {
        Console.WriteLine("\nAdjacency List Representation:");
        for (int i = 0; i < totalVertices; i++)
        {
            Console.Write($"Vertex {i}: ");
            foreach (var neighbor in adjacencyList[i])
            {
                Console.Write($"-> {neighbor} ");
            }
            Console.WriteLine();
        }
    }
}
