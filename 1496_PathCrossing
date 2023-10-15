public class Solution
{
    public bool IsPathCrossing(string path)
    {
        if (string.IsNullOrEmpty(path)) return false;
        string input = path;
        int[] position = { 0, 0 };
        return checkPathCrossing(input, position);
    }

    public bool checkPathCrossing(string input, int[] position)
    {
        List<int[]> steps = new List<int[]>();
        steps.Add(new int[] { position[0], position[1] });
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'N':
                    position[1]++;
                    break;
                case 'S':
                    position[1]--;
                    break;
                case 'E':
                    position[0]++;
                    break;
                default:
                    position[0]--;
                    break;
            }
            if (steps.Any(p => p[0] == position[0] && p[1] == position[1])) return true;
            steps.Add(new int[] { position[0], position[1] });
        }
        return false;
    }
}