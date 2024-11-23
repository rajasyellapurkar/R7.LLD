namespace R7.DSA.BasicMaths
{
    /* 
       Given an array A of size N. Rearrange the given array so that A[i] becomes A[A[i]] with O(1) extra space.
       Constraints:    
       1 <= N <= 5×10^4       
       0 <= A[i] <= N - 1       
       The elements of A are distinct        
       Input Format       
       The argument A is an array of integers       
       Example 1:       
       Input : [1, 0]Return : [0, 1]

       Example 2:       
       Input : [3, 2, 0, 1]
       Return : [1, 0, 3, 2]
    */
    internal class ReArrangeArray
    {
        public static int[] Rearrange(int[] arr)
        {
            int n = arr.Length;
            int MULTIPLIER = 4;
            for(int i = 0; i < n; i++)
            {
                arr[i] = MULTIPLIER * arr[i];
            }
            for(int i=0; i< n; i++)
            {
                int valueAtIndex = arr[arr[i] / MULTIPLIER];
                arr[i] = arr[i] + (valueAtIndex/MULTIPLIER);
            }
            for(int i=0; i < n; i++)
            {
                arr[i] = arr[i] % n;
            }
            return arr;
        }
    }
}
