using System.Collections.Generic;

public class SpiralOrderProgram
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int r1 = 0, r2 = matrix.Length - 1;
        int c1 = 0, c2 = matrix[0].Length - 1;

        List<int> output = new List<int>();

        while (r1 <= r2 && c1 <= c2)
        {
            for (int c = c1; c <= c2; c++) output.Add(matrix[r1][c]);
            for (int r = r1 + 1; r <= r2; r++) output.Add(matrix[r][c2]);

            if (r1 < r2 && c1 < c2)
            {
                for (int c = c2 - 1; c > c1; c--) output.Add(matrix[r2][c]);
                for (int r = r2; r > r1; r--) output.Add(matrix[r][c1]);
            }

            r1++;
            c1++;
            r2--;
            c2--;
        }

        return output;
    }
}