/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int lp = 1;
        int rp = n;
        int result = 0;
        while (lp <= rp)
        {
            int mid = lp + (rp - lp) / 2;
            if (IsBadVersion(mid))
            {
                result = mid;
                rp = mid - 1;
            }
            else
            {
                lp = mid + 1;
            }


        }
        return result;
    }
}