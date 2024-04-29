public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int lp = 0;
        int rp = numbers.Length - 1;
        while (lp < rp)
        {
            int sum = numbers[lp] + numbers[rp];
            if (sum == target) break;
            if (sum < target) lp++;
            if (sum > target) rp--;
        }
        return new int[2] { lp + 1, rp + 1 };
    }
}