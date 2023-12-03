using System.Collections.Generic;
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, List<char>> row = new Dictionary<int, List<char>>();
        Dictionary<int, List<char>> col = new Dictionary<int, List<char>>();
        Dictionary<(int, int), List<char>> square = new Dictionary<(int, int), List<char>>();


        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (!row.ContainsKey(i))
                {
                    row.Add(i, new List<char>());
                }
                if (!col.ContainsKey(j))
                {
                    col.Add(j, new List<char>());
                }
                if (!square.ContainsKey((i / 3, j / 3)))
                {
                    square.Add((i / 3, j / 3), new List<char>());
                }

                if (board[i][j] == '.')
                {
                    continue;
                }
                if (row[i].Contains(board[i][j]) || col[j].Contains(board[i][j]) || square[(i / 3, j / 3)].Contains(board[i][j]))
                {
                    return false;
                }
                row[i].Add(board[i][j]);
                col[j].Add(board[i][j]);
                square[(i / 3, j / 3)].Add(board[i][j]);
            }
        }
        return true;
    }
}

[["5","3",".",".","7",".",".",".","."],
 ["6",".",".","1","9","5",".",".","."],
 [".","9","8",".",".",".",".","6","."],
 ["8",".",".",".","6",".",".",".","3"],
 ["4",".",".","8",".","3",".",".","1"],
 ["7",".",".",".","2",".",".",".","6"],
 [".","6",".",".",".",".","2","8","."],
 [".",".",".","4","1","9",".",".","5"],
 [".",".",".",".","8",".",".","7","9"]]1