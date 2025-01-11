namespace R7.DSA.Searching
{
    internal static class BinarySearch
    {
        public static void Execute()
        {
            int[] arr = [1, 1, 2, 2, 2, 2, 3];
            int target = 4;
            Console.WriteLine($"{OccuranceCount(arr, target)}");
        }

        public static int Search(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        public static int OccuranceCount(int[] arr, int target)
        {
            int leftMostOccuranceOfTarget = LeftMostOccurance(arr, target);
            int rightMostOccuranceOfTarget = RightMostOccurance(arr, target);
            if(leftMostOccuranceOfTarget < 0)
            {
                return 0;
            }
            else
            {
                return rightMostOccuranceOfTarget - leftMostOccuranceOfTarget + 1;
            }
        }

        private static int LeftMostOccurance(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == target)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (arr[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return result;
        }
        private static int RightMostOccurance(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == target)
                {
                    result = mid;
                    low = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return result;
        }

    }
}
