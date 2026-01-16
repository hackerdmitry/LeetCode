using NUnit.Framework;

namespace LeetCode._2._Middle._208._Implement_Trie__Prefix_Tree_;

[TestFixture(TestName = "208. Implement Trie (Prefix Tree)")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test()
    {
        var trie = new Trie();
        trie.Insert("apple");
        Assert.AreEqual(true, trie.Search("apple"));
        Assert.AreEqual(false, trie.Search("app"));
        Assert.AreEqual(true, trie.StartsWith("app"));
        trie.Insert("app");
        Assert.AreEqual(true, trie.Search("app"));
    }
}
