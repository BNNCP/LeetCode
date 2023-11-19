public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
{
    int targetHour = target;
    int[] workHours = hours;
    int result = 0;
    foreach (int workhour in workHours)
    {
        if (workhour >= targetHour)
        {
            result++;
        }
    }
    return result;
}