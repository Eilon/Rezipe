using System;
using System.Collections.Generic;

namespace Rezipe.Stores.RecipeStorage
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Servings { get; set; }
        public TimeSpan CookTime { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
        public List<RecipeStep> Steps { get; set; }
    }
}
