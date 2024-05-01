public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int lp = 0;
        int rp = matrix.Length - 1;
        while (lp <= rp)
        {
            int mid = Math.Abs((lp + rp) / 2);
            if (matrix[mid][0] > target)
            {
                rp = mid - 1;
            }
            else if (matrix[mid][matrix[mid].Length - 1] < target)
            {
                lp = mid + 1;
            }
            else
            {
                break;
            }
        }
        if (lp > rp)
        {
            return false;
        }
        int nlp = 0;
        int nrp = matrix[0].Length - 1;
        while (nlp <= nrp)
        {
            int mid = Math.Abs((nlp + nrp) / 2);
            if (matrix[lp][mid] > target)
            {
                nrp = mid - 1;
            }
            else if (matrix[lp][mid] < target)
            {
                nlp = mid + 1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}