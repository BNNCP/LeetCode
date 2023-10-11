public class Solution {
    public int Reverse(int x) {
        if(isOutOfIntRange(x)) return 0;
        int isPos = x>0?1:-1;
        int input = Math.Abs(x);
        int length = getLength(input);
        long result = 0;
        for(int i =length-1;i>=0;i--){
            result += Convert.ToInt64(Math.Pow(10,i)*(input%10));
            input = Convert.ToInt32(input/10);
        }
        if(isOutOfLongRange(result)) return 0;
        return (int)result*isPos;
    }

    public int getLength(int x){
        return (int)Math.Floor(Math.Log10(x))+1;
    }

    public bool isOutOfLongRange(long x){
        if(x>=Int32.MaxValue||x<=Int32.MinValue){
            return true;
        }
        return false;
    }

    public bool isOutOfIntRange(int x){
        if(x>=Int32.MaxValue||x<=Int32.MinValue){
            return true;
        }
        return false;
    }
}