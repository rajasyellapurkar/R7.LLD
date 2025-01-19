namespace R7.DSA.Searching
{
    /* https://leetcode.com/problems/find-occurrences-of-an-element-in-an-array/ */
    class OccurrencesOfElement
    {
        public static void Execute()
        {
            int[] nums = [1, 3, 1, 7];
            int[] queries = [1, 3, 2, 4];
            int x = 1;

            OccurrencesOfElement obj = new OccurrencesOfElement();
            obj.occurrencesOfElement(nums, queries, 1);
        }
        public int[] occurrencesOfElement(int[] nums, int[] queries, int x)
        {
            int[] freqArr = new int[nums.Length];
            int[] output = new int[queries.Length];
            if (nums[0] == x)
            {
                freqArr[0] = 1;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == x)
                {
                    freqArr[i] = freqArr[i - 1] + 1;
                }
                else
                {
                    freqArr[i] = freqArr[i - 1];
                }
            }

            for (int i = 0; i < queries.Length; i++)
            {
                output[i] = binarySearch(freqArr, queries[i]);
            }

            return output;
        }

        private int binarySearch(int[] freqArr, int target)
        {
            int low = 0;
            int high = freqArr.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (freqArr[mid] == target)
                {
                    result = mid;
                }
                if (target <= freqArr[mid])
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
