namespace CommonConceptsCoding.Console;

/// <summary>
/// 02TwoPointers-0TwoSumII [Medium]
/// Find two numbers in a sorted array that add up to the target value.
/// </summary>
public class TwoSumII
{
    /// <summary>
    /// 02TwoPointers-02TwoSumII [Medium]
    /// Uses a two-pointer approach on the sorted input array to find the pair whose sum equals the target.
    /// </summary>
    /// <param name="numbers">Sorted list of integers.</param>
    /// <param name="target">Target sum to match.</param>
    /// <returns>The 1-based indices of the two numbers that add up to the target.</returns>
    /// <exception cref="InvalidOperationException">Thrown when no valid pair is found.</exception>
    public static int[] Solve(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                return [left + 1, right + 1];
            }
            else if (sum < target)
                left++;
            else
                right--;
        }

        throw new InvalidOperationException("No solution found.");
    }

    /// <summary>
    /// 02TwoPointers-02TwoSumII [Medium]
    /// </summary>
    /// <param name="numbers">Sorted input integer array.</param>
    /// <param name="target">Target sum to find.</param>
    /// <returns>Indices of the two numbers that add up to the target.</returns>
    public static int[] SolveStupid(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        var edgeL = left;
        var edgeR = right;
        var direction = false;

        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                return [left + 1, right + 1];
            }
            else if (right - left > 1)
            {
                if (direction)
                    left++;
                else
                    right--;
            }
            else if (right - left == 1)
            {
                if (direction)
                {// Right dir, reset L, and move edgeR 1 position.
                    left = edgeL;
                    edgeR--;
                    right = edgeR;
                }
                else
                {// Left dir, reset R and move edgeL 1 position.
                    right = edgeR;
                    edgeL++;
                    left = edgeL;
                }
                direction = !direction;
            }
        }

        return [];
    }
}
