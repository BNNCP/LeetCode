public int MaximumJumps(int[] nums, int target)
{
    int[] dp = new int[nums.Length];
    dp[0] = 1;
    for (int i = 0; i < nums.Length; i++)
    {
        if (dp[i] == 0) continue;
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (Math.Abs(nums[j] - nums[i]) <= target)
            {
                dp[j] = Math.Max(dp[j], dp[i] + 1);
            }
        }
    }
    return dp[^1] > 0 ? dp[^1] - 1 : -1;
}