namespace Graph
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int verticesCount = 4;
            GraphRepresentation graph = new GraphRepresentation(verticesCount);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);

            graph.DisplayMatrix();
            graph.DisplayList();
        }
    }
}
