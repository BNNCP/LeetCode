public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int lp = haystack.Length;
        int rp = needle.Length;

        for (int i = 0; i <= lp - rp; i++)
        {
            if (haystack[i] == needle[0])
            {
                bool check = true;
                for (int j = 1; j < rp; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        check = false;
                        break;
                    }
                }
                if (check) return i;
            }
        }
        return -1;
    }
}