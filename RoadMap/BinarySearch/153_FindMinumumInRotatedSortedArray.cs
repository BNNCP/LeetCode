public class Solution
{
    public int FindMin(int[] nums)
    {
        return BinarySearch(nums);
    }

    public int BinarySearch(int[] nums)
    {
        int lp = 0;
        int rp = nums.Length - 1;

        while (lp < rp)
        {
            int mid = lp + (rp - lp) / 2;

            if (nums[mid] > nums[rp])
            {
                // The minimum is in the right part
                lp = mid + 1;
            }
            else
            {
                // The minimum is in the left part, including mid
                rp = mid;
            }
        }

        return nums[lp];
    }
}