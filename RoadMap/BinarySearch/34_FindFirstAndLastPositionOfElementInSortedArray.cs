public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        return BinarySearch(nums, target);
    }

    private int[] BinarySearch(int[] nums, int target)
    {
        int lp = 0;
        int rp = nums.Length - 1;
        int[] result = new int[2] { -1, -1 };

        while (lp <= rp)
        {
            int mid = lp + (rp - lp) / 2;
            if (nums[mid] < target)
            {
                lp = mid + 1;
            }
            else
            {
                rp = mid - 1;
            }
        }
        if (lp >= nums.Length || nums[lp] != target)
        {
            return result;
        }
        result[0] = lp;

        rp = nums.Length - 1;

        while (lp <= rp)
        {
            int mid = lp + (rp - lp) / 2;
            if (nums[mid] <= target)
            {
                lp = mid + 1;
            }
            else
            {
                rp = mid - 1;
            }
        }
        result[1] = rp;

        return result;
    }
}