using System;
public class Solution
{
    public int DominantIndex(int[] nums)
    {
        int[] origin = nums.Clone();
        int[] array = nums;
        quickSort(array, 0, array.Length - 1);
        int result = array[array.Length - 1] >= array[array.Length - 2] * 2 ? Array.IndexOf(origin, array[array.Length - 1]) : -1;
        return result;
    }
    public void quickSort(int[] array, int left, int right)
    {
        if (right <= left) return;
        int pivot = partition(array, left, right);
        quickSort(array, left, pivot - 1);
        quickSort(array, pivot + 1, right);
    }

    public int partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j <= right - 1; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        i++;
        int pivotTemp = array[i];
        array[i] = array[right];
        array[right] = pivotTemp;
        return i;
    }
}