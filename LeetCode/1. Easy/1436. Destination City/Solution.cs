using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1436._Destination_City;

public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var toAdd = new HashSet<string>();
        var toRemove = new HashSet<string>();

        foreach (var path in paths)
        {
            if (toRemove.Contains(path[0]))
                toRemove.Remove(path[0]);
            else
                toAdd.Add(path[0]);

            if (toAdd.Contains(path[1]))
                toAdd.Remove(path[1]);
            else
                toRemove.Add(path[1]);
        }

        return toRemove.First();
    }
}
