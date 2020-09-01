using System;
using System.Collections.Generic;
using System.Linq;

namespace Rezipe.Stores
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

            new Recipe
            {
                ID = 2,
                Title= "Spaghetti squash burrito",
                Servings = 4,
                CookTime = new TimeSpan(hours: 1, minutes: 0, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="medium spaghetti squash, halved, seeds removed", Quantity=2m, Unit="", },
                    new Ingredient{ Name="extra-virgin olive oil", Quantity=2m, Unit="tbsp", },
                    new Ingredient{ Name="Kosher salt", Quantity=2m, Unit="pinch", },
                    new Ingredient{ Name="chili powder", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="cumin", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="Onion", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Garlic, minced", Quantity=2m, Unit="cloves", },
                    new Ingredient{ Name="Ground beef", Quantity=1m, Unit="lbs", },
                    new Ingredient{ Name="Taco seasoning mix", Quantity=1m, Unit="tbsp", },
                    new Ingredient{ Name="Freshly ground black pepper", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Can of black beans", Quantity=15m, Unit="oz", },
                    new Ingredient{ Name="Chopped cherry tomatoes", Quantity=1.5m, Unit="cup", },
                    new Ingredient{ Name="Can of corn, drained", Quantity=1m, Unit="cup", },
                    new Ingredient{ Name="Shredded Monterey Jack cheese", Quantity=1m, Unit="cup", },
                    new Ingredient{ Name="Shredded cheddar cheese", Quantity=0.5m, Unit="cup", },
                },
                Steps = new List<string>
                {
                    "Preheat oven to 400°F.",
                    "Squash: Drizzle cut sides of spaghetti squash with oil and season with salt, chili powder, and cumin.",
                    "Place cut side down on a large, rimmed baking sheet.",
                    "Roast until tender, 30 to 35 minutes.",
                    "Let cool slightly.",
                    "Using a fork, break up squash strands.",
                    "Filling: In a large skillet over medium heat, heat olive oil.",
                    "Add onion and cook until soft, about 5 minutes.",
                    "Stir in garlic and cook until fragrant, about 1 minute more.",
                    "Add ground beef until no longer pink, about 6 minutes.",
                    "Drain fat.",
                    "Stir in taco seasoning, then season to taste with salt and pepper.",
                    "Stir in black beans, cherry tomatoes, and corn.",
                    "Fill each spaghetti squash with beef mixture and top with cheeses.",
                    "Return to oven to melt cheese, 5 minutes.",
                },
            },

            new Recipe
            {
                ID = 3,
                Title= "Simple recipe",
                Servings = 1,
                CookTime = new TimeSpan(hours: 0, minutes: 5, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="water", Quantity=1m, Unit="cup", },
                    new Ingredient{ Name="instant noodles", Quantity=1m, Unit="pkg", },
                },
                Steps = new List<string>
                {
                    "Boil water",
                    "Add noodles",
                    "Stir",
                },
            },
        };

        public List<Recipe> GetRecipes()
        {
            return _recipes;
        }

        public Recipe GetRecipe(int id)
        {
            return _recipes.Single(r => r.ID == id);
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
