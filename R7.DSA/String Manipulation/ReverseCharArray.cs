namespace R7.DSA.String_Manipulation
{
    public class ReverseCharArray
    {
        public static char[] Reverse(char[] charArr)
        {
            int l = 0;
            int r = charArr.Length - 1;

            while (l < r)
            {
                char temp = charArr[l];
                charArr[l] = charArr[r];
                charArr[r] = temp;
                l++;
                r--;
            }
            return charArr;
        }
    }
}
