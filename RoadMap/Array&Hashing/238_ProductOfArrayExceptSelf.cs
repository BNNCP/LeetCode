public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int rp = nums.Length - 1;
        int[] prefix = new int[nums.Length];
        int[] postfix = new int[nums.Length];
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            prefix[i] = nums[i];
            postfix[rp] = nums[rp];
            if (i != 0 && rp != nums.Length - 1)
            {
                prefix[i] *= prefix[i - 1];
                postfix[rp] *= postfix[rp + 1];
            }
            rp--;
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (i == 0)
            {
                result[i] = postfix[i + 1];
            }
            else if (i == result.Length - 1)
            {
                result[i] = prefix[i - 1];
            }
            else
            {
                result[i] = prefix[i - 1] * postfix[i + 1];
            }
        }

        return result;
    }
}