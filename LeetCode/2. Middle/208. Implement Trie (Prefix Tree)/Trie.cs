namespace LeetCode._2._Middle._208._Implement_Trie__Prefix_Tree_;

public class Trie
{
    private TrieNode root = new(' ');

    public void Insert(string word)
    {
        var node = root;
        foreach (var c in word)
            node = node.AddChild(c);
        node.SetEndOfWord();
    }

    public bool Search(string word)
    {
        var node = root;
        foreach (var c in word)
        {
            node = node.GetChild(c);
            if (node == null)
                return false;
        }

        return node.IsEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var node = root;
        foreach (var c in prefix)
        {
            node = node.GetChild(c);
            if (node == null)
                return false;
        }

        return true;
    }

    private class TrieNode
    {
        private TrieNode[] children;

        public char Letter { get; }
        public bool IsEndOfWord { get; private set; }

        public TrieNode(char letter)
        {
            Letter = letter;
            IsEndOfWord = false;
        }

        public TrieNode GetChild(char letter)
        {
            return children?[letter - 'a'];
        }

        public TrieNode AddChild(char letter)
        {
            children ??= new TrieNode[26];

            var index = letter - 'a';
            var child = children[index];

            if (child == null)
            {
                var childNode = new TrieNode(letter);
                child = children[index] = childNode;
            }

            return child;
        }

        public void SetEndOfWord()
        {
            IsEndOfWord = true;
        }
    }
}