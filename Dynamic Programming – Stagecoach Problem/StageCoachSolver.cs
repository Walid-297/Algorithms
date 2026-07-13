public class StageCoachSolver
{
    private const int INF = 999999;

    public StageCoachSolver() { }

    public void Solve(int[,] graph, int totalNodes)
    {
        int[] minCost = new int[totalNodes];
        int[] nextPath = new int[totalNodes];

        minCost[totalNodes - 1] = 0;

        for (int i = totalNodes - 2; i >= 0; i--)
        {
            minCost[i] = INF;

            for (int j = i + 1; j < totalNodes; j++)
            {
                if (graph[i, j] != INF)
                {
                    int currentRouteCost = graph[i, j] + minCost[j];

                    if (currentRouteCost < minCost[i])
                    {
                        minCost[i] = currentRouteCost;
                        nextPath[i] = j;
                    }
                }
            }
        }

        PrintResult(minCost, nextPath, totalNodes);
    }

    private void PrintResult(int[] minCost, int[] nextPath, int totalNodes)
    {
        Console.WriteLine("Stagecoach DP Processing Complete.");
        Console.WriteLine($"Minimum Path Cost from Start to End = {minCost[0]}");
        Console.WriteLine("---------------------------------------------");

        Console.Write("Optimal Journey Route: Node 0");
        int current = 0;
        while (current < totalNodes - 1)
        {
            current = nextPath[current];
            Console.Write($" -> Node {current}");
        }
        Console.WriteLine();
    }
}
