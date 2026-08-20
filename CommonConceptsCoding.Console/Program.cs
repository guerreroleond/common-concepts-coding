// See https://aka.ms/new-console-template for more information
using CommonConceptsCoding.Console;

Console.WriteLine("Common Concepts for Coding");

#region 01Arrays&Hashing-01ContainsDuplicate

int[] numsWithDuplicate = [1, 2, 3, 1];
int[] numsWithoutDuplicate = [1, 2, 3, 4];

Console.WriteLine("Contains Duplicates?");
Console.WriteLine($"[1,2,3,1] -> {ContainsDuplicate.Solve(numsWithDuplicate)}");
Console.WriteLine($"[1,2,3,4] -> {ContainsDuplicate.Solve(numsWithoutDuplicate)}");

#endregion 01Arrays&Hashing-01ContainsDuplicate
