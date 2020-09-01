using Rezipe.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rezipe.ViewModels
{
    public class RecipeDisplay
    {
        private int _scaledServings;

        public RecipeDisplay(Recipe recipe)
        {
            Recipe = recipe ?? throw new ArgumentNullException(nameof(recipe));

            IngredientListings = Recipe.Ingredients.Select(i => new IngredientListing(this, i)).ToList();
            Steps = Recipe.Steps.Select(s => new StepListing(this, s)).ToList();
            ScaledServings = OriginalServings;
        }

        private Recipe Recipe { get; }

        public string Title => Recipe.Title;
        public List<IngredientListing> IngredientListings { get; }
        public int OriginalServings => Recipe.Servings;
        public int ScaledServings
        {
            get => _scaledServings;
            set
            {
                if (_scaledServings != value)
                {
                    _scaledServings = value;
                    OnChanged();
                }
            }
        }

        public TimeSpan CookTime => Recipe.CookTime;
        public List<StepListing> Steps { get; }

        public void OnChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Changed;
    }
}
