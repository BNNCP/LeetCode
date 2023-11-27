public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> resulttemp = new HashSet<int>();
        Array.Sort(nums2);
        for (int i = 0; i < nums1.Length; i++)
        {
            if (BinarySearch(nums2, nums1[i]))
            {
                if (!resulttemp.Contains(nums1[i]))
                {
                    resulttemp.Add(nums1[i]);
                };
            };
        }
        int[] result = new int[resulttemp.Count];
        int index = 0;
        foreach (int num in resulttemp)
        {
            result[index++] = num;
        }

        return result;
    }

    private bool BinarySearch(int[] arr, int target)
    {
        int lp = 0;
        int rp = arr.Length - 1;
        while (lp <= rp)
        {
            int mp = (rp + lp) / 2;
            if (arr[mp] < target)
            {
                lp = mp + 1;
            }
            else if (arr[mp] > target)
            {
                rp = mp - 1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}