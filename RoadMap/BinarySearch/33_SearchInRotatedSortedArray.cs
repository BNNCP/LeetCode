public class Solution
{
    public int Search(int[] nums, int target)
    {
        return BinarySearch(nums, target);
    }

    public int BinarySearch(int[] nums, int target)
    {
        int lp = 0;
        int rp = nums.Length - 1;

        while (lp <= rp)
        {
            int mid = (rp + lp) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] >= nums[lp])
            {
                if (nums[lp] <= target && nums[mid] > target)
                {
                    rp = mid - 1;
                }
                else
                {
                    lp = mid + 1;
                }
            }

            else
            {
                if (nums[rp] >= target && nums[mid] < target)
                {
                    lp = mid + 1;
                }
                else
                {
                    rp = mid - 1;
                }
            }
        }

        return -1;
    }
}