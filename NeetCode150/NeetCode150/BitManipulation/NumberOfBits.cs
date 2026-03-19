namespace NeetCode150.BitManipulation
{
    internal class NumberOfBits
    {
        public static int HammingWeight(uint n) {
            int count = 0;
            while (n > 0)
            {
                if (n % 2 != 0)
                {
                    count++;
                }
                n /= 2;
            }
            return count;

            // Need to improve this. This has time complexity of O(logn)
        }    
    }
}
