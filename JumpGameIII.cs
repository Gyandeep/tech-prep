using System;
using System.Collections.Generic;

public class JumpGameIIIProgram
{
    public bool CanReach(int[] arr, int start)
    {
        if (arr == null || arr.Length <= start || start < 0)
        {
            return false;
        }

        if (arr.Length == 1 && arr[0] != 0)
            return false;

        bool[] visited = new bool[arr.Length];
        Queue<Tuple<int, int>> itemQueue = new Queue<Tuple<int, int>>();
        itemQueue.Enqueue(new Tuple<int, int>(start, arr[start]));

        while (itemQueue.Count > 0)
        {
            int count = itemQueue.Count;
           for (int i = 0; i < count; i++) {
                var tuple = itemQueue.Dequeue();

                if (tuple.Item2 == 0)
                    return true;

                if (visited[tuple.Item1] == true)
                    continue;

                visited[tuple.Item1] = true;
                var leftIndex = tuple.Item1 - tuple.Item2;
                var rightIndex = tuple.Item1 + tuple.Item2;

                if (leftIndex >=0 && leftIndex < arr.Length) itemQueue.Enqueue(new Tuple<int, int>(leftIndex, arr[leftIndex]));
                if (rightIndex >= 0 && rightIndex < arr.Length) itemQueue.Enqueue(new Tuple<int, int>(rightIndex, arr[rightIndex]));
           }
        }

        return false;
    }
}