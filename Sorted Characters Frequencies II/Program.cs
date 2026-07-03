namespace Sorted_Characters_Frequencies_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharFreq processor = new CharFreq();
            string testInput = "hello world";

            // Execution path 1: ASCII array process
            processor.ASCIIMethod(testInput);

            Console.WriteLine("\n-----------------------------\n");

            // Execution path 2: Dynamic HashTable & custom Merge Sort process
            processor.AnyCodeMethod(testInput);
        }
    }
}
