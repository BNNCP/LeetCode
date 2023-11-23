public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int[] input = nums;
        if (input.Length <= 1) return 0;
        int lp = 0;
        int rp = input.Length - 1;
        int md = getMid(lp, rp);
        while (lp <= rp)
        {
            md = getMid(lp, rp);
            if ((md == 0 || input[md] > input[md - 1]) && (md == input.Length - 1 || input[md] > input[md + 1]))
            {
                return md;
            }
            else if (input[md] > input[md + 1])
            {
                rp = md - 1;
            }
            else
            {
                lp = md + 1;
            }
        }
        return md;
    }

    public int getMid(int left, int right)
    {
        return (left + right) / 2;
    }
}