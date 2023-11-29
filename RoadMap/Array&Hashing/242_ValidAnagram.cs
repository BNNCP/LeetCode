public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> smap = new Dictionary<char, int>(s.Length);
        Dictionary<char, int> tmap = new Dictionary<char, int>(t.Length);

        for (int i = 0; i < s.Length; i++)
        {
            smap[s[i]] = smap.ContainsKey(s[i]) ? smap[s[i]] + 1 : 1;
            tmap[t[i]] = tmap.ContainsKey(t[i]) ? tmap[t[i]] + 1 : 1;
        }

        int value;
        foreach (KeyValuePair<char, int> c in smap)
        {
            if (smap[c.Key] != (tmap.TryGetValue(c.Key, out value) ? value : 0))
            {
                return false;
            }
        }
        return true;
    }
}