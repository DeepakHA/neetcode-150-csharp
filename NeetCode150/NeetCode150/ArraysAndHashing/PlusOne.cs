namespace NeetCode150.ArraysAndHashing
{
    // Neetcode - Easy - https://neetcode.io/problems/plus-one/question
    internal class PlusOne
    {
        public static int[] AddOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            // Handles edge case where all the digits are 9
            int[] newArray = new int[digits.Length + 1];
            newArray[0] = 1;
            return newArray;
        }
    }
}

/*
 Time complexity - O(n)
 Space complexity = O(n+1) ~ O(n)
 */
