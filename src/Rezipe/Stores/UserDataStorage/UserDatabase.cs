using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rezipe.Stores.UserDataStorage
{
    public class UserDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public UserDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTablesAsync<UserFavorite, UserDataRecipe>().Wait();
        }

        public async Task<List<UserFavorite>> GetFavoritesAsync()
        {
            return await _database.Table<UserFavorite>().ToListAsync();
        }

        //public async Task<List<TodoFavorite>> GetFavoritesNotDoneAsync()
        //{
        //    return await _database.QueryAsync<TodoFavorite>("SELECT * FROM [TodoFavorite] WHERE [Done] = 0");
        //}

        //public async Task<TodoFavorite> GetFavoriteAsync(int id)
        //{
        //    return await _database.Table<TodoFavorite>().Where(i => i.ID == id).FirstOrDefaultAsync();
        //}

        public async Task<int> AddFavoriteAsync(UserFavorite favorite)
        {
            return await _database.InsertAsync(favorite);
        }

        public async Task<int> DeleteFavoriteAsync(UserFavorite favorite)
        {
            return await _database.DeleteAsync(favorite);
        }

        public async Task CreateOrUpdateUserDataRecipe(UserDataRecipe userDataRecipe)
        {
            await _database.InsertOrReplaceAsync(userDataRecipe);
        }

        public async Task<UserDataRecipe> GetOrCreateUserDataRecipeForRecipe(int recipeID)
        {
            var existingUserDataRecipe = await _database.Table<UserDataRecipe>().FirstOrDefaultAsync(udr => udr.RecipeID == recipeID);
            if (existingUserDataRecipe != null)
            {
                return existingUserDataRecipe;
            }

            var newUserDataRecipe = new UserDataRecipe()
            {
                RecipeID = recipeID,
            };
            await _database.InsertAsync(newUserDataRecipe);
            return newUserDataRecipe;
        }

        public async Task DeleteUserRecipe(UserDataRecipe userRecipe)
        {
            await _database.DeleteAsync(userRecipe);
        }
    }
}
