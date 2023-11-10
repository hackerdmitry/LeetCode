namespace LeetCode._2._Middle._343._Integer_Break
{
    public class Solution
    {
        public int IntegerBreak(int n)
        {
            var maxProduct = 0;
            for (var k = 2; k <= n; k++)
            {
                var mod = n % k;
                var div = n / k;

                var product = div;
                for (var i = 0; i < k - mod - 1; i++)
                    product *= div;
                for (var i = 0; i < mod; i++)
                    product *= div + 1;
                if (maxProduct < product)
                    maxProduct = product;
            }

            return maxProduct;
        }
    }
}