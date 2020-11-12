public class NetworkRankProgram
{
    public class NetworkRank
    {
        public int FindRank(int[] A, int[] B, int N)
        {
            int maxRank = 0;
            int edgesLen = A.Length;

            int[] edgesCount = new int[N + 1];

            for (int i = 0; i < edgesLen; i++)
            {
                edgesCount[A[i]] += 1;
                edgesCount[B[i]] += 1;
            }

            for (int i = 0; i < edgesLen; i++)
            {
                int localMax = edgesCount[A[i]] + edgesCount[B[i]] - 1;
                maxRank = System.Math.Max(maxRank, localMax);
            }

            return maxRank;
        }
    }
}