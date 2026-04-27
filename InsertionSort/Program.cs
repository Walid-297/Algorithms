namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = { 9, 5, 1, 4, 3 };

            for (int i = 1; i < numbers.Length; i++)
            {
                // 1. Capture the value first!
                // This is the card we are currently holding to insert.
                int key = numbers[i]; // 5 , 1
                int j = i - 1; // 0 , 1

                // 2. Use a loop to shift larger elements to the right.
                while (j >= 0 && numbers[j] > key) // 9 > 5 , 9 > 1
                {
                    numbers[j + 1] = numbers[j]; // [1] = 9 , [2] = 9
                    j--; // Moving backward toward the start of the array
                }

                // 3. Place the key in the correct hole found by the loop.
                numbers[j + 1] = key; // [0] = 5 , [1] = 1
            }

            foreach (var item in numbers)
            {
                Console.Write(item + ",");
            }
            */

            int[] UnsortedNumbers = new int[] { 9, 5, 1, 4, 3 };

            InsertSort insertsort = new InsertSort();

            int[] SortedNumbers = insertsort.Sort(UnsortedNumbers) ;

            Console.WriteLine("Sorted Array");

            foreach(var item in SortedNumbers)
            {
                Console.Write(item + " ");
            }

        }

    }
}
