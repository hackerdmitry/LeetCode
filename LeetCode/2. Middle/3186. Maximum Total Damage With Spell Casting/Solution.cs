using System;
using System.Linq;

namespace LeetCode._2._Middle._3186._Maximum_Total_Damage_With_Spell_Casting;

public class Solution
{
    public long MaximumTotalDamage(int[] power)
    {
        var spells = power.GroupBy(x => x).Select(x => new Spell(x.Key, x.Count())).OrderBy(x => x.Power).ToArray();

        var resultMaxDamage = 0L;

        for (var i = 0; i < spells.Length; i++)
        {
            var maxDamage = 0L;
            for (var j = Math.Max(0, i - 6); j < i && spells[j].Power + 2 < spells[i].Power; j++)
                maxDamage = Math.Max(maxDamage, spells[j].Damage);
            spells[i].Damage = maxDamage + (long) spells[i].Power * spells[i].Count;
            resultMaxDamage = Math.Max(resultMaxDamage, spells[i].Damage);
        }

        return resultMaxDamage;
    }

    struct Spell
    {
        public int Power { get; set; }
        public int Count { get; set; }
        public long Damage { get; set; }

        public Spell(int power, int count)
        {
            Power = power;
            Count = count;
            Damage = 0;
        }
    }
}