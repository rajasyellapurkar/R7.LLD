namespace R7.DSA.Arrays
{
    public static class OddEvenSubSequence
    {
        public static int MaxPossibleLength(int[] A)
        {
            int N = A.Length;
            int firstElement = A[0];
            bool shouldBeOdd;
            int maxPossibleLength = 1;
            if(firstElement % 2 == 0)
            {
                shouldBeOdd = true;
            }
            else
            {
                shouldBeOdd = false;
            }
            for(int i = 1; i < N; i++)
            {
                if(shouldBeOdd && A[i] % 2 != 0)
                {
                    maxPossibleLength++;
                    shouldBeOdd = !shouldBeOdd;
                }
                else if(!shouldBeOdd && A[i] % 2 == 0)
                {
                    maxPossibleLength++;
                    shouldBeOdd = !shouldBeOdd;
                }
            }
            return maxPossibleLength;
        }
    }
}
