public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> current = new List<int>();
        BackTracking(0, nums, current, ref result);
        return result;
    }

    public void BackTracking(int i, int[] nums, IList<int> current, ref IList<IList<int>> result)
    {
        if (i >= nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }
        current.Add(nums[i]);
        BackTracking(i + 1, nums, current, ref result);
        current.RemoveAt(current.Count - 1);
        BackTracking(i + 1, nums, current, ref result);
    }
}