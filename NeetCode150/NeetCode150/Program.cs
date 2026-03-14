using NeetCode150.ArraysAndHashing;


#region Contains Duplicate
/* Executes the ContainsDuplicate code
 
int[] nums = { 1, 2, 3, 1 };

bool result = ContainsDuplicate.HasDuplicate(nums);

Console.WriteLine(result);
*/
#endregion

#region Valid Anagram
//string s = "Silent";
//string t = "Listen";

///* Handle space here in this edge case
//s = "Eleven plus two";
//t = "Twelve plus one"; 
//*/

//bool isAnagram = ValidAnagram.IsAnagram(s, t);

//if(isAnagram)
//    Console.WriteLine($"Yes. The two strings {s} and {t} are Anagrams.");
//else
//    Console.WriteLine($"No. The two strings {s} and {t} are not Anagrams.");
#endregion

#region PlusOne
//int[] inputArray = [9, 9, 9, 9];
//int[] output = PlusOne.AddOne(inputArray);
//foreach (var item in output)
//{
//    Console.WriteLine(item);
//}
#endregion

#region HappyNumber
List<int> nums = [100];
nums.ForEach(n =>
{
    bool isHappyNumber = HappyNumber.IsHappyNumber(n);
    Console.WriteLine($"Is {n} a happy number (non-cyclical) - {isHappyNumber}");
});

#endregion