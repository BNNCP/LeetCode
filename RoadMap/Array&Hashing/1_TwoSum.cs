using System.Collections.Generic;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> hashmap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int dif = target - nums[i];
            if (hashmap.ContainsKey(dif))
            {
                return new int[] { hashmap[dif], i};
            }
            else
            {
                hashmap[nums[i]] = i;
            }
        }
        return null;
    }
}