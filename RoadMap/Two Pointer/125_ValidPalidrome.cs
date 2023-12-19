public class Solution
{
    public bool IsPalindrome(string s)
    {
        int lp = 0;
        int rp = s.Length-1;
        while (lp <= rp)
        {
            if (!Char.IsLetterOrDigit(s[lp]))
            {
                lp++;
            }
            else if (!Char.IsLetterOrDigit(s[rp]))
            {
                rp--;
            }
            else if (Char.ToLower(s[lp]) == Char.ToLower(s[rp]))
            {
                lp++;
                rp--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}