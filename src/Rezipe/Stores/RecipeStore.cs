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
                    new Ingredient{ Name="Kosher salt", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="Baking soda", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="Baking powder", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="Vanilla bean, split and scraped (optional)", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Butter (unsalted)", Quantity=3m, Unit="tbsp", },
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

            //new Recipe
            //{
            //    ID = 3,
            //    Title= "Simple recipe",
            //    Servings = 1,
            //    CookTime = new TimeSpan(hours: 0, minutes: 5, seconds: 0),
            //    Ingredients = new List<Ingredient>
            //    {
            //        new Ingredient{ Name="water", Quantity=1m, Unit="cup", },
            //        new Ingredient{ Name="instant noodles", Quantity=1m, Unit="pkg", },
            //    },
            //    Steps = new List<string>
            //    {
            //        "Boil water",
            //        "Add noodles",
            //        "Stir",
            //    },
            //},

            new Recipe
            {
                ID = 4,
                Title= "Ants in trees",
                Servings = 4,
                CookTime = new TimeSpan(hours: 1, minutes: 15, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="Bag of mung bean noodles", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Soy sauce", Quantity=2m, Unit="ounce", },
                    new Ingredient{ Name="Rice wine", Quantity=1m, Unit="tbsp", },
                    new Ingredient{ Name="Sambal chili paste or chili garlic sauce (optional)", Quantity=1m, Unit="tbsp", },
                    new Ingredient{ Name="Corn starch", Quantity=1m, Unit="tsp", },
                    new Ingredient{ Name="Ground pork", Quantity=1m, Unit="lbs", },
                    new Ingredient{ Name="Vegetable oil", Quantity=1m, Unit="tbsp", },
                    new Ingredient{ Name="Bag of frozen veggies or canned veggies, drained", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Green onions, chopped, divided", Quantity=4m, Unit="stalks", },
                },
                Steps = new List<string>
                {
                    "Prep noodles: Soak in enough hot water to cover for 20min. Then use scissors to cut into 4-inch pieces and drain in collander.",
                    "Sauce: Combine soy sauce, rice wine, and chili paste in a medium bowl and whisk until smooth. Add cornstarch and whisk until combined. Add pork and mix thoroughly. Set aside for 30min.",
                    "Heat up sauce pan and coat bottom with oil",
                    "Once the oil shimmers, add the meat mixture.",
                    "Stir constantly for 2 minutes, breaking the meat up into very small pieces.",
                    "Add 2/3 of the green onions and continue cooking and stirring until the meat is well browned and in very small pieces, approximately 2 minutes.",
                    "Add frozen or canned veggies",
                    "Reduce the heat to medium-high and add 1/2 cup water",
                    "Cook until reduced, approximately 3 minutes.",
                    "Slowly add handfuls of the noodles to the pan, tossing with the meat mixture until combined and the pieces of meat cling to the noodles and no liquid remains.",
                    "Serve immediately with the remaining green onions.",
                },
            },

            new Recipe
            {
                ID = 5,
                Title= "Frozen yogurt bark",
                Servings = 10,
                CookTime = new TimeSpan(hours: 4, minutes: 10, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="Full-fat unsweetened Greek yogurt", Quantity=2m, Unit="cup", },
                    new Ingredient{ Name="Honey", Quantity=3m, Unit="tbsp", },
                    new Ingredient{ Name="Vanilla extract", Quantity=1m, Unit="tsp", },
                    new Ingredient{ Name="Kosher salt", Quantity=1m, Unit="pinch", },
                    new Ingredient{ Name="Fresh raspberries, halved, or other fruit/berry", Quantity=0.5m, Unit="cup", },
                    new Ingredient{ Name="Chopped unsalted pistachios or other nut", Quantity=0.333333m, Unit="cup", },
                },
                Steps = new List<string>
                {
                    "Line a rimmed baking sheet with parchment or wax paper.",
                    "Using a rubber spatula, mix yogurt, honey, vanilla, and salt in a medium bowl until smooth.",
                    "Pour into the center of prepared sheet and spread to 1/4-inch thick.",
                    "Top with raspberries and pistachios.",
                    "Freeze until completely firm, about 4 hours. Break into pieces to serve.",
                },
            },

            new Recipe
            {
                ID = 6,
                Title= "Butter beer (non-alcoholic)",
                Servings = 4,
                CookTime = new TimeSpan(hours: 0, minutes: 15, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="Cans/bottles chilled cream soda", Quantity=6m, Unit="", },
                    new Ingredient{ Name="Imitation butter flavor", Quantity=1.5m, Unit="tbsp", },
                    new Ingredient{ Name="Heavy cream", Quantity=2m, Unit="cup", },
                    new Ingredient{ Name="Sugar", Quantity=2m, Unit="cup", },
                    new Ingredient{ Name="Vanilla extract", Quantity=2m, Unit="cup", },
                },
                Steps = new List<string>
                {
                    "Pour cream soda into glasses and add 1/2tsp of imitation butter flavor to each glass and lightly stir.",
                    "Make foam: In a large bowl, or the bowl of a standing mixer, whip the heavy cream on medium high speed for 3-4 minutes until it starts to thicken.",
                    "Add the sugar and continue whipping until very soft peaks begin to form, another 3-4 minutes (if you need to whip more or less, then be sure to do so, the times can vary quite a bit based on environment).",
                    "Stir in the vanilla and imitation butter (or clarified butter), then whip for another 30 seconds or so, until soft peaks form.",
                    "Spoon a generous portion of foam on top of each glass of butterbeer, mixing gently, if desired (or spoon the foam into the bottom of the glass and pour the butterbeer over the top). Serve immediately.",
                },
            },

            new Recipe
            {
                ID = 7,
                Title= "Chili (slow cooker)",
                Servings = 8,
                CookTime = new TimeSpan(hours: 6, minutes: 30, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="Vegetable oil", Quantity=3m, Unit="tbsp", },
                    new Ingredient{ Name="Onions, diced", Quantity=2m, Unit="", },
                    new Ingredient{ Name="Garlic cloves", Quantity=10m, Unit="", },
                    new Ingredient{ Name="Chili powder", Quantity=0.333333m, Unit="cup", },
                    new Ingredient{ Name="Cumin", Quantity=2m, Unit="tbsp", },
                    new Ingredient{ Name="Sausage filling (spicy or mild, as desired) or ground turkey", Quantity=2.5m, Unit="lbs", },
                    new Ingredient{ Name="Kosher salt", Quantity=1.5m, Unit="tsp", },
                    new Ingredient{ Name="Diced tomatoes (14oz can), drained", Quantity=4m, Unit="can", },
                    new Ingredient{ Name="Tomato sauce (14oz can)", Quantity=2m, Unit="can", },
                    new Ingredient{ Name="Light/dark kidney beans or black beans (14oz can), rinsed", Quantity=5m, Unit="can", },
                },
                Steps = new List<string>
                {
                    "Heat the oil in a large frying pan over medium heat until shimmering.",
                    "Add the onions, season with salt, and cook, stirring occasionally, until softened, about 8 minutes.",
                    "Add the garlic, chili powder, and cumin, stir to coat the vegetables, and cook until fragrant, about 1 minute.",
                    "Add the pork and measured salt and cook, breaking the meat into small pieces, until the meat is no longer pink, about 7 minutes.",
                    "Transfer the mixture to the slow cooker, add the diced tomatoes, tomato sauce, and beans, and stir to combine.",
                    "Cover and cook until the chili thickens and the flavors meld, about 8 hours on low or 6 hours on high.",
                    "Taste and season with salt as needed, and serve with the cheese and scallions.",
                },
            },

            new Recipe
            {
                ID = 8,
                Title= "Mozzarella stuffed meatballs (slow cooker)",
                Servings = 6,
                CookTime = new TimeSpan(hours: 3, minutes: 15, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="low moisture mozzarella cheese log", Quantity=8m, Unit="ounce", },
                    new Ingredient{ Name="ground beef", Quantity=1m, Unit="lbs", },
                    new Ingredient{ Name="Italian sausage filling (spicy or mild)", Quantity=1m, Unit="lbs", },
                    new Ingredient{ Name="bread crumbs", Quantity=1m, Unit="cup", },
                    new Ingredient{ Name="Grated parmesan cheese", Quantity=0.25m, Unit="cup", },
                    new Ingredient{ Name="Eggs", Quantity=2m, Unit="", },
                    new Ingredient{ Name="Whole milk", Quantity=0.5m, Unit="cup", },
                    new Ingredient{ Name="Chopped parsley", Quantity=0.5m, Unit="cup", },
                    new Ingredient{ Name="garlic powder", Quantity=0.5m, Unit="tsp", },
                    new Ingredient{ Name="black pepper", Quantity=1m, Unit="tsp", },
                    new Ingredient{ Name="Diced tomatoes (14oz can)", Quantity=2m, Unit="", },
                    new Ingredient{ Name="Tomato sauce (14oz can)", Quantity=2m, Unit="", },
                    new Ingredient{ Name="Cumin", Quantity=2m, Unit="tbsp", },
                    new Ingredient{ Name="Oregano", Quantity=2m, Unit="tbsp", },
                    new Ingredient{ Name="Salt", Quantity=1m, Unit="tsp", },
                    new Ingredient{ Name="Onions, diced", Quantity=2m, Unit="", },
                    new Ingredient{ Name="Mushrooms, sliced", Quantity=1m, Unit="cup", },
                    new Ingredient{ Name="Garlic, minced", Quantity=0.5m, Unit="cup", },
                },
                Steps = new List<string>
                {
                    "Cut low moisture mozzarella cheese into (~16) 3/4 inch cubes cubes. Store in refrigerator while preparing the meat.",
                    "In large mixing bowl combine ground meat, garlic powder, black pepper, bread crumbs, parmesan cheese, eggs, milk, parsley.",
                    "In slow cooker add tomato sauce ingredients (tomatoes, vegetables, spiced) and set on high",
                    "Remove cheese from refrigerator.",
                    "Roll golf ball sized balls with the meat mixture. Squish mozzarella cube into the center and pull the edges of the meat ball around it until it’s a new ball again.",
                    "Heat up pan with oil and sear meatballs on two sides to form a dark crust",
                    "Arrange meatballs in slow cooker and cover in tomato sauce.",
                    "Cook on high for 2 - 2.5 hours",
                },
            },

            new Recipe
            {
                ID = 9,
                Title= "Baked chicken fajitas",
                Servings = 4,
                CookTime = new TimeSpan(hours: 1, minutes: 0, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="Boneless skinless chicken breasts", Quantity=4m, Unit="cup", },
                    new Ingredient{ Name="Fajita seasoning", Quantity=2m, Unit="tsp", },
                    new Ingredient{ Name="Bell peppers in assorted colors, deseeded and thinly sliced", Quantity=2m, Unit="", },
                    new Ingredient{ Name="Onion (any type) peeled and sliced", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Olive oil", Quantity=2m, Unit="tbsp", },
                    new Ingredient{ Name="Mexican style shredded cheese", Quantity=0.5m, Unit="cup", },
                },
                Steps = new List<string>
                {
                    "Heat oven to 375F",
                    "Trim the chicken breasts then lay them in a single layer in a glass baking dish.",
                    "Sprinkle the taco seasoning over the top of the chicken breast to taste. ",
                    "Lay your thinly sliced onions and peppers on top of the chicken breast, spread out evenly over the top.",
                    "Drizzle the olive oil over the peppers and onions.",
                    "Sprinkle cheese over the top of the dish. ",
                    "Bake for 35-45 minutes or until chicken is cooked though and the juices run clear.",
                    "Remove from oven and cut chicken into strips, serve as desired with toppings",
                },
            },

            new Recipe
            {
                ID = 10,
                Title= "Baked lasagna with spinach",
                Servings = 8,
                CookTime = new TimeSpan(hours: 1, minutes: 30, seconds: 0),
                Ingredients = new List<Ingredient>
                {
                    new Ingredient{ Name="Spaghetti sauce", Quantity=6m, Unit="cup", },
                    new Ingredient{ Name="Lasagna noodles (box)", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Spinach", Quantity=2m, Unit="cup", },
                    new Ingredient{ Name="Large curd cottage cheese (16oz package)", Quantity=1m, Unit="", },
                    new Ingredient{ Name="Shredded mozzarella cheese", Quantity=1m, Unit="lbs", },
                },
                Steps = new List<string>
                {
                    "Bring a large pot of lightly salted water to a boil. Cook noodles in boiling water for 8 to 10 minutes, or until al dente; drain.",
                    "Preheat oven to 350F",
                    "Grease a 9x13 inch glass baking pan.",
                    "Line bottom of pan with three lasagna noodles.",
                    "Spread 1/3 of sauce over noodles.",
                    "Layer 1/3 of the cottage cheese over the sauce.",
                    "Layer spinach",
                    "Sprinkle 1/3 of the mozzarella over the cottage cheese. Repeat this layering process until all ingredients are used up.",
                    "Bake in the preheated oven for one hour.",
                    "Let stand for 10 minutes before serving.",
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
