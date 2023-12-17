using NUnit.Framework;

namespace LeetCode._2._Middle._2353._Design_a_Food_Rating_System;

[TestFixture(TestName = "2353. Design a Food Rating System")]
public class Tests
{
    [Timeout(1000)]
    [Test]
    public void Test()
    {
        var foodRatings = new FoodRatings(
                new[]{"kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi"},
                new[]{"korean", "japanese", "japanese", "greek", "japanese", "korean"},
                new[]{9, 12, 8, 15, 14, 7});
        Assert.AreEqual("kimchi", foodRatings.HighestRated("korean"));
        // "kimchi" is the highest rated korean food with a rating of 9.
        Assert.AreEqual("ramen", foodRatings.HighestRated("japanese"));
        // "ramen" is the highest rated japanese food with a rating of 14.
        foodRatings.ChangeRating("sushi", 16); // "sushi" now has a rating of 16.
        Assert.AreEqual("sushi", foodRatings.HighestRated("japanese"));
        // "sushi" is the highest rated japanese food with a rating of 16.
        foodRatings.ChangeRating("ramen", 16); // "ramen" now has a rating of 16.
        Assert.AreEqual("ramen", foodRatings.HighestRated("japanese"));
        // Both "sushi" and "ramen" have a rating of 16.
        // However, "ramen" is lexicographically smaller than "sushi".
    }
}
