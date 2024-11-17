namespace R7.DSA.String_Manipulation
{
    public class IsCharArrayPalindrome
    {
        public static bool IsPalindrome(char[] cArr)
        {
            int l = 0;
            int r = cArr.Length - 1;

            while(l < r)
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
