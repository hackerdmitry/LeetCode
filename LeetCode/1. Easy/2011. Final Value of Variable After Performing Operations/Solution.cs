using System.Linq;

namespace LeetCode._1._Easy._2011._Final_Value_of_Variable_After_Performing_Operations;

public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        var plus = operations.Count(x => x[1] == '+');
        var minus = operations.Length - plus;
        return plus - minus;
    }
}
