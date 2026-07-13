namespace Dynamic_Programming___Longest_Common_Subsequence__LCS_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Define baseline test comparison strings
            string sequence1 = "AGGTAB";
            string sequence2 = "GXTXAYB";

            LCSSolver solver = new LCSSolver();

            // Execute dynamic programming grid evaluation passes
            int lcsLength = solver.ComputeLCS(sequence1, sequence2);

            Console.WriteLine("Longest Common Subsequence Processing Complete.");
            Console.WriteLine($"Length of LCS between '{sequence1}' and '{sequence2}' = {lcsLength}");
        }
    }
}
