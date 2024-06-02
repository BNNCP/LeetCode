public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int result = 0;
        int curNum = 0;
        BackTracking(0, nums, ref result, curNum);

        return result;
    }

    public void BackTracking(int i, int[] nums, ref int result, int curNum)
    {
        if (i >= nums.Length)
        {
            result += curNum;
            return;
        }
        BackTracking(i + 1, nums, ref result, curNum);
        curNum ^= nums[i];
        BackTracking(i + 1, nums, ref result, curNum);
    }
}