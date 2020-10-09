using Rezipe.Stores.RecipeStorage;
using Rezipe.Stores.UserDataStorage;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Rezipe.ViewModels
{
    public class RecipeViewModel
    {
        public RecipeViewModel(Recipe originalRecipe, UserDataRecipe userRecipe)
        {
            OriginalRecipe = originalRecipe ?? throw new ArgumentNullException(nameof(originalRecipe));
            UserRecipe = userRecipe ?? throw new ArgumentNullException(nameof(userRecipe));

            var ingredientsDoneIndices = StringToIntArray(UserRecipe.IngredientsDone);
            Ingredients = OriginalRecipe.Ingredients.Select((i, ix) => new RecipeIngredientViewModel(this, i, ingredientsDoneIndices.Contains(ix))).ToList();

            var stepsDoneIndices = StringToIntArray(UserRecipe.StepsDone);
            Steps = OriginalRecipe.Steps.Select((s, ix) => new RecipeStepViewModel(this, s, stepsDoneIndices.Contains(ix))).ToList();
        }

        public Recipe OriginalRecipe { get; }
        private UserDataRecipe UserRecipe { get; }

        public string Title => OriginalRecipe.Title;
        public int OriginalServings => OriginalRecipe.Servings;
        public TimeSpan CookTime => OriginalRecipe.CookTime;

        public int ScaledServings
        {
            get => UserRecipe.ScaledServings ?? OriginalServings;
            set
            {
                if (ScaledServings != value)
                {
                    UserRecipe.ScaledServings = value;
                    OnChanged();
                }
            }
        }

        public void ResetServings()
        {
            UserRecipe.ScaledServings = null;
            OnChanged();
        }

        public bool IsDefault
        {
            get
            {
                return OriginalServings == ScaledServings &&
                    Ingredients.All(i => i.IsDefault) &&
                    Steps.All(i => i.IsDefault);
            }
        }

        public List<RecipeIngredientViewModel> Ingredients { get; }
        public List<RecipeStepViewModel> Steps { get; }

        public void OnChanged()
        {
            UserRecipe.ScaledServings = ScaledServings;
            UserRecipe.IngredientsDone = IntArrayToString(GetDoneIndices(Ingredients, i => i.IsDone));
            UserRecipe.StepsDone = IntArrayToString(GetDoneIndices(Steps, s => s.IsDone));

            Changed?.Invoke(this, EventArgs.Empty);
        }

        private int[] GetDoneIndices<TItem>(List<TItem> items, Func<TItem, bool> itemDonePredicate)
        {
            var doneIndices = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                if (itemDonePredicate(items[i]))
                {
                    doneIndices.Add(i);
                }
            }
            return doneIndices.ToArray();
        }

        public event EventHandler Changed;

        public static string IntArrayToString(int[] intArray)
        {
            return string.Join(",", intArray.Select(i => i.ToString(CultureInfo.InvariantCulture)));
        }

        public static int[] StringToIntArray(string intArrayString)
        {
            return intArrayString?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i, CultureInfo.InvariantCulture)).ToArray() ?? Array.Empty<int>();
        }
    }
}
