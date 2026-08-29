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

// Console.WriteLine("Valid Anagram?");
// Console.WriteLine($"anagram, nagaram -> {ValidAnagram.Solve("anagram", "nagaram")}");
// Console.WriteLine($"rat, car -> {ValidAnagram.ConstrainedSolve("rat", "car")}");

#endregion 01Arrays&Hashing-02ValidAnagram

#region 01Arrays&Hashing-03TwoSum

//Console.WriteLine("Two Sum?");
//Console.WriteLine($"[2,7,11,15], 9 -> [{string.Join(", ", TwoSum.Solve([2, 7, 11, 15], 9))}]");
//Console.WriteLine($"[3,2,4], 6 -> [{string.Join(", ", TwoSum.Solve([3, 2, 4], 6))}]");

#endregion 01Arrays&Hashing-03TwoSum

#region 01Arrays&Hashing-04GroupAnagrams

//Console.WriteLine("Group Anagrams?");
//var result1 = GroupAnagrams.ConstrainedSolve(["eat", "tea", "tan", "ate", "nat", "bat"]);
//Console.WriteLine($"[eat,tea,tan,ate,nat,bat] -> [{string.Join(", ", result1.Select(g => $"[{string.Join(",", g)}]"))}]");
//var result2 = GroupAnagrams.ConstrainedSolve(["a"]);
//Console.WriteLine($"[a] -> [{string.Join(", ", result2.Select(g => $"[{string.Join(",", g)}]"))}]");

#endregion 01Arrays&Hashing-04GroupAnagrams

#region 01Arrays&Hashing-05TopKFrequentElements

//Console.WriteLine("Top K Frequent Elements?");
//Console.WriteLine($"[1,1,1,2,2,2,3], k=2 -> [{string.Join(", ", TopKFrequentElements.Solve([1, 1, 1, 2, 2, 2, 3], 2))}]");
//Console.WriteLine($"[1], k=1 -> [{string.Join(", ", TopKFrequentElements.Solve([1], 1))}]");

#endregion 01Arrays&Hashing-05TopKFrequentElements

#region 01Arrays&Hashing-06EncodeAndDecodeStrings [Medium]

List<string> input1 = ["Hello World!", "123#456", "", "a#b#c", "こんにちは" ];

Console.WriteLine("Encode & Decode Strings?");

var encoded1 = EncodeAndDecodeStrings.Encode(input1);
var decoded1 = EncodeAndDecodeStrings.Decode(encoded1);
var decoded1Display = string.Join(", ", decoded1);
Console.WriteLine(
    $"[Hello World!,123#456,,a#b#c,こんにちは]" +
    $" -> \"{encoded1}\"" +
    $" -> [{decoded1Display}]");

#endregion 01Arrays&Hashing-06EncodeAndDecodeStrings [Medium]

Console.ReadKey();
