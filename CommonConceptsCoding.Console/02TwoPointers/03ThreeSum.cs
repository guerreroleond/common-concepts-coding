namespace CommonConceptsCoding.Console;

/// <summary>
/// 02TwoPointers-03ThreeSum [Medium]
/// Find all unique triplets in an integer array that sum to zero.
/// </summary>
public class ThreeSum
{
    /// <summary>
    /// 02TwoPointers-03ThreeSum [Medium]
    /// Finds all unique triplets that sum to zero using sorting and two pointers.
    /// </summary>
    /// <param name="nums">Input integer array.</param>
    /// <returns>All unique triplets whose values sum to zero.</returns>
    public static IList<IList<int>> Solve(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);

        var result = new List<IList<int>>();

        // Need at least 3 nums to have a triplet.
        if (nums.Length < 3) return result;

        // Sort the nums so we can validate with two pointers.
		Array.Sort(nums);

        // Iterate through nums fixly, leaving a room for two pointers.
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // No triplet starting with a positive number can sum to zero.
            if (nums[i] > 0) break;

            // Skip duplicate values for the first position.
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum < 0) left++;
                else if (sum > 0) right--;
                else
                {
                    // Triplet found.
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    right--;

                    // Skip duplicate values for the second position.
                    while (left < right
                    && nums[left] == nums[left - 1])
                        left++;
                    // Skip duplicate values for the third position.
                    while (left < right
                    && nums[right] == nums[right + 1])
                        right--;
                }
            }
        }

        return result;
    } 

    /// <summary>
    /// 02TwoPointers-03ThreeSum [Medium]
    /// </summary>
    /// <param name="nums">Input integer array.</param>
    /// <returns>All unique triplets whose values sum to zero.</returns>
    public static IList<IList<int>> SolveBug(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        Array.Sort(nums);
        var triplets = new List<List<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {// Add this triplet.
                    // Validate if triplet not duplicate.
                    triplets.Add([nums[i], nums[left], nums[right]]);
                    // Move both pointers.
                    left++;
                    right--;
                }
                else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }

        return (IList<IList<int>>)triplets;
    }
}
