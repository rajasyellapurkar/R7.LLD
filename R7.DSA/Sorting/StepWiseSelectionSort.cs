namespace R7.DSA.Sorting
{
    public class StepWiseSelectionSort
    {
        public static int[] Sort(int[] arr)
        {
            int N = arr.Length;
            int i = 0;
            int[] result = new int[N - 1];
            while (i < N)
            {
                int minIndex = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

                if(i < N - 1)
                {
                    result[i] = minIndex;
                }

                i++;
            }
            return result;
        }
    }
}
