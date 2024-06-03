public class Solution
{
    public int FindKthPositive(int[] arr, int k)
    {
        return binarySearch(arr, k);
    }

    public int binarySearch(int[] arr, int k)
    {
        int lp = 0;
        int rp = arr.Length - 1;

        while (lp <= rp)
        {
            int mid = (lp + rp) / 2;
            if (arr[mid] - mid - 1 < k)
            {
                lp = mid + 1;

            }
            else
            {
                rp = mid - 1;
            }
        }
        return lp + k;
    }
}