public class Solution
{
    public int NthSuperUglyNumber(int n, int[] primes)
    {
        int[] dp = new int[n];
        int[] idx = new int[primes.Length];
        dp[0] = 1;

        for (int i = 1; i < n; i++)
        {
            dp[i] = int.MaxValue;
            for (int j = 0; j < primes.Length; j++)
            {
                dp[i] = Math.Min(dp[i], dp[idx[j]] * primes[j]);
            }

            for (int j = 0; j < primes.length; j++)
            {
                while (primes[j] * dp[idx[j]] <= dp[i]) idx[j]++;
            }
        }

        return dp[n - 1];
    }

    private bool dfs(int target, int index, int[] arr)
    {
        int num = arr[index];
        if (num >= target && num % target == 0 || num >= target && target % num == 0)
        {
            if (index != arr.Length - 1)
            {
                return dfs(target, ++index, arr);
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}