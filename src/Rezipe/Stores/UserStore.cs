using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rezipe.Stores
{
    public class UserStore
    {
        private readonly RecipeStore _recipeStore;
        private UserFavoriteDatabase _userFavoriteDatabase;

        public UserStore(RecipeStore recipeStore)
        {
            _recipeStore = recipeStore ?? throw new ArgumentNullException(nameof(recipeStore));
        }


        public UserFavoriteDatabase FavoritesDatabase
        {
            get
            {
                if (_userFavoriteDatabase == null)
                {
                    _userFavoriteDatabase =
                        new UserFavoriteDatabase(
                            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RezipeStore.db3"),
                            dbChanged: NotifyFavoritesChanged);
                }
                return _userFavoriteDatabase;
            }
        }

        public event Func<Task> FavoritesChanged;

        private async Task NotifyFavoritesChanged()
        {
            if (FavoritesChanged != null)
            {
                await FavoritesChanged?.Invoke();
            }
        }

        public async Task<bool> IsFavoriteRecipe(Recipe recipe)
        {
            if (recipe is null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }
            var allFavs = await FavoritesDatabase.GetFavoritesAsync();
            return allFavs.Any(f => f.RecipeID == recipe.ID);
        }

        public async Task<List<Recipe>> GetFavoriteRecipes()
        {
            var allFavs = await FavoritesDatabase.GetFavoritesAsync();
            return allFavs
                .Select(f => _recipeStore.GetRecipe(f.RecipeID))
                .ToList();
        }

        public async Task AddFavoriteRecipe(Recipe recipe)
        {
            if (recipe is null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            var allFavs = await FavoritesDatabase.GetFavoritesAsync();
            if (allFavs.All(f => f.RecipeID != recipe.ID))
            {
                await FavoritesDatabase.AddFavoriteAsync(new UserFavorite { RecipeID = recipe.ID });
            }
        }

        public async Task RemoveFavoriteRecipe(Recipe recipe)
        {
            if (recipe is null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }

            var allFavs = await FavoritesDatabase.GetFavoritesAsync();
            var matchingFavs = allFavs.Where(f => f.RecipeID == recipe.ID);
            foreach (var matchingFav in matchingFavs)
            {
                await FavoritesDatabase.DeleteFavoriteAsync(matchingFav);
            }
        }
    }
}
