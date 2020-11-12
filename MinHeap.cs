using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class MinHeapProgram {
    
    SortedSet<int> heap;
    
    public MinHeapProgram()
    {
        this.heap = new SortedSet<int>(new MinHeapComparer());
    }
     
    public void Add(int value) {
        heap.Add(value);
    }

    public int Peek() {
        return heap.Min;
    }

    public int Remove() {
        int removing = heap.Min ; 
        heap.Remove(removing);
        return removing;
    }
}

public class MinHeapComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
    }
}