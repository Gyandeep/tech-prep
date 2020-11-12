 using System.Collections.Generic;

public class LastStoneWeightProgram {
     public int LastStoneWeight(int[] stones) {
        SortedSet<HeapObj> maxHeap = new SortedSet<HeapObj>(new MaxHeapComparer());
        
        int counter = 1;
        foreach(var stone in stones) {
            maxHeap.Add(new HeapObj(stone) { Index = counter++ });
        }
        
        while (maxHeap.Count > 1) {
            var x = maxHeap.Max;
            maxHeap.Remove(x);
            // Console.WriteLine()
            var y = maxHeap.Max;
            maxHeap.Remove(y);
            
            if (x.Weight != y.Weight) {
                maxHeap.Add(new HeapObj(x.Weight - y.Weight) { Index = counter++ });
            }
        }
        
        return maxHeap.Count == 1 ? maxHeap.Max.Weight : 0;
    }
    
    private class HeapObj
    {
        public HeapObj(int weight) {
            this.Weight = weight;
        }
        
        public int Index { get;set; } 

        public int Weight {get;set;}
    }
    
    private class MaxHeapComparer : IComparer<HeapObj>
    {
        public int Compare(HeapObj x, HeapObj y) {
            return x.Weight.CompareTo(y.Weight);
        }
    }
}