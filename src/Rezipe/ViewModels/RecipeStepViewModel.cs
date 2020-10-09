using Rezipe.Stores.RecipeStorage;
using System;

namespace Rezipe.ViewModels
{
    public class RecipeStepViewModel
    {
        public RecipeStepViewModel(RecipeViewModel recipeDisplay, RecipeStep step, bool isDone)
        {
            if (step is null)
            {
                throw new ArgumentNullException(nameof(step));
            }
            RecipeDisplay = recipeDisplay;
            RecipeStep = step;
            _isDone = isDone;
        }

        private RecipeViewModel RecipeDisplay { get; }
        private RecipeStep RecipeStep { get; }

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

        public string Step => RecipeStep.Step;
    }
}
