using SQLite;

namespace Rezipe.Stores.UserDataStorage
{
    public class UserDataRecipe
    {
        [PrimaryKey]
        [AutoIncrement]
        public int ID { get; set; }
        public int RecipeID { get; set; }

        public int? ScaledServings { get; set; }
        public string IngredientsDone { get; set; }
        public string StepsDone { get; set; }
    }
}
