public class Solution
{
    public void SortColors(int[] nums)
    {
        Dictionary<int, int> colorMap = new Dictionary<int, int>(){
            {0,0},
            {1,0},
            {2,0}
        };
        foreach (int num in nums)
        {
            colorMap[num] += 1;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (colorMap[0] > 0)
            {
                nums[i] = 0;
                colorMap[0] -= 1;
            }
            else if (colorMap[1] > 0)
            {
                nums[i] = 1;
                colorMap[1] -= 1;
            }
            else
            {
                nums[i] = 2;
            }
        }

    }
}