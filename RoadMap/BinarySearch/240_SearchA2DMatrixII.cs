public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        return BinarySearch(matrix, target);
    }

    private bool BinarySearch(int[][] matrix, target)
    {
        int lp = 0;
        int rp = matrix.Length - 1;

        while (lp <= rp)
        {
            int mid = (lp + rp) / 2;

            if (matrix[mid][0] > target)
            {
                rp = mid - 1;
            }
            else if (matrix[mid][matrix[mid].Length - 1] < target)
            {
                lp = mid + 1;
            }
        }
    }
}