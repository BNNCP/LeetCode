public class Solution
{
    public int TotalSteps(int[] nums)
    {
        int n = nums.Length;
        int res = 0;
        int j = -1;
        int[] dp = new int[n];
        int[] stack = new int[n];
        for (int i = n - 1; i >= 0; --i)
        {
            while (j >= 0 && nums[i] > nums[stack[j]])
            {
                dp[i] = Math.Max(++dp[i], dp[stack[j--]]);
                res = Math.Max(res, dp[i]);
            }
            stack[++j] = i;
        }
        return res;
    }
}