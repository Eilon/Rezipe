using System;

namespace Rezipe.ViewModels
{
    public class IngredientListing
    {
        public IngredientListing(RecipeDisplay recipeDisplay, Ingredient ingredient)
        {
            if (ingredient is null)
            {
                throw new ArgumentNullException(nameof(ingredient));
            }
            RecipeDisplay = recipeDisplay;
            Ingredient = ingredient;
        }

        private RecipeDisplay RecipeDisplay { get; }
        private Ingredient Ingredient { get; }

        public bool IsDone { get; set; }

        public string Name => Ingredient.Name;
        public decimal Quantity => Ingredient.Quantity * RecipeDisplay.ScaledServings / RecipeDisplay.OriginalServings;
        public string Unit => Ingredient.Unit;
    }
}
