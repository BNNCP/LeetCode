public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                bool result = binarySearch(arr[i] / 2, arr, i);
                if (result == true)
                {
                    return result;
                }
            }
        }
        return false;
    }

    private bool binarySearch(int n, int[] arr, int i)
    {
        int lp = 0;
        int rp = arr.Length - 1;

        while (lp <= rp)
        {
            int mid = (lp + rp) / 2;
            if (arr[mid] > n)
            {
                rp = mid - 1;
            }
            else if (arr[mid] < n)
            {
                lp = mid + 1;
            }
            else
            {
                return mid != i;
            }
        }
        return false;
    }
}