using Rezipe.Stores.RecipeStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rezipe.Stores.UserDataStorage
{
    public class UserDataStore
    {
        private readonly RecipeStore _recipeStore;
        private UserDatabase _userFavoriteDatabase;

        public UserDataStore(RecipeStore recipeStore)
        {
            _recipeStore = recipeStore ?? throw new ArgumentNullException(nameof(recipeStore));
        }


        private UserDatabase UserDatabase
        {
            get
            {
                if (_userFavoriteDatabase == null)
                {
                    var userDbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RezipeStore.db3");
                    _userFavoriteDatabase = new UserDatabase(userDbPath);
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

        /// <summary>
        /// Get or create user-specific view of a recipe.
        /// </summary>
        public async Task<UserDataRecipe> GetUserDataRecipe(Recipe recipe)
        {
            return await UserDatabase.GetOrCreateUserDataRecipeForRecipe(recipe.ID);
        }

        /// <summary>
        /// Insert or update a user-specific view of a recipe.
        /// </summary>
        public async Task CreateOrUpdateUserDataRecipe(UserDataRecipe userRecipe)
        {
            await UserDatabase.CreateOrUpdateUserDataRecipe(userRecipe);
        }

        /// <summary>
        /// Remove a user-specific view of a recipe. This usually happens because all the values are
        /// the default value so there's no need to store anything.
        /// </summary>
        public async Task DeleteUserRecipe(UserDataRecipe userRecipe)
        {
            await UserDatabase.DeleteUserRecipe(userRecipe);
        }

        public async Task<bool> IsFavoriteRecipe(Recipe recipe)
        {
            if (recipe is null)
            {
                throw new ArgumentNullException(nameof(recipe));
            }
            var allFavs = await UserDatabase.GetFavoritesAsync();
            return allFavs.Any(f => f.RecipeID == recipe.ID);
        }

        public async Task<List<Recipe>> GetFavoriteRecipes()
        {
            var allFavs = await UserDatabase.GetFavoritesAsync();
            return allFavs
                .Select(f => _recipeStore.GetRecipe(f.RecipeID))
                .ToList();
        }

        public async Task AddFavoriteRecipe(int recipeID)
        {
            var allFavs = await UserDatabase.GetFavoritesAsync();
            if (allFavs.All(f => f.RecipeID != recipeID))
            {
                await UserDatabase.AddFavoriteAsync(new UserFavorite { RecipeID = recipeID });
                await NotifyFavoritesChanged();
            }
        }

        public async Task RemoveFavoriteRecipe(int recipeID)
        {
            var allFavs = await UserDatabase.GetFavoritesAsync();
            var matchingFavs = allFavs.Where(f => f.RecipeID == recipeID);
            foreach (var matchingFav in matchingFavs)
            {
                await UserDatabase.DeleteFavoriteAsync(matchingFav);
                await NotifyFavoritesChanged();
            }
        }
    }
}
