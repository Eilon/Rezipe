using SQLite;

namespace Rezipe.Stores.UserDataStorage
{
    public sealed class UserFavorite
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; }
        public int RecipeID { get; set; }
    }
}
