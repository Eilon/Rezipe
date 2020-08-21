using System;
using System.Collections.Generic;
using System.Text;

namespace Rezipe
{
    public class RecipeStore
    {
        private List<Recipe> _recipes = new List<Recipe>
        {
            new Recipe
            {
                ID = 1,
                Title= "Buttermilk waffles",
                Servings = 4,
                CookTime = new TimeSpan(hours: 0, minutes: 30, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="All-purpose flour", Quantity=1.33333m, Unit="cup", },
                    new Ingredient{ Name="Sugar", Quantity=0.375m, Unit="cup", },
                    new Ingredient{ Name="Kosher salt", Quantity=0.5m, Unit="tbsp", },
                    new Ingredient{ Name="Baking soda", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="Baking powder", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="Vanilla bean, split and scraped (optional)", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Cultured low-fat buttermilk", Quantity=14m, Unit="oz", },
                    new Ingredient{ Name="Egg whites (large)", Quantity=2m, Unit="", },
                    new Ingredient{ Name="Vanilla extract", Quantity=1m, Unit="tsp", },
                },
                Steps = new List<string>
                {
                    "Set waffle iron to 4/5 heat",
                    "All dry ingredients: In a large bowl, combine flour, powdered sugar, salt, baking soda, baking powder",
                    "Optional: Add the scrapings of one large vanilla bean, mixing by hand until the seeds are well dispersed.",
                    "All wet ingredients: Add buttermilk, melted butter, egg whites, and vanilla extract and whisk until smooth.",
                    "Recommended: Use non-stick spray on iron before each waffle is poured",
                    "Use 3/4 - 1 cup to scoop each half waffle into iron",
                    "Close lid and cook until waffle is golden brown but still steaming.",
                },
            },
        };

        public List<Recipe> GetRecipes()
        {
            return _recipes;
        }

    }

    public class Recipe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Servings { get; set; }
        public TimeSpan CookTime { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

    }

    public class Ingredient
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
    }
}
