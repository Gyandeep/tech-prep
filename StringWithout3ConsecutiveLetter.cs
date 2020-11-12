public class StringWithoutThreeLettersProgram
{
    public int MinSteps(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        int moves = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int currentCount = 1;
            for (; i + 1 < s.Length && s[i] == s[i + 1]; i++)
            {
                currentCount++;
            }
            moves += currentCount / 3;
        }

        return moves;
    }
}