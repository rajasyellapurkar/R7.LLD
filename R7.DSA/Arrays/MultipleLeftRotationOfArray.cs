namespace R7.DSA.Arrays
{
    public class MultipleLeftRotationOfArray
    {
        public static int[][] MultipleLeftRotatedArray(int[] a, int[] b)
        {
            int M = a.Length;
            int N = b.Length;
            int[][] result = new int[N][];
            for(int i =0; i < N; i++)
            {
                result[i] = new int[M];
                result[i] = LeftRotatedArray(a, b[i]);
            }
            return result;
        }
        private static int[] LeftRotatedArray(int[] arr, int k)
        {
            int N = arr.Length;
            int[] newArr = (int[])arr.Clone();
            Reverse(newArr, 0, N - 1);
            Reverse(newArr, 0, N - k - 1);
            Reverse(newArr, N - k, N - 1);
            return newArr;
        }
        private static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
