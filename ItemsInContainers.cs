/*Items in Containers

Amazon would like to know how much inventory exists in their closed inventory compartments. Given a string s
consisting of items as "*" and closed compartments as an open and close "|", an array of starting indices
startIndices, and an array of ending indices endIndices, determine the number of items in closed compartments
within the substring between the two indices, inclusive.

An item is represented as an asterisk ('*' = ascii decimal 42)
A compartment is represented as a pair of pipes that may or may not have items between them ('|' = ascii decimal 124).

Example

s = '|**|*|*'

startIndices = [1, 1]

endIndices = [5, 6]

The string has a total of 2 closed compartments, one with 2 items and one with 1 item. For the first pair of
indices, (1, 5), the substring is '|**|*'. There are 2 items in a compartment.

For the second pair of indices, (1, 6), the substring is '|**|*|' and there are 2 + 1 = 3 items in compartments.

Both of the answers are returned in an array, [2, 3].

Function Description .

Complete the numberOfItems function in the editor below. The function must return an integer array that contains
the results for each of the startIndices[i] and endIndices[i] pairs.

numberOfItems has three parameters:

s: A string to evaluate

startIndices: An integer array, the starting indices.

endIndices: An integer array, the ending indices.

Constraints

1 ≤ m, n ≤ 105
1 ≤ startIndices[i] ≤ endIndices[i] ≤ n
Each character of s is either '*' or '|'

Input Format For Custom Testing

The first line contains a string, S.
The next line contains an integer, n, the number of elements in startIndices.
Each line i of the n subsequent lines (where 1 ≤ i ≤ n) contains an integer, startIndices[i].
The next line repeats the integer, n, the number of elements in endIndices.
Each line i of the n subsequent lines (where 1 ≤ i ≤ n) contains an integer, endIndices[i].

Sample Case 0
Sample Input For Custom Testing

STDIN Function

*|*| -> s = "*|*|"

1 -> startIndices[] size n = 1
1 -> startIndices = 1
1 -> endIndices[] size n = 1
3 -> endIndices = 3

** Sample Output**
0

Explanation
s = *|*|

n = 1
startIndices = [1]
n = 1
startIndices = [3]

The substring from index = 1 to index = 3 is '|'. There is no compartments in this string.

Sample Case 1
Sample Input For Custom Testing

STDIN Function

*|*|*| -> s = "*|*|*|"
1 -> startIndices[] size n = 1
1 -> startIndices = 1
1 -> endIndices[] size n = 1
6 -> endIndices = 6

Sample Output
2

Explanation
s = '*|*|*|'
n = 1
startIndices = [1]
n = 1
startIndices = [1]

The substring from index = 1 to index = 6 is '||*|'. There are two compartments in this string at (index = 2,
index = 4) and (index = 4, index = 6). There are 2 items between these compartments.
*/

public class ItemContainer
{
    public int[] GetItems(string s, int[] startIndices, int[] endIndices)
    {
        if (string.IsNullOrWhiteSpace(s) || startIndices == null
        || endIndices == null || startIndices.Length != endIndices.Length)
            return null;

        int[] result = new int[startIndices.Length];
        char item = '*', delimiter = '|';
        int start = 0, noOfItems = 0;
        bool isOpenFound = false;

        for (int i = 0; i < startIndices.Length; i++)
        {
            for (int j = startIndices[i]; j < s.Length && j <= endIndices[i]; j++)
            {
                if (s[j] == delimiter)
                {
                    if (!isOpenFound)
                    {
                        isOpenFound = true;
                    }
                    else
                    {
                        noOfItems += j - start + 1;
                    }

                    start = j;
                }
            }
        }

        return new int[0];
    }
}

/*
public static List<int> NumberOfItems(String s, int[] startIndices,                                                                 int[] endIndices) 
    {
        List<int> ans = new List<int>();
        List<int> pipeIndices = new List<int>();
        
        for(int i=0; i<s.Length; i++)
        {
            if(s[i]=='|')
                pipeIndices.Add(i);
        }
        
        for(int i=0;i<startIndices.Length;i++)
        {
            int cnt = CountItems(pipeIndices, startIndices[i]-1, endIndices[i]-1);
            ans.Add(cnt);
        }
        
        return ans;
    }
    
    private static int CountItems(List<int> pipeIndices,int st,int en)
    {
        if(pipeIndices.Count<=1)
            return 0;
        
        int cnt=0;
        int prevInd = -1;
        
        foreach(var ind in pipeIndices)
        {
            if(ind>=st && ind<=en)
            {
                if(prevInd!=-1)
                    cnt+=ind-prevInd-1;
                prevInd = ind;
            }
        }
        return cnt;
    }
*/