using Rezipe.Stores;
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

        private bool _isDone;
        public bool IsDone
        {
            get
            {
                return _isDone;
            }
            set
            {
                if (_isDone != value)
                {
                    _isDone = value;
                    RecipeDisplay.OnChanged();
                }
            }
        }

        public string Name => Ingredient.Name;
        public decimal Quantity => Ingredient.Quantity * RecipeDisplay.ScaledServings / RecipeDisplay.OriginalServings;
        public string Unit => Ingredient.Unit;
    }
}
