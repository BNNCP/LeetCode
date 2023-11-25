using System.Text.RegularExpressions;
using System;
public class Solution
{
    public int ClosedIsland(int[][] grid)
    {
        int row = grid.Length;
        int col = grid[0].Length;
        HashSet<(int, int)> visited = new HashSet<(int, int)>();

        int result = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (!visited.Contains((i, j)) && grid[i][j] == 0)
                {
                    result += dfs(i, j, row, col, grid, visited);
                }
            }
        }
        return result;
    }

    public int dfs(int i, int j, int row, int col, int[][] grid, HashSet<(int, int)> visited)
    {
        if (i < 0 || j < 0 || i == row || j == col)
        {
            return 0;
        }
        else if (grid[i][j] == 1 || visited.Contains((i, j)))
        {
            return 1;
        }

        visited.Add((i, j));
        return Math.Min(Math.Min(Math.Min(dfs(i + 1, j, row, col, grid, visited), dfs(i - 1, j, row, col, grid, visited)), dfs(i, j + 1, row, col, grid, visited)), dfs(i, j - 1, row, col, grid, visited));
    }
}