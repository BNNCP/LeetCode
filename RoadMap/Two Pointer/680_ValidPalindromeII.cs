public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int lp = 0;
        int rp = s.Length - 1;

        while (lp < rp)
        {
            if (s[lp] == s[rp])
            {
                lp++;
                rp--;
            }
            else
                return IsPalindrome(s, lp + 1, rp) || IsPalindrome(s, lp, rp - 1);
        }

        return true;
    }
    private bool IsPalindrome(string s, int lp, int rp)
    {
        while (lp < rp)
        {
            if (s[lp] != s[rp])
                return false;
            lp++;
            rp--;
        }
        return true;
    }
}