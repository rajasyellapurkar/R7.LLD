namespace R7.DSA.BitManipulation
{
    public class SingleNumber2
    {
        public static int FindNumber(int[] arr)
        {
            int n = arr.Length;
            int INT_SIZE = 32;
            int shiftedOne, result = 0;
            for(int i = 0; i < INT_SIZE; i++)
            {
                shiftedOne = 1 << i;
                int numberOfOnes = 0;
                for(int j=0; j < n; j++)
                {
                    if ((arr[j]  & shiftedOne) == shiftedOne)
                    {
                        numberOfOnes++;
                    }
                }
                if(numberOfOnes % 3 == 1)
                {
                    result |= shiftedOne;
                }
            }
            return result;
        }
    }
}
