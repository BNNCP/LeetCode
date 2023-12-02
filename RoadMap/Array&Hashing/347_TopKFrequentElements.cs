using System.Collections;
using System.Collections.Generic;
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int[] result = new int[k];
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map.Add(num, 1);
            }
        }

        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }

        foreach (var i in map)
        {
            freq[i.Value].Add(i.Key);
        }

        int countofresultelements = 0;

        for (int i = freq.Length - 1; i >= 1; i--)
        {
            int elementsTobeAdded = freq[i].Count;
            while (elementsTobeAdded > 0)
            {
                result[countofresultelements] = freq[i][elementsTobeAdded - 1];
                elementsTobeAdded--;
                countofresultelements++;
            }

            if (countofresultelements == k)
            {
                break;
            }
        }

        return result;
    }
}