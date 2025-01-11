namespace R7.DSA.Searching
{
    internal class PeakElement
    {
        public static void Execute()
        {
            int[] arr = [1, 2, 3, 4, 5];
            Console.WriteLine($"{Find(arr)}");

            int[] arr2 = [5,6]; // [5, 17, 100, 11];
            Console.WriteLine($"{Find(arr2)}");
        }

        public static int Find(int[] arr)
        {
            int length = arr.Length;
            int low = 0;
            int high = length - 1;
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[low] > arr[low + 1])
                {
                    return arr[low];
                }
                else if (arr[high] > arr[high - 1])
                {
                    return arr[high];
                }
                else if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                {
                    return arr[mid];
                }
                else if (arr[mid - 1] > arr[mid])
                {
                    // search in left side
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
