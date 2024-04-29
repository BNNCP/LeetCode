public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new IList<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (i > 0 && num == nums[i - 1])
            {
                continue;
            }

            int lp = i + 1;
            int rp = nums.Length - 1;

            while (lp < rp)
            {
                int threeSum = num + nums[lp] + nums[rp];
                if (threeSum == 0)
                {
                    result.Add([num, nums[lp], nums[rp]]);
                    lp++;
                    while (nums[lp] == nums[lp - 1] && lp < rp)
                    {
                        lp++;
                    }
                }
                else if (threeSum < 0) lp++;
                else if (threeSum > 0) rp--;
            }
        }

        return result;  
    }
}