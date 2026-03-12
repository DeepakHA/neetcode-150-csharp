namespace NeetCode150.ArraysAndHashing;

public class ContainsDuplicate
{
    public static bool HasDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (set.Contains(num))
                return true;

            set.Add(num);
        }

        return false;
    }
}