namespace R7.DSA.ProblemSolving
{
    /*
     * There is a shop whose assistant told you that there are A puzzles in the shop and you want to buy B of them. They might differ in difficulty and size. The first jigsaw puzzle consists of A1 pieces, the second one consists of A2 pieces and so on.
       You decided that the difference between the numbers of pieces in bought puzzles must be as small as possible.Let x be the number of pieces in the largest puzzle that the you buy and y be the number of pieces in the smallest such puzzle. You want to choose such B puzzles that x-y is as minimum as possible. Find the least possible value of x-y.
     */
    internal static class MinimumDifferencePuzzle
    {
        public static int Find(int[] arr, int k)
        {
            int n = arr.Length;
            Array.Sort(arr);
            int minDiff = int.MaxValue;
            for(int i=0; k+i < n; i++)
            {
                int subArrDiff = arr[k + i - 1] - arr[i];
                if(subArrDiff < minDiff)
                {
                    minDiff = subArrDiff;
                }
            }
            return minDiff;
        }
    }
}
