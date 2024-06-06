public class Solution
{
    public int MissingNumber(int[] nums)
    {
        return BinarySearch(nums);
    }

    private int BinarySearch(int[] nums)
    {
        Array.Sort(nums);
        int lp = 0;
        int rp = nums.Length - 1;
        int target = 0;
        while (lp <= rp)
        {
            int mid = (lp + rp) / 2;

            if (nums[mid] == target)
            {
                target++;
                lp = 0;
                rp = nums.Length - 1;
            }

            else if (target > nums[mid])
            {
                lp = mid + 1;
            }
            else
            {
                rp = mid - 1;
            }
        }
        return lp;
    }
}