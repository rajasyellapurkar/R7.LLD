namespace R7.DSA.Sorting1
{
    internal class ShortestUnsortedContinousSubArray
    {
        //https://leetcode.com/problems/shortest-unsorted-continuous-subarray/
        public int FindUnsortedSubarray(int[] nums)
        {
            int n = nums.Length;
            int[] sortedArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                sortedArr[i] = nums[i];
            }
            Array.Sort(sortedArr);
            int p1 = 0;
            int p2 = n - 1;
            while (p1 < n)
            {
                if (sortedArr[p1] == nums[p1])
                {
                    p1++;
                }
                else
                {
                    break;
                }
            }
            if (p1 == n)
            {
                return 0;
            }
            else
            {
                while (p2 >= 0)
                {
                    if (sortedArr[p2] == nums[p2])
                    {
                        p2--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return p2 - p1 + 1;
        }
    }
}
