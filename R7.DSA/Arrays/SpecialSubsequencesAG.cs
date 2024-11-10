namespace R7.DSA.Arrays
{
    public class SpecialSubsequencesAG
    {
        public static long Count(string str)
        {
            int countOfG = 0;
            int N = str.Length;
            char[] charArr = str.ToCharArray();
            long result = 0;
            long modulo = (long)Math.Pow(10, 9);
            modulo += 7;
            for(int i = N-1; i >= 0; i--)
            {
                if (charArr[i] == 'G')
                {
                    countOfG++;
                }
                else if (charArr[i] == 'A')
                {
                    result += countOfG;
                }
            }
            return result % modulo;
        }
    }
}
