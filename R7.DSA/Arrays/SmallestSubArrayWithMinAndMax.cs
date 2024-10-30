namespace R7.DSA.Arrays
{
    public class SmallestSubArrayWithMinAndMax
    {
        public static int SmallestSubArrayLength(int[] a)
        {
            int l = int.MaxValue;
            int r = int.MinValue;
            int i = 0;
            int min = a.Min();
            int max = a.Max();
            int N = a.Length;
            while (i < N)
            {
                if (a[i] == min)
                {
                    l = i;
                    while (i < N)
                    {
                        if (a[i] == min)
                        {
                            l = i;
                        }
                        if (a[i] == max)
                        {
                            r = i;
                            i = N;
                        }
                        i++;
                    }
                }
                i++;
            }
            int diff1 = r - l;
            i = 0;
            while (i < N)
            {
                if (a[i] == max)
                {
                    l = i;
                    while (i < N)
                    {
                        if (a[i] == max)
                        {
                            l = i;
                        }
                        if (a[i] == min)
                        {
                            r = i;
                            i = N;
                        }
                        i++;
                    }
                }
                i++;
            }
            int diff2 = r - l;
            return Math.Min(diff1, diff2);
        }

        public static int SmallestSubArrayLengthSimplified(int[] a)
        {
            int n = a.Length;
            // find maximum and minimum
            // values in the array
            int minValue = a.Min();
            int maxValue = a.Max();

            int pos_min = -1, pos_max = -1, ans = int.MaxValue;

            // iterate over the array and set answer
            // to smallest difference between position
            // of maximum and position of minimum value
            for (int i = 0; i < n; i++)
            {

                // last occurrence of minValue
                if (a[i] == minValue)
                    pos_min = i;

                // last occurrence of maxValue
                if (a[i] == maxValue)
                    pos_max = i;

                if (pos_max != -1 && pos_min != -1)
                    ans = Math.Min(ans, Math.Abs(pos_min - pos_max) + 1);
            }

            return ans;
        }
    }
}
