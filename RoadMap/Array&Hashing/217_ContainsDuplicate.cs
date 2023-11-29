public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> memo = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (memo.Contains(nums[i]))
            {
                return true;
            }
            memo.Add(nums[i]);
        }
        return false;
    }
}