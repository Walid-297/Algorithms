
namespace Sorted_Characters_Frequencies_I
{
    public class CharFreq
    {
        public CharFreq() { }

        public void ASCIIMethod(string message)
        {
            Console.WriteLine("ASCIIMethod");

            // Create an array of size 127 to hold every standard ASCII character position
            int[] freq = new int[127];

            // Loop 1: Map frequencies directly using the character's ASCII integer value as an index
            for (int i = 0; i < message.Length; i++)
            {
                int current_code = (int)message[i];
                freq[current_code]++; // change the value of index (ASCII of the letter) from 0 to value which indicate the number of times it repeated 
            }

            // Loop 2: Output the non-zero character counts sequentially
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    char c = (char)i;
                    Console.Write(c + " ");
                    Console.WriteLine(freq[i]);
                    // output : letter  number
                }
            }
        }
    }
}
