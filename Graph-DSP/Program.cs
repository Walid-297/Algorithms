namespace Graph_DSP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 5-node weighted, directed graph represented as an Adjacency Matrix
            int[,] adjacencyMatrix = new int[,]
            {
            { 0, 10,  3,  0,  0 },
            { 0,  0,  1,  2,  0 },
            { 0,  4,  0,  8,  2 },
            { 0,  0,  0,  0,  7 },
            { 0,  0,  0,  9,  0 }
            };

            int verticesCount = 5;
            int sourceVertex = 0;

            DijkstrasSolver solver = new DijkstrasSolver();
            solver.FindShortestPaths(adjacencyMatrix, verticesCount, sourceVertex);
        }
    }
}
