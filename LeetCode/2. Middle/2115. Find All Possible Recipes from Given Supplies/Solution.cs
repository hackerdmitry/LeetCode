using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2115._Find_All_Possible_Recipes_from_Given_Supplies;

public class Solution
{
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
    {
        var hashSupplies = supplies.ToHashSet();
        var dictRecipes = CreateDictRecipes(recipes, ingredients, hashSupplies);

        return recipes.Where(x => dictRecipes[x].CanCreate).ToArray();
    }

    private Dictionary<string, Recipe> CreateDictRecipes(string[] recipes, IList<IList<string>> ingredients, HashSet<string> supplies)
    {
        var dictRecipes = supplies.ToDictionary(x => x, x => new Recipe{Name = x, CanCreate = true});

        for (var i = 0; i < recipes.Length; i++)
        {
            var recipe = EnsureRecipe(recipes[i], dictRecipes);
            recipe.Ingredients = ingredients[i].Select(ing => EnsureRecipe(ing, dictRecipes)).ToArray();
        }

        return dictRecipes;
    }

    private Recipe EnsureRecipe(string nameRecipe, Dictionary<string, Recipe> dictRecipes)
    {
        if (!dictRecipes.TryGetValue(nameRecipe, out var recipe))
        {
            recipe = new Recipe {Name = nameRecipe};
            dictRecipes[nameRecipe] = recipe;
        }
        return recipe;
    }

    private class Recipe
    {
        public string Name { get; set; }
        public Recipe[] Ingredients { get; set; }

        private bool isVerified;
        private bool? canCreate;
        public bool CanCreate
        {
            get
            {
                if (!canCreate.HasValue)
                    canCreate = false;

                if (!isVerified)
                {
                    isVerified = true;
                    canCreate = Ingredients?.All(x => x.CanCreate) ?? false;
                }

                return canCreate.Value;
            }
            init
            {
                canCreate = value;
                isVerified = true;
            }
        }
    }
}
