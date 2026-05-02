namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 5, 1, 4 };
            Console.WriteLine(string.Join(", ", array));

            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(", ", array));
        }
        // method : mergeSort
        // input : array , start , end
        public static void MergeSort(int[] array, int start, int end)
        {
            // exit if : end >= start
            if (start >= end)
            {
                return;
            }
            // calculate midpoint
            int midpoint = start + (end - start) / 2; // to get the index

            // call yourself twice

            // mergesort( array , midpoint , start )
            MergeSort(array, start, midpoint);

            // mergesort( midpoint + 1 , end )
            MergeSort(array, midpoint + 1, end);

            // merge(array , start , midpoint , end )
            Merge(array, start, midpoint, end);
        }

        // method : merge
        // inputs : array , start , midpoint , end
        static public void Merge(int[] array, int start, int midPoint, int end)
        {
            int i, j, k; // k for the original array
            i = 0; // index for LeftArray
            j = 0; // index for RightArray
            k = start; // index for original array

            // create two arrays
            int LeftLength = midPoint - start + 1; // why  + 1
            int RightLength = end - midPoint;

            int[] LeftArray = new int[LeftLength]; // i
            int[] RightArray = new int[RightLength]; // j

            // Fill the temporary arrays
            for (i = 0; i < LeftLength; i++)
            {
                LeftArray[i] = array[start + i];
            }

            for (j = 0; j < RightLength; j++)
            {
                RightArray[j] = array[midPoint + 1 + j];
            }

            // Reset indices again for the comparison phase
            i = 0;
            j = 0;

            // compare and sort
            while (i < LeftLength && j < RightLength)
            {
                {
                    if (LeftArray[i] <= RightArray[j])
                    {
                        array[k] = LeftArray[i];
                        i++;
                    }
                    else
                    {
                        array[k] = RightArray[j];
                        j++;
                    }
                    k++;
                }
            }

            // Move remaining items from Left
            while (i < LeftLength)
            {
                array[k] = LeftArray[i];
                i++;
                k++;
            }

            //  Move remaining items from Right (You missed this loop!)
            while (j < RightLength)
            {
                array[k] = RightArray[j];
                j++;
                k++;
            }
        }
    }
}
