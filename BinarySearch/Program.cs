namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };

            int result = BinarySearch(numbers, 9);

            Console.WriteLine(result);
        }
        public static int BinarySearch(int[] SortedNumbers, int Target)
        {
            // define the search area
            // low = first index
            // high = last index

            int low = 0;
            int high = SortedNumbers.Length - 1;

            // Keep searching while there is still a valid search area

            while (low <= high)
            {
                // calculate mid
                int mid = low + (high - low) / 2;

                // Check if the middle element is the target

                if (SortedNumbers[mid] == Target)
                {
                    return mid;
                }
                else if (SortedNumbers[mid] > Target) // so the target is in the left half of the array
                {
                    high = mid - 1;
                }
                else if (SortedNumbers[mid] < Target) // so the target is in the right half of the array
                {
                    low = mid + 1;
                }
            }
            // if the loop finished and the item was not found
            return -1;
        }
    }
}
