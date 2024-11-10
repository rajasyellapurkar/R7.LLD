namespace R7.DSA.Arrays
{
    public static class RotateArrayByKSteps
    {
        public static int[] RotateArray(int[] arr, int k)
        {
            k = k % arr.Length;
            Reverse(arr, 0 , arr.Length-1);
            Reverse(arr, 0, k - 1);
            Reverse(arr, k, arr.Length-1);
            return arr;
        }

        private static void Reverse(int[] arr, int start, int end)
        {
            while(start < end)
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
