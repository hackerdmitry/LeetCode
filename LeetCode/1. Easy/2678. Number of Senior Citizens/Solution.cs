using System.Linq;

namespace LeetCode._1._Easy._2678._Number_of_Senior_Citizens;

public class Solution
{
    public int CountSeniors(string[] details)
    {
        return details.Count(x => x[11] > '6' || x[11] == '6' && x[12] > '0');
    }
}