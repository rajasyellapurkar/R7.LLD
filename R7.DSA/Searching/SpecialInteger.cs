namespace R7.DSA.Searching
{
    internal class SpecialInteger
    {
        public static void Execute()
        {
            int[] arr = [1, 2, 3, 4, 5];
            int b = 10;
            int result = Find(arr, b);
            result = Find([5, 17, 100, 11], 130);
        }

        private static int Find(int[] arr, int b)
        {
            int l = 0;
            int h = arr.Length;
            int result = -1;

            while (l <= h)
            {
                int mid = (l + h) / 2;
                
                if(CheckSumOfAllSubArrays(arr, mid, b))
                {
                    result = mid;
                    l = mid + 1;
                }
                else
                {
                    h = mid - 1;
                }
            }
            return result;
        }

        private static bool CheckSumOfAllSubArrays(int[] nums, int k, int b)
        {
            int sum = 0;
            for(int i=0; i<k; i++)
            {
                sum += nums[i];
            }
            if(sum > b)
            {
                return false;
            }

            for(int i = k; i < nums.Length; i++)
            {
                sum = sum - nums[i-k] + nums[i];
                if(sum > b)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
