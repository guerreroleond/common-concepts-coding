namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-03TwoSum [Easy]
/// Given an array of integers nums and an integer target, return the indices of the two numbers that add up to target.
/// </summary>
public class TwoSum
{
    /// <summary>
    /// 01Arrays&amp;Hashing-03TwoSum [Easy]
    /// </summary>
    /// <param name="nums">Input integer array.</param>
    /// <param name="target">Target sum to find.</param>
    /// <returns>Indices of the two numbers that add up to target.</returns>
    public static int[] Solve(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);

        Dictionary<int, int> seen = [];

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (seen.TryGetValue(diff, out int index))
            {
                return [i, index];
            }

            seen[nums[i]] = i;
        }

        return [];
    }
}
