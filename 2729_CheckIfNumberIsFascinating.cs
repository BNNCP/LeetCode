using System;
public class Solution
{
    public bool IsFascinating(int n)
    {
        string Inputs = $"{n * 3}{n * 2}{n * 1}";
        for (int i = 1; i < 10; i++)
        {
            if (Inputs.Contains(i.ToString()))
            {
                return false;
            }
        }
        return true;
    }
}

23491566783