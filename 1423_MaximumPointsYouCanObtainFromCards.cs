public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int lp = 0;
        int rp = cardPoints.Length - k;
        int total = 0;

        for(int i = rp; i<cardPoints.Length; i++){
            total += cardPoints[i];
        }

        int result = total;
        while(rp < cardPoints.Length){
            total += (cardPoints[lp] - cardPoints[rp]);
            result = Math.Max(result, total);
            lp++;
            rp++;
        }
        return result;
    }
}