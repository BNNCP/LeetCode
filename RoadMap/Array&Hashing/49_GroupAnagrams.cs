using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
public class Solution
{
    // public IList<IList<string>> GroupAnagrams(string[] strs)
    // {
    //     return strs
    //         .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
    //         .Select(g => g.ToList() as IList<string>)
    //         .ToList();
    // }


    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var charArr = strs[i].ToCharArray();
            Array.Sort(charArr);
            string pivot = new string(charArr);
            if (!map.ContainsKey(pivot))
            {
                map[pivot] = new List<string>();
            }
            map[pivot].Add(strs[i]);
        }
        return new List<IList<string>>(map.Values);
    }
}