namespace Sorted_Characters_Frequencies_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the utility class
            CharFreq cf = new CharFreq();
            string msg = "hello world";

            // Execute the ASCII frequency analysis
            cf.ASCIIMethod(msg);
        }
    }
}
