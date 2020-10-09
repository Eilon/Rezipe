using Rezipe.Stores.RecipeStorage;
using System;

namespace Rezipe.ViewModels
{
    public class RecipeIngredientViewModel
    {
        public RecipeIngredientViewModel(RecipeViewModel recipeDisplay, RecipeIngredient ingredient, bool isDone)
        {
            if (ingredient is null)
            {
                throw new ArgumentNullException(nameof(ingredient));
            }
            RecipeDisplay = recipeDisplay;
            Ingredient = ingredient;
            _isDone = isDone;
        }

        private RecipeViewModel RecipeDisplay { get; }
        private RecipeIngredient Ingredient { get; }

        public bool IsDefault
        {
            get
            {
                return !IsDone;
            }
        }

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
