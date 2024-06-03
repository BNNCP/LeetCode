public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            BackTracking(i, nums, ref result);
        }
    }

    public void BackTracking(int i, int[] nums, ref List<List<int>> result)
    {

    }
}