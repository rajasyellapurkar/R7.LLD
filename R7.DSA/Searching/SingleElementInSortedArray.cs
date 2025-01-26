namespace R7.DSA.Searching
{
    //https://leetcode.com/problems/single-element-in-a-sorted-array/
    internal class SingleElementInSortedArray
    {
        public static void Execute()
        {
            int[] nums = [1, 1, 2, 2, 3];
            Console.WriteLine($"{Find(nums)}");
        }

        private static int Find(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (mid == 0 || mid == nums.Length - 1 || (nums[mid] != nums[mid + 1] &&
                                nums[mid] != nums[mid - 1]))
                {
                    return nums[mid];
                }
                else if (mid % 2 == 0)
                {
                    if (nums[mid] == nums[mid + 1])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                else
                {
                    if (nums[mid] == nums[mid - 1])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
