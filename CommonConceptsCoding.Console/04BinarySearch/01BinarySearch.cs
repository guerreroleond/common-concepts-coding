namespace CommonConceptsCoding.Console;

/// <summary>
/// 04BinarySearch-01BinarySearch [Easy]
/// Searches a sorted array for a target value using binary search.
/// </summary>
public class BinarySearch
{
    /// <summary>
    /// 04BinarySearch-01BinarySearch [Easy]
    /// Finds the index of a target value in a sorted array.
    /// </summary>
    /// <param name="nums">The array of integers sorted in ascending order.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns>The index of the target, or -1 if it is not found.</returns>
    /// <exception cref="NotImplementedException">The operation has not been implemented.</exception>
    public static int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length;

        while (left <= right)
        {
            int middle = left + (right - left) / 2; // avoids overflow.

            if (nums[middle] == target) return middle;
            else if (target < nums[middle])
            {// take first half.
                right = middle - 1;
            }
            else
            {// take second half.
                left = middle + 1;
            }
        }

        return -1;
    }
}
