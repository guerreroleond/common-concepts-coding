namespace CommonConceptsCoding.Console;

/// <summary>
/// 01Arrays&amp;Hashing-07ValidSudoku [Medium]
/// Determine if a 9x9 Sudoku board is valid based on the standard rules.
/// </summary>
public class ValidSudoku
{
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
                // ToDo: extract cell validation to a private method.
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

        // Validate 3 x 3 sub-boxes.
        for(var rowBox = 0; rowBox < board.Length; rowBox +=3)
        {
            for(var colBox = 0; colBox < board[rowBox].Length; colBox += 3)
            {
                var boxHash = new HashSet<char>();
                for(var row = rowBox; row < rowBox + 3; row++)
                {
                    for(var col = colBox; col < colBox + 3; col++)
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
