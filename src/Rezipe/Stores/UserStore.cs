using System;
using System.Collections.Generic;
using System.Linq;

namespace Rezipe.Stores
{
    public class UserStore
    {
        private List<int> _favorites = new List<int>();
        private readonly RecipeStore _recipeStore;

        public UserStore(RecipeStore recipeStore)
        {
            _recipeStore = recipeStore;
        }

        public EventHandler FavoritesChanged;

        private void OnFavoritesChanged()
        {
            FavoritesChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool IsFavoriteRecipe(Recipe recipe)
        {
            if (recipe is null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            return _favorites.Contains(recipe.ID);
        }

        public List<Recipe> GetFavoriteRecipes()
        {
            return _favorites
                .Select(i => _recipeStore.GetRecipe(i))
                .ToList();
        }

        public void AddFavoriteRecipe(Recipe recipe)
        {
            if (recipe is null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            if (!_favorites.Contains(recipe.ID))
            {
                _favorites.Add(recipe.ID);
                OnFavoritesChanged();
            }
        }

        public void RemoveFavoriteRecipe(Recipe recipe)
        {
            if (recipe is null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            if (_favorites.Contains(recipe.ID))
            {
                _favorites.Remove(recipe.ID);
                OnFavoritesChanged();
            }
        }
    }
}
