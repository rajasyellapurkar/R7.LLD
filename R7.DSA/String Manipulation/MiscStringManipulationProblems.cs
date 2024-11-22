namespace R7.DSA.String_Manipulation
{
    internal class MiscStringManipulationProblems
    {
        public static bool IsAlpha(char[] c)
        {
            int n = c.Length;
            for(int i = 0; i< n; i++)
            {
                if (!((c[i] >= 'a' && c[i] <= 'z')
                    || (c[i] >= 'A' && c[i] <= 'Z')
                    || (c[i] >='0' && c[i] <= '9')))
                {
                    return false;
                }
            }
            return true;
        }

        public static char[] RotateStringByK(char[] c, int k)
        {
            int l = 0;
            int r = c.Length - 1;

            c = Reverse(c, l, r);
            c = Reverse(c, l, k-1);
            c = Reverse(c, k, r);

            return c;
        }

        public static char[] ToLower(char[] c)
        {
            int n = c.Length;
            int diff = 'a' - 'A';
            for(int i = 0; i < n; i++)
            {
                if (c[i] >= 'A' && c[i] <= 'Z')
                {
                    int lowerCharInt = c[i] + diff;
                    c[i] = (char)lowerCharInt;
                }
            }
            return c;
        }

        public static char[] ToUpper(char[] c)
        {
            int n = c.Length;
            int diff = 'a' - 'A';
            for (int i = 0; i < n; i++)
            {
                if (c[i] >= 'a' && c[i] <= 'z')
                {
                    int lowerCharInt = c[i] - diff;
                    c[i] = (char)lowerCharInt;
                }
            }
            return c;
        }

        private static char[] Reverse(char[] charArr, int l, int r)
        {
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
