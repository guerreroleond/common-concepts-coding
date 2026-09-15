using System.Diagnostics.CodeAnalysis;

namespace CommonConceptsCoding.Console;

/// <summary>
/// 02TwoPointers-04ContainerWithMostWater [Medium]
/// Given n non-negative integers representing the heights of vertical lines,
/// find the maximum area of water a container can store.
/// </summary>
public class ContainerWithMostWater
{
    /// <summary>
    /// 02TwoPointers-04ContainerWithMostWater [Medium]
    /// Finds the maximum amount of water that can be trapped between two lines.
    /// </summary>
    /// <param name="heights">The heights of the vertical lines.</param>
    /// <returns>The maximum container area.</returns>
    public static int Solve(int[] heights)
    {
        // Can't have a container with null heights or at least two.
        ArgumentNullException.ThrowIfNull(heights);
        ArgumentOutOfRangeException.ThrowIfLessThan(heights.Length, 2);

        var left = 0;
        var right = heights.Length - 1;

        var maxWater = 0;

        while (left < right)
        {
            // Calculate current water/area.
            var water = (right - left) * Math.Min(heights[left], heights[right]);

            maxWater = Math.Max(maxWater, water);

            // Move smaller pointer.
            if (heights[left] < heights[right]) left++;
            else right--;
        }

        return maxWater;
    }
}
