/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int lp = 1;
        int rp = n;
        while (true)
        {
            int mid = Math.Abs((lp + rp) / 2);
            int result = guess(mid);
            switch (result)
            {
                case -1:
                    rp = mid - 1;
                    break;
                case 1:
                    lp = mid + 1;
                    break;
                default:
                    return mid;
            }
        }
    }
}