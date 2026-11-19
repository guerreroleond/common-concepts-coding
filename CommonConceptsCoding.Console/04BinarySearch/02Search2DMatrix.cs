using System.Data;

namespace CommonConceptsCoding.Console;

/// <summary>
/// 04BinarySearch-02Search2DMatrix [Medium]
/// Searches a sorted 2D matrix for a target value.
/// </summary>
public class Search2DMatrix
{
    /// <summary>
    /// 04BinarySearch-02Search2DMatrix [Medium]
    /// Finds a target value in a matrix whose rows are sorted and where each row starts after the previous row ends.
    /// </summary>
    /// <param name="matrix">The matrix of integers sorted in ascending order, row by row.</param>
    /// <param name="target">The value to search for.</param>
    /// <returns><see langword="true"/> if the target is found in the matrix; otherwise, <see langword="false"/>.</returns>
    public static bool Search(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int left = 0;
        int right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int cellValue = matrix[mid / cols][mid % cols];

            if (cellValue == target) return true;
            else if (cellValue > target)
                // Take the smaller half (left).
                right = mid - 1;
            else
                // Take the bigger half (right).
                left = mid + 1;
        }

        return false;
        
    }
}
