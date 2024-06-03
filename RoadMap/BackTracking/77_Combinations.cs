public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        if (k == 1)
        {
            return new IList<List<int>>(){
                {
                    n
                }
            }
        }
        IList<IList<int>> result = new IList<List<int>>();
        List<int> current = new List<int>();
        BackTracking(1, k, n, current, ref result);
    }

    public void BackTracking(int i, int max, int n, List<int> current, ref result)
    {
        if (current.Count >= )
    }
}