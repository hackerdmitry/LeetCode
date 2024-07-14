using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._3._Hard._726._Number_of_Atoms;

public class Solution
{
    public string CountOfAtoms(string formula)
    {
        var index = 0;
        var atoms = CollectAtoms(formula, ref index);

        var result = new Dictionary<string, int>();
        foreach (var atom in atoms)
        {
            if (result.ContainsKey(atom.Name))
                result[atom.Name] += atom.Count;
            else
                result[atom.Name] = atom.Count;
        }

        var resultStringBuilder = new StringBuilder();
        foreach (var (name, count) in result.OrderBy(x => x.Key))
        {
            resultStringBuilder.Append(name);
            if (count > 1)
                resultStringBuilder.Append(count);
        }

        return resultStringBuilder.ToString();
    }

    private LinkedList<Atom> CollectAtoms(string formula, ref int index)
    {
        var atoms = new LinkedList<Atom>();

        for (; index < formula.Length;)
            switch (formula[index])
            {
                case '(':
                    index++;
                    var subAtoms = CollectAtoms(formula, ref index);
                    var factor = ReadNumber(formula, ref index);
                    foreach (var subAtom in subAtoms)
                    {
                        subAtom.Count *= factor;
                        atoms.AddLast(subAtom);
                    }

                    break;
                case ')':
                    index++;
                    return atoms;
                default:
                    atoms.AddLast(ReadAtom(formula, ref index));
                    break;
            }

        return atoms;
    }

    private Atom ReadAtom(string formula, ref int index)
    {
        return new Atom
        {
            Name = ReadElement(formula, ref index),
            Count = ReadNumber(formula, ref index),
        };
    }

    private string ReadElement(string formula, ref int index)
    {
        var startIndex = index++;
        for (; index < formula.Length && 'a' <= formula[index] && formula[index] <= 'z'; index++) ;
        return formula.Substring(startIndex, index - startIndex);
    }

    private int ReadNumber(string formula, ref int index)
    {
        if (index >= formula.Length || !char.IsDigit(formula[index]))
            return 1;

        var number = 0;
        for (; index < formula.Length && char.IsDigit(formula[index]); index++)
            number = number * 10 + formula[index] - '0';
        return number;
    }

    class Atom
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}