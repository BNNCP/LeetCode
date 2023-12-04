using System.Collections.Generic;
public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length < 2)
        {
            return false;
        }
        Stack<char> stacks = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>(){
            {'(',')'},
            {'[',']'},
            {'{','}'}
        };
        foreach (char c in s)
        {
            if (map.ContainsKey(c))
            {
                stacks.Push(c);
            }
            else if (stacks.Count > 0 && c == map[stacks.Peek()])
            {
                stacks.Pop();
            }
            else
            {
                return false;
            }
        }
        return stacks.Count == 0;
    }
}