using System;
using System.Collections.Generic;

public class GroupAnagramsProgram
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs == null)
            return new List<IList<string>>();

        Dictionary<string, IList<string>> anagrams = new Dictionary<string, IList<string>>();

        foreach (var item in strs)
        {
            //Console.WriteLine(item);
            char[] itemArr = item.ToCharArray();
            Array.Sort(itemArr);
            var sorted = new string(itemArr);

            IList<string> values;
            if (anagrams.TryGetValue(sorted, out values))
            {
                values.Add(item);
            }
            else
            {
                anagrams.Add(sorted, new List<string> { item });
            }
        }

        var result = new List<IList<string>>();

        foreach (KeyValuePair<string, IList<string>> keyValue in anagrams)
        {
            result.Add(keyValue.Value);
        }

        return result;
    }
}