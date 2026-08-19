namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-01ContainsDuplicate [Easy]
/// Given an integer array nums, return true if any value appears more than once, false otherwise.
/// </summary>
public class ContainsDuplicate
{
    /// <summary>
    /// 01Arrays&amp;Hashing-01ContainsDuplicate [Easy]
    /// </summary>
    /// <param name="nums">Input integer array.</param>
    /// <returns>True if the array contains a duplicate value; otherwise, false.</returns>
    public bool Solve(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);

        HashSet<int> included = [];

        foreach (var num in nums)
            if (!included.Add(num)) return true;

        return false;        
    }
}
