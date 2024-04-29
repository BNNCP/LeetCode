public class Solution
{
    public int MaxArea(int[] height)
    {
        int lp = 0;
        int rp = height.Length - 1;
        int max = 0;
        while (lp < rp)
        {
            int curHeight = Math.Min(height[lp], height[rp]);
            int curWidth = rp - lp;
            int curArea = curHeight * curWidth;
            max = Math.Max(max, curArea);

            if (height[lp] < height[rp]) lp++;
            else rp--;
        }

        return max;
    }
}