using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2353._Design_a_Food_Rating_System;

public class FoodRatings
{
    private readonly Dictionary<string, (string, int)> maxFoods = new();

    private readonly Dictionary<string, IDictionary<string, int>> cuisinesByRatings = new();
    private readonly Dictionary<string, IList<string>> foodsByCuisines = new();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        for (var i = 0; i < foods.Length; i++)
        {
            if (!foodsByCuisines.ContainsKey(foods[i]))
                foodsByCuisines[foods[i]] = new List<string>();

            if (!cuisinesByRatings.ContainsKey(cuisines[i]))
                cuisinesByRatings[cuisines[i]] = new Dictionary<string, int>();

            cuisinesByRatings[cuisines[i]].Add(foods[i], ratings[i]);
            foodsByCuisines[foods[i]].Add(cuisines[i]);
        }
    }

    public void ChangeRating(string food, int newRating)
    {
        foreach (var cuisine in foodsByCuisines[food])
        {
            cuisinesByRatings[cuisine][food] = newRating;
            if (maxFoods.ContainsKey(cuisine))
                if (maxFoods[cuisine].Item2 < newRating ||
                    maxFoods[cuisine].Item2 == newRating && string.Compare(food, maxFoods[cuisine].Item1, StringComparison.Ordinal) < 0)
                    maxFoods[cuisine] = (food, newRating);
                else if (maxFoods[cuisine].Item1 == food)
                    maxFoods.Remove(cuisine);
        }
    }

    public string HighestRated(string cuisine)
    {
        if (!maxFoods.ContainsKey(cuisine))
        {
            var maxRating = -1;
            var maxFood = string.Empty;

            foreach (var (food, rating) in cuisinesByRatings[cuisine])
            {
                if (maxRating < rating ||
                    maxRating == rating && string.Compare(food, maxFood, StringComparison.Ordinal) < 0)
                {
                    maxRating = rating;
                    maxFood = food;
                }
            }

            maxFoods[cuisine] = (maxFood, maxRating);
        }

        return maxFoods[cuisine].Item1;
    }
}
