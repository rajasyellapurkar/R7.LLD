namespace R7.DSA.BitManipulation
{
    public class ReverseBitsOfUnsignedInteger
    {
        /// <summary>
        /// Reverse the bits of an 32 bit unsigned integer A.
        /// Input: 11
        /// Bit representation: 1011
        /// Output: 1101 (13)
        /// 
        /// Usage: Console.WriteLine($"{ReverseBitsOfUnsignedInteger.ReverseBits(11)}");
        /// </summary>
        /// <param name="N">Integer value</param>
        /// <returns>Returns reversed bits</returns>
        public static int ReverseBits(int N)
        {
            int reverseNumber = 0;
            int numberOfBits = 0;
            int temp = N;
            while (temp > 0)
            {
                numberOfBits++;
                temp = temp >> 1;
            }
            int powerOf2 = 1;
            for (int i = 1; i < numberOfBits; i++)
            {
                powerOf2 *= 2;
            }
            while (N > 0)
            {
                int leftMostBit = N & 1;
                reverseNumber += powerOf2 * leftMostBit;
                powerOf2 /= 2;
                N = N >> 1;
            }
            return reverseNumber;
        }
    }
}
