public class LCSSolver
{
    public LCSSolver() { }

    // Computes the maximum length of the common subsequence
    public int ComputeLCS(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;

        // Establish the tabulation matrix grid with boundary padding
        int[,] dp = new int[m + 1, n + 1];

        // Iteratively fill out the state table matrix
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                // If characters match, take the diagonal value and add 1
                if (s1[i - 1] == s2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                // If characters mismatch, inherit the maximum from top or left
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        // Optional: Call a helper method here if backtracking the actual string sequence is needed
        return dp[m, n];
    }
}