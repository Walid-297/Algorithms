namespace MIT_Graph
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 5-node weighted, undirected graph represented as an Adjacency Matrix
            int[,] adjacencyMatrix = new int[,]
            {
            { 0, 2, 0, 6, 0 },
            { 2, 0, 3, 8, 5 },
            { 0, 3, 0, 0, 7 },
            { 6, 8, 0, 0, 9 },
            { 0, 5, 7, 9, 0 }
            };

            int verticesCount = 5;

            PrimsSolver solver = new PrimsSolver();
            solver.FindMST(adjacencyMatrix, verticesCount);
        }
    }
}
