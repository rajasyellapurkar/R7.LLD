namespace R7.DSA.String_Manipulation
{
    public class IsPalindromeWithSwap
    {
        /// <summary>
        /// MALAYALAM
        /// 
        /// AMLAYALAM - output is true
        /// YMLAAALMA - output is true
        /// 
        /// ALMAYALAM - output is false
        /// </summary>
        /// <param name="cArr"></param>
        /// <returns></returns>
        public static bool Check(char[] cArr)
        {
            int N = cArr.Length;
            int l = 0;
            int r = N - 1;
            int indexOfCharToBeSwapped = -1;
            char charToBeLookedFor = cArr[0];
            while (l <= r)
            {
                if (cArr[l] != cArr[r] && indexOfCharToBeSwapped < 0)
                {
                    indexOfCharToBeSwapped = l;
                    charToBeLookedFor = cArr[r];
                }
                else if(indexOfCharToBeSwapped >= 0 && cArr[l] != cArr[r] && cArr[l] == charToBeLookedFor)
                {
                    char temp = cArr[l];
                    cArr[l] = cArr[indexOfCharToBeSwapped];
                    cArr[indexOfCharToBeSwapped] = temp;
                    break;
                }
                else if (indexOfCharToBeSwapped >= 0 && l == r && cArr[l] == charToBeLookedFor)
                {
                    char temp = cArr[l];
                    cArr[l] = cArr[indexOfCharToBeSwapped];
                    cArr[indexOfCharToBeSwapped] = temp;
                    break;
                }
                l++;
                r--;
            }

            l = 0;
            r = N - 1;

            while (l < r)
            {
                if (cArr[l] != cArr[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
    }
}
