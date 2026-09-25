namespace CommonConceptsCoding.Console;

/// <summary>
/// 02TwoPointers-05TrappingRainWater [Hard]
/// Given elevations represented by an integer array, calculate the total rainwater trapped after raining.
/// </summary>
public class TrappingRainWater
{
    /// <summary>
    /// 02TwoPointers-05TrappingRainWater [Hard]
    /// Calculates the total amount of rainwater trapped between elevation bars.
    /// </summary>
    /// <param name="heights">The elevations of the bars.</param>
    /// <returns>The total amount of trapped rainwater.</returns>
    public static int Solve(int[] heights)
    {
        int left = 0;
        int right = heights.Length - 1;
        int maxLeft = 0;
        int maxRight = 0;
        int water = 0;

        while (left < right)
        {
            // Process smaller side.
            if (heights[left] <= heights[right])
            {// Process left.
                maxLeft = Math.Max(maxLeft, heights[left]);
                water += maxLeft - heights[left];
                left++;
            }
            else
            {// Process right.
                maxRight = Math.Max(maxRight, heights[right]);
                water += maxRight - heights[right];
                right--;
            }
        }

        return water;
    }
}
