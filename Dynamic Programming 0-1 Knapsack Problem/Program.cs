namespace Dynamic_Programming_0_1_Knapsack_Problem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int maxCapacity = 50;
            int[] values = { 60, 100, 120 };
            int[] weights = { 10, 20, 30 };
            int itemCount = values.Length;

            Knapsack01Solver solver = new Knapsack01Solver();

            int maxProfit = solver.Solve(maxCapacity, weights, values, itemCount);

            Console.WriteLine("0/1 Knapsack DP Processing Complete.");
            Console.WriteLine($"Maximum profit achievable within weight capacity {maxCapacity} = {maxProfit}");
        }
    }
}
