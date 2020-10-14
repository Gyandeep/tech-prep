using System;
using System.Collections.Generic;
using System.Linq;

public class ReorderLogs
{
    public string[] ReorderLogFiles(string[] logs) {
        if (logs == null || logs.Length == 0)
            return logs;
        
        List<string> digitLogs = new List<string>();
        List<string> letterLogs = new List<string>();
        
        for (int i = 0; i < logs.Length; i++)
        {
            long val;
            if (long.TryParse(logs[i].Split(" ")[1], out val)) {
                digitLogs.Add(logs[i]);
            }
            else
                letterLogs.Add(logs[i]);
        }
        
        // Array.Sort(letterLogs.ToArray(), new CustomComparer());
        var sorted = letterLogs.OrderBy(j => j, new CustomComparer());
        //sorted.AddRange(digitLogs);
        return sorted.ToArray();
    }
    
    private class CustomComparer: IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int i = x.Split(" ")[0].Length;
            int j = y.Split(" ")[0].Length;
            //Console.WriteLine(i);
           // Console.WriteLine(j);
            string x1 = x.Substring(i + 1);
            string y1 = y.Substring(j + 1);
            
            return x1.CompareTo(y1);
        }
    }
}