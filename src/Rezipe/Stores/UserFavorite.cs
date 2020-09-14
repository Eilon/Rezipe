using SQLite;

namespace Rezipe.Stores
{
    public sealed class UserFavorite
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; }
        public int RecipeID { get; set; }
    }
}
