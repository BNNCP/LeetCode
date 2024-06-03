public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> result = new List<IList<string>>();
        List<int> col = new List<int>();
        List<int> pDiag = new List<int>();
        List<int> nDiag = new List<int>();

        char[][] board = new char[n][];
        for (int i = 0; i < n; i++)
        {
            board[i] = new char[n];
            Array.Fill(board[i], '.');
        }

        BackTracking(0, n, col, pDiag, nDiag, board, ref result);
        return result;
    }

    private void BackTracking(int r, int n, List<int> col, List<int> pDiag, List<int> nDiag, char[][] board, ref IList<IList<string>> result)
    {
        if (r >= n)
        {
            List<string> copy = new List<string>();
            foreach (char[] row in board)
            {
                copy.Add(new string(row));
            }
            result.Add(copy);
            return;
        }

        for (int c = 0; c < n; c++)
        {
            if (col.Contains(c) || pDiag.Contains(r + c) || nDiag.Contains(r - c))
            {
                continue;
            }

            col.Add(c);
            pDiag.Add(r + c);
            nDiag.Add(r - c);
            board[r][c] = 'Q';

            BackTracking(r + 1, n, col, pDiag, nDiag, board, ref result);

            col.Remove(c);
            pDiag.Remove(r + c);
            nDiag.Remove(r - c);
            board[r][c] = '.';
        }
    }
}