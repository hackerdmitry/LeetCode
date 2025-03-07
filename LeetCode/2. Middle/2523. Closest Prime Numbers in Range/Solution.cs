using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2523._Closest_Prime_Numbers_in_Range;

public class Solution
{
    private static readonly List<int> primeNumbers = CreatePrimeNumbers();

    public int[] ClosestPrimes(int left, int right)
    {
        var num1 = -1;
        var num2 = -1;

        for (var k = 0; k < primeNumbers.Count; k++)
            if (primeNumbers[k] >= left)
            {
                if (k + 1 == primeNumbers.Count || primeNumbers[k + 1] > right)
                    return new[] {-1, -1};

                num1 = primeNumbers[k++];
                num2 = primeNumbers[k];

                while (++k < primeNumbers.Count && primeNumbers[k] <= right)
                    if (num2 - num1 > primeNumbers[k] - primeNumbers[k - 1])
                    {
                        num1 = primeNumbers[k - 1];
                        num2 = primeNumbers[k];
                    }

                break;
            }

        return new[] {num1, num2};
    }

    private static List<int> CreatePrimeNumbers()
    {
        var primeNumbers = new List<int>{2,3,5,7};
        for (var i = 11; i < 1_000_000; i+=2)
        {
            var bounder = (int) Math.Floor(Math.Sqrt(i));
            foreach (var primeNumber in primeNumbers)
            {
                if (primeNumber > bounder)
                    break;
                if (i % primeNumber == 0)
                    goto next;
            }
            primeNumbers.Add(i);
            next: ;
        }

        return primeNumbers;
    }
}