namespace R7.DSA.String_Manipulation
{
    public class ReverseCharArrayWithSpaces
    {
        /// <summary>
        /// Swaps the words of the sentence
        /// </summary>
        /// <param name="cArr"></param>
        /// <returns>If cArr is = "I am going to Delhi"
        /// returns "Delhi to going am I"
        /// </returns>
        public static char[] Reverse(char[] cArr)
        {
            int N = cArr.Length;
            ReverseCharArray(cArr, 0, N - 1);
            int l = 0;
            int r;
            int i = 0;
            while(i < N)
            {
                if (cArr[i] == ' ')
                {
                    r = i;
                    ReverseCharArray(cArr, l, r - 1);
                    l = r + 1;
                }
                i++;
            }
            ReverseCharArray(cArr, l, N - 1);
            return cArr;
        }

        private static void ReverseCharArray(char[] charArr, int l, int r)
        {
            while (l < r)
            {
                char temp = charArr[l];
                charArr[l] = charArr[r];
                charArr[r] = temp;
                l++;
                r--;
            }
        }
    }
}
