namespace NeetCode150.BitManipulation
{
    internal class SingleNumber
    {
        public static int NonDuplicateNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
