namespace LeetCode._458._Poor_Pigs
{
    public class Solution
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            var rounds = minutesToTest / minutesToDie + 1;
            var bucketsByRound = 1;

            for (var pigs = 0; ; pigs++)
            {
                if (bucketsByRound >= buckets)
                    return pigs;

                bucketsByRound *= rounds;
            }

        }
    }
}