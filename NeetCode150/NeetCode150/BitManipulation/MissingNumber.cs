namespace NeetCode150.BitManipulation
{
    internal class MissingNumber
    {
        public static int GetMissingNumber(int[] nums)
        {
            int result = 0;

            for (int i = 0; i <= nums.Length; i++) // i = 0, 1, 2, 3 (if nums.Length = 3)
            {
                result ^= i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i]; // nums[i] = 0, 1, 2 (example input). So missing number is 3
            }

            return result;
        }
    }
}
