namespace R7.DSA.Arrays
{
    public class PrintElementsAtLeastTwoGreaterElements
    {
        public static void Print(int[] arr)
        {
            int N = arr.Length;
            int max = arr[0];
            for (int i = 1; i < N; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int secondMax = arr[0];
            for (int i = 1; i < N; i++)
            {
                if (arr[i] < max && arr[i] > secondMax)
                {
                    secondMax = arr[i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                if (arr[i] < secondMax)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}
