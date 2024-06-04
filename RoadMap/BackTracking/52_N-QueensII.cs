public class Solution
{
    public int TotalNQueens(int n)
    {
        int count = 0;
        List<int> col = new List<int>();
        List<int> pDiag = new List<int>();
        List<int> nDiag = new List<int>();

        BackTracking(0, n, col, pDiag, nDiag, ref count);

        return count;
    }

    private void BackTracking(int i, int n, List<int> col, List<int> pDiag, List<int> nDiag, ref int count)
    {
        if (i >= n)
        {
            count += 1;
            return;
        }
        for (int j = 0; j < n; j++)
        {
            if (col.Contains(j) || pDiag.Contains(i + j) || nDiag.Contains(i - j))
            {
                continue;
            }

            col.Add(j);
            pDiag.Add(i + j);
            nDiag.Add(i - j);

            BackTracking(i + 1, n, col, pDiag, nDiag, ref count);

            col.Remove(j);
            pDiag.Remove(i + j);
            nDiag.Remove(i - j);
        }
    }
}