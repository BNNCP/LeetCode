public class Solution
{
    public int NumOfPairs(string[] nums, string target)
    {
        int res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (target.Length != nums[i].Length + nums[j].Length || i == j)
                {
                    continue;
                }
                else if (target == nums[i] + nums[j])
                {
                    res++;
                }
            }
        }
        return res;
    }
}