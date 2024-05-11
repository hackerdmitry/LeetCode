using System.Collections.Generic;

namespace BuildTask.Helpers;

public class UsingsComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        var isXSpecial = x.StartsWith("System");
        var isYSpecial = y.StartsWith("System");

        return (isXSpecial, isYSpecial) switch
        {
            (true, true) => x.CompareTo(y),
            (true, false) => -1,
            (false, true) => 1,
            (false, false) => x.CompareTo(y),
        };
    }
}