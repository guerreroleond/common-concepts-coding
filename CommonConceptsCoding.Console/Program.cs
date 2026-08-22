// See https://aka.ms/new-console-template for more information
using CommonConceptsCoding.Console;

Console.WriteLine("Common Concepts for Coding");

#region 01Arrays&Hashing-01ContainsDuplicate

//int[] numsWithDuplicate = [1, 2, 3, 1];
//int[] numsWithoutDuplicate = [1, 2, 3, 4];

//Console.WriteLine("Contains Duplicates?");
//Console.WriteLine($"[1,2,3,1] -> {ContainsDuplicate.Solve(numsWithDuplicate)}");
//Console.WriteLine($"[1,2,3,4] -> {ContainsDuplicate.Solve(numsWithoutDuplicate)}");

#endregion 01Arrays&Hashing-01ContainsDuplicate

#region 01Arrays&Hashing-02ValidAnagram

//var validAnagram = new ValidAnagram();

//Console.WriteLine("Valid Anagram?");
//Console.WriteLine($"anagram, nagaram -> {ValidAnagram.Solve("anagram", "nagaram")}");
//Console.WriteLine($"rat, car -> {ValidAnagram.Solve("rat", "car")}");

#endregion 01Arrays&Hashing-02ValidAnagram

#region 01Arrays&Hashing-03TwoSum

Console.WriteLine("Two Sum?");
Console.WriteLine($"[2,7,11,15], 9 -> [{string.Join(", ", TwoSum.Solve([2, 7, 11, 15], 9))}]");
Console.WriteLine($"[3,2,4], 6 -> [{string.Join(", ", TwoSum.Solve([3, 2, 4], 6))}]");

#endregion 01Arrays&Hashing-03TwoSum
