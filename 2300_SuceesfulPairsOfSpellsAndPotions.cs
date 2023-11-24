public class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        // QuickSort(potions, 0, potions.Length - 1);
        Array.Sort(potions);
        int[] result = new int[spells.Length];

        for (int i = 0; i < spells.Length; i++)
        {
            int index = potions.Length;
            int l = 0;
            int r = potions.Length - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if ((long)spells[i] * potions[m] >= success)
                {
                    r = m - 1;
                    index = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            result[i] = potions.Length - index;
        }
        return result;
    }

    public void QuickSort(int[] arr, int Lpointer, int Rpointer)
    {
        if (Rpointer < Lpointer) return;
        int pivot = partition(arr, Lpointer, Rpointer);
        QuickSort(arr, Lpointer, pivot - 1);
        QuickSort(arr, pivot + 1, Rpointer);
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