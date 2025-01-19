namespace R7.DSA.BackTracking
{
    internal class PermutationsOfArray
    {
        static int[] result;
        static int[] flag;
        public static void Execute()
        {
            int[] nums = [1, 2, 3, 4];
            result = new int[nums.Length];
            flag = new int[nums.Length];
            generatePermutation(nums, 0);
        }

        private static void generatePermutation(int[] nums, int index)
        {
            if(index == nums.Length)
            {
                for(int i=0; i< nums.Length; i++)
                {
                    Console.Write($" {result[i]} ");
                }
                Console.WriteLine();
                return;
            }
            for(int i=0; i<nums.Length; i++)
            {
                if (flag[i] == 0)
                {
                    result[index] = nums[i];
                    flag[i] = 1;
                    generatePermutation(nums, index + 1);
                    flag[i] = 0;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
