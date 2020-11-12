using System.Collections.Generic;
using System.Linq;

public class MAlignedSetProgram
{
    public int LargestMAlignedSet(int[] arr, int m)
    {
        if (arr == null || arr.Length < 2 || m == 0)
            return 0;

        Dictionary<int, int> remainderMap = new Dictionary<int, int>();

        for(int i = 0; i < arr.Length; i++) {
            int rem = arr[i] % m;
            rem = rem < 0 ? rem + m : rem;

            int count;
            if (remainderMap.TryGetValue(rem, out count)) {
                remainderMap[rem] = count + 1;
            }
            else
            {
                remainderMap.Add(rem, 1);
            }
        }

        return remainderMap.Values.Max();
    }
}