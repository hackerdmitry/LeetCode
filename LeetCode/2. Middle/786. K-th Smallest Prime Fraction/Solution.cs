using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._786._K_th_Smallest_Prime_Fraction;

public class Solution
{
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        var list = new List<PrimeFraction>();
        for (var i = 0; i < arr.Length; i++)
            for (var j = i + 1; j < arr.Length; j++)
                list.Add(new PrimeFraction(arr[i], arr[j]));

        var kSmallestPrimeFraction = list.OrderBy(x => x.Value).Skip(k - 1).First();
        return new[] {kSmallestPrimeFraction.Nominator, kSmallestPrimeFraction.Denominator};
    }

    class PrimeFraction
    {
        public int Nominator { get; set; }
        public int Denominator { get; set; }

        public decimal Value { get; set; }

        public PrimeFraction(int nominator, int denominator)
        {
            Nominator = nominator;
            Denominator = denominator;
            Value = decimal.Divide(nominator, denominator);
        }
    }
}