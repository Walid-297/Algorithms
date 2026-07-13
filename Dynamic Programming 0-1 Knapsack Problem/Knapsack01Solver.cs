public class Knapsack01Solver
{
    public Knapsack01Solver() { }

    public int Solve(int maxCapacity, int[] weights, int[] values, int itemCount)
    {
        // dp[i, w] stores the maximum value achieved using first i items with capacity w
        int[,] dp = new int[itemCount + 1, maxCapacity + 1];

        // Build the tabulation grid row by row, column by column
        for (int i = 1; i <= itemCount; i++)
        {
            int currentWeight = weights[i - 1];
            int currentValue = values[i - 1];

            for (int w = 0; w <= maxCapacity; w++)
            {
                if (currentWeight > w)
                {
                    // Item cannot fit; inherit value from the row above
                    dp[i, w] = dp[i - 1, w];
                }
                else
                {
                    // Find max between excluding the item and including it
                    int excludeItem = dp[i - 1, w];
                    int includeItem = currentValue + dp[i - 1, w - currentWeight];

                    dp[i, w] = Math.Max(excludeItem, includeItem);
                }
            }
        }

        // The bottom-right cell contains the maximum profit for the full constraints
        return dp[itemCount, maxCapacity];
    }
}