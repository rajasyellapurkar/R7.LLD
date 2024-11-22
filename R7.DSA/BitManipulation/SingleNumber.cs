namespace R7.DSA.BitManipulation
{
    public class SingleNumber
    {
        /// <summary>
        /// Given an array of integers A, every element appears twice except for one. Find that integer that occurs once.
        /// NOTE: Your algorithm should have a linear runtime complexity.Could you implement it without using extra memory?
        /// 
        /// Usage: Console.WriteLine($"{SingleNumber.Find([1, 2, 2, 3, 1])}");
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Find(int[] A)
        {
            int result = 0;
            int N = A.Length;
            for (int i = 0; i < N; i++)
            {
                result = result ^ A[i];
            }
            return result;
        }
    }
}
