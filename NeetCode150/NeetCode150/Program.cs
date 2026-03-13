using NeetCode150.ArraysAndHashing;


#region 001 Contains Duplicate
/* Executes the ContainsDuplicate code
 
int[] nums = { 1, 2, 3, 1 };

bool result = ContainsDuplicate.HasDuplicate(nums);

Console.WriteLine(result);
*/
#endregion


string s = "Silent";
string t = "Listen";

/* Handle space here in this edge case
s = "Eleven plus two";
t = "Twelve plus one"; 
*/

bool isAnagram = ValidAnagram.IsAnagram(s, t);

if(isAnagram)
    Console.WriteLine($"Yes.The two strings {s} and {t} are Anagrams.");
else
    Console.WriteLine($"No.The two strings {s} and {t} are not Anagrams.");