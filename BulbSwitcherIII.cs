public class BulbSwitcherIIIProgram
{
    public int CountBlueBulbs(int[] light)
    {
        if (light == null || light.Length == 0)
            return 0;

        int indexSum = 0, valueSum = 0, count = 0;

        for (int i = 0; i < light.Length; i++)
        {
            indexSum += i + 1;
            valueSum += light[i];
            count = indexSum == valueSum ? count + 1 : count;
        }
        
        return count;
    }
}