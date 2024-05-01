public class Solution
{
    public int Search(int[] nums, int target)
    {
        int lp = 0;
        int rp = nums.Length - 1;
        while (lp <= rp)
        {
            int mid = Math.Abs((lp + rp) / 2);
            if (nums[mid] > target)
            {
                rp = mid - 1;
            }
            else if (nums[mid] < target)
            {
                lp = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
}