public class Solution
{
    public int CalPoints(string[] operations)
    {
        if (operations.Length == 0)
        {
            return 0;
        }
        Stack<int> numStack = new Stack<int>();
        foreach (string str in operations)
        {
            int num = 0;
            bool isNum = int.TryParse(str, out num);
            if (isNum)
            {
                numStack.Push(num);
            }
            else
            {
                int prevNum = 0;
                int newNum = 0;
                switch (str)
                {
                    case "+":
                        prevNum = numStack.Pop();
                        newNum = numStack.Peek() + prevNum;
                        numStack.Push(prevNum);
                        numStack.Push(newNum);
                        break;
                    case "D":
                        prevNum = numStack.Peek();
                        newNum = prevNum * 2;
                        numStack.Push(newNum);
                        break;
                    case "C":
                        numStack.Pop();
                        break;
                    default:
                        Console.WriteLine(str);
                        break;
                }
            }
        }
        int result = 0;
        if (numStack.Count > 0)
        {
            foreach (int i in numStack)
            {
                result += i;
            }
        }
        return result;
    }
}