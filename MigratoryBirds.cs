using System;
using System.Collections.Generic;

public class MigratoryBirdsProgram
{
    public static int MigratoryBirds(List<int> arr)
    {
        if (arr == null || arr.Count == 0)
        {
            return 0;
        }

        var birds = arr.ToArray();
        System.Array.Sort(birds);

        int maxCount = 0;
        int maxType = -1;
        int currentCount = 0;
        int prevType = -1;

        foreach (var item in birds)
        {
            if (prevType == -1) {
                prevType = item;
                currentCount++;
                continue;
            }

            if (item == prevType) {
                currentCount++;
            }
            else {
                if (maxType == -1) {
                    maxType = prevType;
                    maxCount = currentCount;
                }
                else {
                    if (maxCount == currentCount) {
                        maxType = Math.Min(maxType, prevType);
                    }
                    else if (currentCount > maxCount) {
                        maxType = prevType;
                        maxCount = currentCount;
                    }
                }
                currentCount = 1;
            }

            prevType = item;
        }

        return maxType;
    }
}