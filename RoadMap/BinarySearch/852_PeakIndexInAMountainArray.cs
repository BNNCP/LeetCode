public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        return binarySearch(arr);
    }

    private int binarySearch(int[] arr)
    {
        int lp = 0;
        int rp = arr.Length - 1;
        while (lp <= rp)
        {
            int mid = (lp + rp) / 2;
            if (arr[mid] < arr[mid - 1])
            {
                rp = mid;
            }
            else if (arr[mid] < arr[mid + 1])
            {
                lp = mid;
            }
            else
            {
                return mid;
            }
        }
        return 0;
    }
}