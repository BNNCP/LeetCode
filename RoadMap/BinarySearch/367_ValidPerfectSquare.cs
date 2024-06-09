public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        return BinarySearch(num);
    }

    private bool BinarySearch(int num)
    {
        if (num < 1) return false;
        int lp = 1;
        int rp = num;
        while (lp <= rp)
        {
            int mid = lp + (rp - lp) / 2;
            int temp = num / mid;

            if (num % mid == 0 && temp == mid)
            {
                return true;
            }

            if (temp > mid)
            {
                lp = mid + 1;
            }
            else
            {
                rp = mid - 1;
            }
        }
        return false;
    }
}