using System;
using System.Collections.Generic;
using System.Linq;

namespace Rezipe.ViewModels
{
    public class RecipeDisplay
    {
        public RecipeDisplay(Recipe recipe)
        {
            Recipe = recipe ?? throw new ArgumentNullException(nameof(recipe));

            IngredientListings = Recipe.Ingredients.Select(i => new IngredientListing(this, i)).ToList();
            ScaledServings = OriginalServings;
        }

        private Recipe Recipe { get; }

        public string Title => Recipe.Title;
        public List<IngredientListing> IngredientListings { get; }
        public int OriginalServings => Recipe.Servings;
        public int ScaledServings { get; set; }
        public TimeSpan CookTime => Recipe.CookTime;
        public List<string> Steps => Recipe.Steps;
    }
}
