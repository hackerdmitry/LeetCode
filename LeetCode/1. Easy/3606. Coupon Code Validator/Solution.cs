using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._3606._Coupon_Code_Validator;

public class Solution
{
    private static readonly LexicographicalOrder lexicographicalOrder = new();

    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        return CreateCoupons(code, businessLine, isActive)
            .Where(x => x.IsValid())
            .OrderBy(x => x.BusinessLine)
            .ThenBy(x => x.Code, lexicographicalOrder)
            .Select(x => x.Code)
            .ToArray();
    }

    private Coupon[] CreateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        var coupons = new Coupon[code.Length];
        for (var i = 0; i < code.Length; i++)
            coupons[i] = new Coupon(code[i], businessLine[i], isActive[i]);
        return coupons;
    }

    private class Coupon
    {
        public string Code { get; set; }
        public int BusinessLine { get; set; }
        public bool IsActive { get; set; }

        public Coupon(string code, string businessLine, bool isActive)
        {
            Code = code;
            BusinessLine = businessLine switch
            {
                "electronics" => 1,
                "grocery" => 2,
                "pharmacy" => 3,
                "restaurant" => 4,
                _ => -1,
            };
            IsActive = isActive;
        }

        public bool IsValid()
        {
            return Code.Length > 0 && Code.All(x => x is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9' or '_') &&
                   BusinessLine != -1 &&
                   IsActive;
        }
    }

    private class LexicographicalOrder : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.CompareOrdinal(x, y);
        }
    }
}