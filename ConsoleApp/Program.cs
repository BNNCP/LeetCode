namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } };
        int target = 3;
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
        Console.WriteLine(lp);
        Console.WriteLine(rp);
        if (lp > rp)
        {
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
            }
        }
    }
}
