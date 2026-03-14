// Neetcode - Easy - https://neetcode.io/problems/non-cyclical-number/question

namespace NeetCode150.ArraysAndHashing
{
    internal class HappyNumber
    {
        public static bool IsHappyNumber(int n)
        {
            int sum = GetSumOfDigitsOfN(n);

            var hashSet = new HashSet<int>();
            while (sum != 1 && !hashSet.Contains(sum))
            {
                hashSet.Add(sum);
                sum = GetSumOfDigitsOfN(sum);
            }
            return sum == 1;
        }

        static int GetSumOfDigitsOfN(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int r = n % 10;
                sum += r * r;
                n /= 10;
            }
            return sum;
        }
    }
}
