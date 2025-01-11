namespace R7.DSA.Searching
{
    internal class AggressiveCows
    {
        /* https://www.geeksforgeeks.org/problems/aggressive-cows/0 */
        public static int AggressiveCowsFind(int[] stalls, int k)
        {
            Array.Sort(stalls);
            int difference = stalls[stalls.Length - 1] - stalls[0];
            int edges = k - 1;
            int high = difference / edges;
            int low = 0;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (Check(stalls, mid, k))
                {
                    low = mid + 1;
                    result = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return result;
        }

        private static bool Check(int[] stalls, int dist, int k)
        {
            int numberOfPlacedCows = 1;
            int lastCowPlacedPos = 0;
            for (int i = 1; i < stalls.Length; i++)
            {
                if ((stalls[i] - stalls[lastCowPlacedPos]) >= dist)
                {
                    numberOfPlacedCows++;
                    lastCowPlacedPos = i;
                }
            }
            return numberOfPlacedCows >= k;
        }
    }
}
