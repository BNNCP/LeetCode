using System.Collections;
using System.Collections.Generic;
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int result = 0;
        foreach (int num in nums)
        {
            if (set.Contains(num - 1))
            {
                continue;
            }

            int length = 0;
            while (set.Contains(num + length))
            {
                length++;
            }
            result = Math.Max(result, length);
        }
        return result;
    }
}