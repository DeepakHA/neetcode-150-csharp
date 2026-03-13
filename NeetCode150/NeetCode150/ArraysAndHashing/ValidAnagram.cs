
namespace NeetCode150.ArraysAndHashing
{
    internal class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            s = s.ToLower();
            t = t.ToLower();

            if (s.Length != t.Length)
            {
                return false;
            }

            int[] charCount = new int[26]; // [0, 0 , 0, ..., 0] (length 26)

            for (int i = 0; i < s.Length; i++) // O(n)
            {
                charCount[s[i] - 'a']++; // Increment the count for the character in string s
                charCount[t[i] - 'a']--; // Decrement the count for the character in string t
            }

            foreach (int count in charCount) // O(26) => O(1) (constant time)
            {
                if (count != 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
