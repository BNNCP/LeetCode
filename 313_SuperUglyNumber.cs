public class Solution
{
    public int NthSuperUglyNumber(int n, int[] primes)
    {
        int[] dp = new int[n];
        dp[0] = 1;

        int[] pointers = new int[primes.Length];

        for (int i = 1; i < n; i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < primes.Length; j++)
            {
                min = Math.Min(min, dp[pointers[j]] * primes[j]);
            }
            dp[i] = min;

            for (int j = 0; j < primes.Length; j++)
            {
                if (dp[pointers[j]] * primes[j] == min)
                {
                    pointers[j]++;
                }
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