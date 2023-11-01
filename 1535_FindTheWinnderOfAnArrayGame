public class Solution
{
    public int GetWinner(int[] arr, int k)
    {
        int winRound = k;
        int winCount = 0;
        int[] items = arr;
        int max = items[0];
        for (int i = 1; i < items.Length; i++)
        {
            if (items[i] > max)
            {
                max = items[i];
                winCount = 0;
            }
            winCount++;
            if (winCount == winRound) break;
        }
        return max;
    }
}