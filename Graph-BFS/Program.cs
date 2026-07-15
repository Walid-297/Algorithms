namespace Graph_BFS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create an undirected graph with 6 vertices (0 to 5)
            int verticesCount = 6;
            BreadthFirstSearch graph = new BreadthFirstSearch(verticesCount);

            // Add edges to build the graph topology
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(3, 5);
            graph.AddEdge(4, 5);

            // Execute BFS starting from Node 0
            graph.Traverse(0);
        }
    }
}
