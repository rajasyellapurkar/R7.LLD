namespace R7.DSA.Sorting1
{
    internal class MergeSortedArray
    {
        // https://leetcode.com/problems/merge-sorted-array/description/
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = 0;
            int p2 = 0;
            int i = 0;
            int[] result = new int[m + n];
            while (p1 < m && p2 < n)
            {
                if (nums2[p2] < nums1[p1])
                {
                    result[i] = nums2[p2];
                    p2++;
                    i++;
                }
                else
                {
                    result[i] = nums1[p1];
                    p1++;
                    i++;
                }
            }
            while (p2 < n)
            {
                result[i] = nums2[p2];
                p2++;
                i++;
            }
            while (p1 < m)
            {
                result[i] = nums1[p1];
                p1++;
                i++;
            }
            for (int j = 0; j < (m + n); j++)
            {
                nums1[j] = result[j];
            }
        }
    }
}
