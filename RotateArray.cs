public class RotateArrayProgram
{
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (A == null)
         return null;
         
        int[] result = new int[A.Length];
        int j =  K % A.Length;
        
        for (int i = 0; i < A.Length; i++) {
            if (j >= A.Length)
                j = 0;
            
            result[j] = A[i];    
            j++;
        }
        
        return result;
    }
}