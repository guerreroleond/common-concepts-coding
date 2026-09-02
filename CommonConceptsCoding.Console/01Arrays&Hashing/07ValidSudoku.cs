namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-07ValidSudoku [Medium]
/// Determine if a 9x9 Sudoku board is valid based on the standard rules.
/// </summary>
public class ValidSudoku
{
    /// <summary>
    /// 01Arrays&amp;Hashing-07ValidSudoku [Medium] - Optimal solution.
    /// Validates rows, columns, and 3x3 boxes in a single traversal,
    /// using bool arrays to track seen numbers and detect duplicates.
    /// </summary>
    /// <param name="board">A 9x9 char array representing the Sudoku board ('1'-'9' or '.').</param>
    /// <returns>True if the board is valid; otherwise, false.</returns>
    public static bool IsValidOptimal(char[][] board)
    {
        // No null validation needed as the constraints guarantee the board is not null.

        // Since the possible values are only '1' though '9', a bool[] works perfectly.
        var rows = new bool[9, 9];
        var cols = new bool[9, 9];
        var boxes = new bool[9, 9];

        for (var row = 0; row < 9; row++)
        {
            for (var col = 0; col < 9; col++)
            {
                var value = board[row][col];
                // If the cell is empty, we don't validate if duplicate.
                if (value == '.') continue;

                var numIndex = value - '1';

                // Calculate which of the 9 boxes this cell belongs to.
                var boxIndex = (row / 3) * 3 + (col / 3);

                if (rows[row, numIndex]
                || cols[col, numIndex]
                || boxes[boxIndex, numIndex])
                    return false;

                rows[row, numIndex] = true;
                cols[col, numIndex] = true;
                boxes[boxIndex, numIndex] = true;
            }
        }

        return true;
    }

    /// <summary>
    /// 01Arrays&amp;Hashing-07ValidSudoku [Medium]
    /// </summary>
    /// <param name="board">A 9x9 char array representing the Sudoku board ('1'-'9' or '.').</param>
    /// <returns>True if the board is valid; otherwise, false.</returns>
    public static bool IsValid(char[][] board)
    {
        ArgumentNullException.ThrowIfNull(board);

        // First we validate complete rows and columns.
        for (var row = 0; row < board.Length; row++)
        {
            var rowHash = new HashSet<char>();
            var colHash = new HashSet<char>();
            for (var col = 0; col < board[row].Length; col++)
            {
                var cellRowValue = board[row][col];
                var cellColValue = board[col][row];
                // Validation is not needed 
                // as the constraint guarantees this input constraint.
                if (cellRowValue >= '1' && cellRowValue <= '9')
                {
                    if (!rowHash.Add(cellRowValue))
                        return false;
                }
                else if (cellRowValue != '.')
                    return false;

                if (cellColValue >= '1' && cellColValue <= '9')
                {
                    if (!colHash.Add(cellColValue))
                        return false;
                }
                else if (cellColValue != '.')
                    return false;                
            }
        }

        // We can iterate rows/cols/boxes at once.
        // Validate 3 x 3 sub-boxes.
        for (var rowBox = 0; rowBox < board.Length; rowBox += 3)
        {
            for (var colBox = 0; colBox < board[rowBox].Length; colBox += 3)
            {
                var boxHash = new HashSet<char>();
                for (var row = rowBox; row < rowBox + 3; row++)
                {
                    for (var col = colBox; col < colBox + 3; col++)
                    {
                        var cellValue = board[row][col];

                        if (cellValue >= '1' && cellValue <= '9')
                        {
                            if (!boxHash.Add(cellValue))
                                return false;
                        }
                        else if (cellValue != '.')
                            return false;
                    }
                }
            }
        }

        return true;
    }
}
