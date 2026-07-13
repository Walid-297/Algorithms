namespace Dynamic_Programming___Stagecoach_Problem
{
    internal class Program
    {
        private const int INF = 999999;
        public static void Main(string[] args)
        {
            int[,] travelNetwork = new int[,]
            {
            { INF,  2,    4,   INF, INF },
            { INF, INF,  INF,   7,    3  },
            { INF, INF,  INF,   4,    6  },
            { INF, INF,  INF,  INF,   2  },
            { INF, INF,  INF,  INF,  INF }
            };

            int totalNodes = 5;

            StageCoachSolver solver = new StageCoachSolver();
            solver.Solve(travelNetwork, totalNodes);
        }
    }
}

