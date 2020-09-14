using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rezipe.Stores
{
    public class UserFavoriteDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        private readonly Func<Task> _dbChanged;

        public UserFavoriteDatabase(string dbPath, Func<Task> dbChanged)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserFavorite>().Wait();
            _dbChanged = dbChanged ?? throw new ArgumentNullException(nameof(dbChanged));
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
            var result = await _database.InsertAsync(favorite);
            await _dbChanged();
            return result;
        }

        public async Task<int> DeleteFavoriteAsync(UserFavorite favorite)
        {
            var result = await _database.DeleteAsync(favorite);
            await _dbChanged();
            return result;
        }
    }
}
