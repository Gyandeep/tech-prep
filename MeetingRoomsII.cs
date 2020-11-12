using System;

public class MeetingRoomsIIProgram
{
    public int MinMeetingRooms(int[][] intervals)
    {
        var startingTime = new int[intervals.Length];
        var endingTime = new int[intervals.Length];
        for (int i = 0; i < intervals.Length; i++)
        {
            startingTime[i] = intervals[i][0];
            endingTime[i] = intervals[i][1];
        }

        Array.Sort(startingTime);
        Array.Sort(endingTime);

        var currEnding = 0;
        var currRooms = 0;
        for (int i = 0; i < startingTime.Length; i++)
        {
            if (startingTime[i] >= endingTime[currEnding])
            {
                currRooms--;
                currEnding++;
            }
            currRooms++;
        }

        return currRooms;
    }
}