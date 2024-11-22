namespace R7.DSA.BitManipulation
{
    public class NumberOfOneBits
    {
        /// <summary>
        /// Method to return number of 1 bits in an integer
        /// Usage: Console.WriteLine($"{ReturnNumberofOneBits(6)}");
        /// </summary>
        /// <param name="N">Integer value</param>
        /// <returns>Number of 1 bits in an integer</returns>
        public static int ReturnNumberofOneBits(int N)
        {
            int oneBitCount = 0;
            while (N > 0)
            {
                if ((N & 1) == 1)
                {
                    oneBitCount++;
                }
                N = N >> 1;
            }
            return oneBitCount;
        }
    }
}
