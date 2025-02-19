using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1415._The_k_th_Lexicographical_String_of_All_Happy_Strings_of_Length_n;

public class Solution
{
    public string GetHappyString(int n, int k)
    {
        var sequence = GetInitialSequence(n);
        while (--k > 0)
            if (!SetNextLexicographicSequences(sequence))
                return string.Empty;
        return new string(sequence.ToArray());
    }

    private LinkedList<char> GetInitialSequence(int n)
    {
        var sequence = new LinkedList<char>();
        for (var i = 0; i < n; i++)
            sequence.AddLast(i % 2 == 0 ? 'a' : 'b');
        return sequence;
    }

    private bool SetNextLexicographicSequences(LinkedList<char> sequence)
    {
        var node = sequence.Last;
        while (node != null)
            if (SetNextLetter(node))
                node = node.Previous;
            else
                break;
        if (node == null)
            return false;
        while (node != null)
        {
            SetMinLetter(node);
            node = node.Next;
        }

        return true;
    }

    private bool SetNextLetter(LinkedListNode<char> node)
    {
        if (node.Value == 'c')
        {
            node.Value = 'n';
            return true;
        }

        node.Value = (char) (node.Value + 1);

        if (node.Previous != null && node.Previous.Value == node.Value ||
            node.Next != null && node.Next.Value == node.Value)
            return SetNextLetter(node);

        return false;
    }

    private void SetMinLetter(LinkedListNode<char> node)
    {
        if (node.Value != 'n')
            return;
        _ = TrySetLetter(node, 'a') || TrySetLetter(node, 'b') || TrySetLetter(node, 'c');
    }

    private bool TrySetLetter(LinkedListNode<char> node, char letter)
    {
        if ((node.Previous == null || node.Previous.Value != letter) &&
            (node.Next == null || node.Next.Value != letter))
        {
            node.Value = letter;
            return true;
        }

        return false;
    }
}
