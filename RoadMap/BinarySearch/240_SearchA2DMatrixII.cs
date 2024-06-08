public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        return BinarySearch(matrix, target);
    }

    private bool BinarySearch(int[][] matrix, int target)
    {
        int row = 0;
        int col = matrix[0].Length - 1;

        while (row < matrix.Length && col >= 0)
        {
            int cur = matrix[row][col];

            if (cur == target)
            {
                return true;
            }
            else if (cur > target)
            {
                col--;
            }
            else if (cur < target)
            {
                row++;
            }
        }

        return false;
    }
}