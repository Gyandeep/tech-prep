public class MinSwapsToPalindromProgram
{
    private int GetMinNoOfSwaps(string s)
    {
        if (s == null || s.Length == 0) return -1;
        int totalSwaps = 0;

        if (IsShuffledPalindrome(s))
        {
            char[] chars = s.ToCharArray();
            int p1 = 0, p2 = chars.Length - 1;

            while (p2 > p1)
            {
                if (chars[p1] != chars[p2])
                {
                    int k = p2;
                    while (k > p1 && chars[k] != chars[p1]) k--;

                    if (k == p1)
                    { //When no matching character found
                        Swap(chars, p1, p1 + 1);
                        totalSwaps++;

                    }
                    else
                    { //When Matching character found swap until K reaches p2 position
                        while (k < p2)
                        {
                            Swap(chars, k, k + 1);
                            totalSwaps++;
                            k++;
                        }
                        p1++; p2--;
                    }
                }
                else
                {
                    p1++; p2--; //When the characters are equal move on
                }
            }
            return totalSwaps;
        }
        else return -1;
    }

    private static void Swap(char[] chars, int k, int i)
    {
        char temp = chars[k];
        chars[k] = chars[i];
        chars[i] = temp;
    }

    private bool IsShuffledPalindrome(string s)
    {
        int[] occurrence = new int[26];
        int oddCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            occurrence[s[i] - 'a']++;
        }
        foreach (int value in occurrence)
        {
            if (value % 2 != 0) oddCount++;
        }
        return oddCount <= 1;
    }
}