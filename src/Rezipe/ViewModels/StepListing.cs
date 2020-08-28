using System;

namespace Rezipe.ViewModels
{
    public class StepListing
    {
        public StepListing(RecipeDisplay recipeDisplay, string step)
        {
            if (step is null)
            {
                throw new ArgumentNullException(nameof(step));
            }
            RecipeDisplay = recipeDisplay;
            Step = step;
        }

        private RecipeDisplay RecipeDisplay { get; }
        public string Step { get; }

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
    }
}
