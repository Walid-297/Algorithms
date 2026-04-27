namespace InsertionSort
{
    public class InsertSort
    {
        public int[] Sort(int[] Numbers) // { 9, 5, 1, 4, 3 }
        {
            if(Numbers == null || Numbers.Length < 2)
            {
                return Numbers;
            }

            for(int i = 1; i < Numbers.Length; i++) // 1
            {
                int Key = Numbers[i]; //[1] = 5
                int j = i - 1; // 0

                while(j >= 0 && Numbers[j] > Key) // j == 0 , 9 > 5
                {
                    Numbers[j+1] = Numbers[j]; // [1] = 9
                    --j; // -1
                }
                // { 9, 9, 1, 4, 3 }
                Numbers[j+1] = Key; // [0] = 5

               // { 5, 9, 1, 4, 3 }
            }
            return Numbers;
        }
    }
}
