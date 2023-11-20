using System;
public class Solution
{
    public int MaxConsecutiveAnswers(string answerKey, int k)
    {
        int times = k;
        int LPointer = 0;
        int RPointer = 0;
        int T = 0;
        int F = 0;
        int result = 0;
        while (RPointer < answerKey.Length)
        {
            if (answerKey[RPointer] == 'T')
            {
                T++;
            }
            else
            {
                F++;
            }

            if (Math.Min(T, F) > k)
            {
                if (answerKey[LPointer] == 'T')
                {
                    T--;
                }
                else
                {
                    F--;
                }
                LPointer++;
            }
            result = Math.Max(result, RPointer - LPointer + 1);
            RPointer++;
        }

        return result;
    }
}