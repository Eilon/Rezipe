using System;
using System.Collections.Generic;
using System.Linq;

namespace Rezipe.Stores.RecipeStorage
{
    public class RecipeStore
    {
        private readonly List<Recipe> _recipes = new List<Recipe>
        {
            new Recipe
            {
                ID = 1,
                Title= "Buttermilk waffles",
                Servings = 4,
                CookTime = new TimeSpan(hours: 0, minutes: 30, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="All-purpose flour", Quantity=1.33333m, Unit="cup", },
                    new RecipeIngredient{ Name="Sugar", Quantity=0.375m, Unit="cup", },
                    new RecipeIngredient{ Name="Kosher salt", Quantity=0.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="Baking soda", Quantity=0.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="Baking powder", Quantity=0.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="Vanilla bean, split and scraped (optional)", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Butter (unsalted)", Quantity=3m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Cultured low-fat buttermilk", Quantity=14m, Unit="oz", },
                    new RecipeIngredient{ Name="Egg whites (large)", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Vanilla extract", Quantity=1m, Unit="tsp", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Set waffle iron to 4/5 heat" },
                    new RecipeStep { Step = "All dry ingredients: In a large bowl, combine flour, powdered sugar, salt, baking soda, baking powder" },
                    new RecipeStep { Step = "Optional: Add the scrapings of one large vanilla bean, mixing by hand until the seeds are well dispersed." },
                    new RecipeStep { Step = "All wet ingredients: Add buttermilk, melted butter, egg whites, and vanilla extract and whisk until smooth." },
                    new RecipeStep { Step = "Recommended: Use non-stick spray on iron before each waffle is poured" },
                    new RecipeStep { Step = "Use 3/4 - 1 cup to scoop each half waffle into iron" },
                    new RecipeStep { Step = "Close lid and cook until waffle is golden brown but still steaming." },
                },
            },

            new Recipe
            {
                ID = 2,
                Title= "Spaghetti squash burrito",
                Servings = 4,
                CookTime = new TimeSpan(hours: 1, minutes: 0, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="medium spaghetti squash, halved, seeds removed", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="extra-virgin olive oil", Quantity=2m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Kosher salt", Quantity=2m, Unit="pinch", },
                    new RecipeIngredient{ Name="chili powder", Quantity=0.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="cumin", Quantity=0.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="Onion", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Garlic, minced", Quantity=2m, Unit="cloves", },
                    new RecipeIngredient{ Name="Ground beef", Quantity=1m, Unit="lbs", },
                    new RecipeIngredient{ Name="Taco seasoning mix", Quantity=1m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Freshly ground black pepper", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Can of black beans", Quantity=15m, Unit="oz", },
                    new RecipeIngredient{ Name="Chopped cherry tomatoes", Quantity=1.5m, Unit="cup", },
                    new RecipeIngredient{ Name="Can of corn, drained", Quantity=1m, Unit="cup", },
                    new RecipeIngredient{ Name="Shredded Monterey Jack cheese", Quantity=1m, Unit="cup", },
                    new RecipeIngredient{ Name="Shredded cheddar cheese", Quantity=0.5m, Unit="cup", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Preheat oven to 400°F." },
                    new RecipeStep { Step = "Squash: Drizzle cut sides of spaghetti squash with oil and season with salt, chili powder, and cumin." },
                    new RecipeStep { Step = "Place cut side down on a large, rimmed baking sheet." },
                    new RecipeStep { Step = "Roast until tender, 30 to 35 minutes." },
                    new RecipeStep { Step = "Let cool slightly." },
                    new RecipeStep { Step = "Using a fork, break up squash strands." },
                    new RecipeStep { Step = "Filling: In a large skillet over medium heat, heat olive oil." },
                    new RecipeStep { Step = "Add onion and cook until soft, about 5 minutes." },
                    new RecipeStep { Step = "Stir in garlic and cook until fragrant, about 1 minute more." },
                    new RecipeStep { Step = "Add ground beef until no longer pink, about 6 minutes." },
                    new RecipeStep { Step = "Drain fat." },
                    new RecipeStep { Step = "Stir in taco seasoning, then season to taste with salt and pepper." },
                    new RecipeStep { Step = "Stir in black beans, cherry tomatoes, and corn." },
                    new RecipeStep { Step = "Fill each spaghetti squash with beef mixture and top with cheeses." },
                    new RecipeStep { Step = "Return to oven to melt cheese, 5 minutes." },
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
            //    Steps = new List<RecipeStep>
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
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Bag of mung bean noodles", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Soy sauce", Quantity=2m, Unit="ounce", },
                    new RecipeIngredient{ Name="Rice wine", Quantity=1m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Sambal chili paste or chili garlic sauce (optional)", Quantity=1m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Corn starch", Quantity=1m, Unit="tsp", },
                    new RecipeIngredient{ Name="Ground pork", Quantity=1m, Unit="lbs", },
                    new RecipeIngredient{ Name="Vegetable oil", Quantity=1m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Bag of frozen veggies or canned veggies, drained", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Green onions, chopped, divided", Quantity=4m, Unit="stalks", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Prep noodles: Soak in enough hot water to cover for 20min. Then use scissors to cut into 4-inch pieces and drain in collander." },
                    new RecipeStep { Step = "Sauce: Combine soy sauce, rice wine, and chili paste in a medium bowl and whisk until smooth. Add cornstarch and whisk until combined. Add pork and mix thoroughly. Set aside for 30min." },
                    new RecipeStep { Step = "Heat up sauce pan and coat bottom with oil" },
                    new RecipeStep { Step = "Once the oil shimmers, add the meat mixture." },
                    new RecipeStep { Step = "Stir constantly for 2 minutes, breaking the meat up into very small pieces." },
                    new RecipeStep { Step = "Add 2/3 of the green onions and continue cooking and stirring until the meat is well browned and in very small pieces, approximately 2 minutes." },
                    new RecipeStep { Step = "Add frozen or canned veggies" },
                    new RecipeStep { Step = "Reduce the heat to medium-high and add 1/2 cup water" },
                    new RecipeStep { Step = "Cook until reduced, approximately 3 minutes." },
                    new RecipeStep { Step = "Slowly add handfuls of the noodles to the pan, tossing with the meat mixture until combined and the pieces of meat cling to the noodles and no liquid remains." },
                    new RecipeStep { Step = "Serve immediately with the remaining green onions." },
                },
            },

            new Recipe
            {
                ID = 5,
                Title= "Frozen yogurt bark",
                Servings = 10,
                CookTime = new TimeSpan(hours: 4, minutes: 10, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Full-fat unsweetened Greek yogurt", Quantity=2m, Unit="cup", },
                    new RecipeIngredient{ Name="Honey", Quantity=3m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Vanilla extract", Quantity=1m, Unit="tsp", },
                    new RecipeIngredient{ Name="Kosher salt", Quantity=1m, Unit="pinch", },
                    new RecipeIngredient{ Name="Fresh raspberries, halved, or other fruit/berry", Quantity=0.5m, Unit="cup", },
                    new RecipeIngredient{ Name="Chopped unsalted pistachios or other nut", Quantity=0.333333m, Unit="cup", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Line a rimmed baking sheet with parchment or wax paper." },
                    new RecipeStep { Step = "Using a rubber spatula, mix yogurt, honey, vanilla, and salt in a medium bowl until smooth." },
                    new RecipeStep { Step = "Pour into the center of prepared sheet and spread to 1/4-inch thick." },
                    new RecipeStep { Step = "Top with raspberries and pistachios." },
                    new RecipeStep { Step = "Freeze until completely firm, about 4 hours. Break into pieces to serve." },
                },
            },

            new Recipe
            {
                ID = 6,
                Title= "Butter beer (non-alcoholic)",
                Servings = 4,
                CookTime = new TimeSpan(hours: 0, minutes: 15, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Cans/bottles chilled cream soda", Quantity=6m, Unit="", },
                    new RecipeIngredient{ Name="Imitation butter flavor", Quantity=1.5m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Heavy cream", Quantity=2m, Unit="cup", },
                    new RecipeIngredient{ Name="Sugar", Quantity=2m, Unit="cup", },
                    new RecipeIngredient{ Name="Vanilla extract", Quantity=2m, Unit="cup", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Pour cream soda into glasses and add 1/2tsp of imitation butter flavor to each glass and lightly stir." },
                    new RecipeStep { Step = "Make foam: In a large bowl, or the bowl of a standing mixer, whip the heavy cream on medium high speed for 3-4 minutes until it starts to thicken." },
                    new RecipeStep { Step = "Add the sugar and continue whipping until very soft peaks begin to form, another 3-4 minutes (if you need to whip more or less, then be sure to do so, the times can vary quite a bit based on environment)." },
                    new RecipeStep { Step = "Stir in the vanilla and imitation butter (or clarified butter), then whip for another 30 seconds or so, until soft peaks form." },
                    new RecipeStep { Step = "Spoon a generous portion of foam on top of each glass of butterbeer, mixing gently, if desired (or spoon the foam into the bottom of the glass and pour the butterbeer over the top). Serve immediately." },
                },
            },

            new Recipe
            {
                ID = 7,
                Title= "Chili (slow cooker)",
                Servings = 8,
                CookTime = new TimeSpan(hours: 6, minutes: 30, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Vegetable oil", Quantity=3m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Onions, diced", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Garlic cloves", Quantity=10m, Unit="", },
                    new RecipeIngredient{ Name="Chili powder", Quantity=0.333333m, Unit="cup", },
                    new RecipeIngredient{ Name="Cumin", Quantity=2m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Sausage filling (spicy or mild, as desired) or ground turkey", Quantity=2.5m, Unit="lbs", },
                    new RecipeIngredient{ Name="Kosher salt", Quantity=1.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="Diced tomatoes (14oz can), drained", Quantity=4m, Unit="can", },
                    new RecipeIngredient{ Name="Tomato sauce (14oz can)", Quantity=2m, Unit="can", },
                    new RecipeIngredient{ Name="Light/dark kidney beans or black beans (14oz can), rinsed", Quantity=5m, Unit="can", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Heat the oil in a large frying pan over medium heat until shimmering." },
                    new RecipeStep { Step = "Add the onions, season with salt, and cook, stirring occasionally, until softened, about 8 minutes." },
                    new RecipeStep { Step = "Add the garlic, chili powder, and cumin, stir to coat the vegetables, and cook until fragrant, about 1 minute." },
                    new RecipeStep { Step = "Add the pork and measured salt and cook, breaking the meat into small pieces, until the meat is no longer pink, about 7 minutes." },
                    new RecipeStep { Step = "Transfer the mixture to the slow cooker, add the diced tomatoes, tomato sauce, and beans, and stir to combine." },
                    new RecipeStep { Step = "Cover and cook until the chili thickens and the flavors meld, about 8 hours on low or 6 hours on high." },
                    new RecipeStep { Step = "Taste and season with salt as needed, and serve with the cheese and scallions." },
                },
            },

            new Recipe
            {
                ID = 8,
                Title= "Mozzarella stuffed meatballs (slow cooker)",
                Servings = 6,
                CookTime = new TimeSpan(hours: 3, minutes: 15, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="low moisture mozzarella cheese log", Quantity=8m, Unit="ounce", },
                    new RecipeIngredient{ Name="ground beef", Quantity=1m, Unit="lbs", },
                    new RecipeIngredient{ Name="Italian sausage filling (spicy or mild)", Quantity=1m, Unit="lbs", },
                    new RecipeIngredient{ Name="bread crumbs", Quantity=1m, Unit="cup", },
                    new RecipeIngredient{ Name="Grated parmesan cheese", Quantity=0.25m, Unit="cup", },
                    new RecipeIngredient{ Name="Eggs", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Whole milk", Quantity=0.5m, Unit="cup", },
                    new RecipeIngredient{ Name="Chopped parsley", Quantity=0.5m, Unit="cup", },
                    new RecipeIngredient{ Name="garlic powder", Quantity=0.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="black pepper", Quantity=1m, Unit="tsp", },
                    new RecipeIngredient{ Name="Diced tomatoes (14oz can)", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Tomato sauce (14oz can)", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Cumin", Quantity=2m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Oregano", Quantity=2m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Salt", Quantity=1m, Unit="tsp", },
                    new RecipeIngredient{ Name="Onions, diced", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Mushrooms, sliced", Quantity=1m, Unit="cup", },
                    new RecipeIngredient{ Name="Garlic, minced", Quantity=0.5m, Unit="cup", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Cut low moisture mozzarella cheese into (~16) 3/4 inch cubes cubes. Store in refrigerator while preparing the meat." },
                    new RecipeStep { Step = "In large mixing bowl combine ground meat, garlic powder, black pepper, bread crumbs, parmesan cheese, eggs, milk, parsley." },
                    new RecipeStep { Step = "In slow cooker add tomato sauce ingredients (tomatoes, vegetables, spiced) and set on high" },
                    new RecipeStep { Step = "Remove cheese from refrigerator." },
                    new RecipeStep { Step = "Roll golf ball sized balls with the meat mixture. Squish mozzarella cube into the center and pull the edges of the meat ball around it until it’s a new ball again." },
                    new RecipeStep { Step = "Heat up pan with oil and sear meatballs on two sides to form a dark crust" },
                    new RecipeStep { Step = "Arrange meatballs in slow cooker and cover in tomato sauce." },
                    new RecipeStep { Step = "Cook on high for 2 - 2.5 hours" },
                },
            },

            new Recipe
            {
                ID = 9,
                Title= "Baked chicken fajitas",
                Servings = 4,
                CookTime = new TimeSpan(hours: 1, minutes: 0, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Boneless skinless chicken breasts", Quantity=4m, Unit="cup", },
                    new RecipeIngredient{ Name="Fajita seasoning", Quantity=2m, Unit="tsp", },
                    new RecipeIngredient{ Name="Bell peppers in assorted colors, deseeded and thinly sliced", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Onion (any type) peeled and sliced", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Olive oil", Quantity=2m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Mexican style shredded cheese", Quantity=0.5m, Unit="cup", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Heat oven to 375F" },
                    new RecipeStep { Step = "Trim the chicken breasts then lay them in a single layer in a glass baking dish." },
                    new RecipeStep { Step = "Sprinkle the taco seasoning over the top of the chicken breast to taste. " },
                    new RecipeStep { Step = "Lay your thinly sliced onions and peppers on top of the chicken breast, spread out evenly over the top." },
                    new RecipeStep { Step = "Drizzle the olive oil over the peppers and onions." },
                    new RecipeStep { Step = "Sprinkle cheese over the top of the dish. " },
                    new RecipeStep { Step = "Bake for 35-45 minutes or until chicken is cooked though and the juices run clear." },
                    new RecipeStep { Step = "Remove from oven and cut chicken into strips, serve as desired with toppings" },
                },
            },

            new Recipe
            {
                ID = 10,
                Title= "Baked lasagna with spinach",
                Servings = 8,
                CookTime = new TimeSpan(hours: 1, minutes: 30, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Spaghetti sauce", Quantity=6m, Unit="cup", },
                    new RecipeIngredient{ Name="Lasagna noodles (box)", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Spinach", Quantity=2m, Unit="cup", },
                    new RecipeIngredient{ Name="Large curd cottage cheese (16oz package)", Quantity=1m, Unit="", },
                    new RecipeIngredient{ Name="Shredded mozzarella cheese", Quantity=1m, Unit="lbs", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Bring a large pot of lightly salted water to a boil. Cook noodles in boiling water for 8 to 10 minutes, or until al dente; drain." },
                    new RecipeStep { Step = "Preheat oven to 350F" },
                    new RecipeStep { Step = "Grease a 9x13 inch glass baking pan." },
                    new RecipeStep { Step = "Line bottom of pan with three lasagna noodles." },
                    new RecipeStep { Step = "Spread 1/3 of sauce over noodles." },
                    new RecipeStep { Step = "Layer 1/3 of the cottage cheese over the sauce." },
                    new RecipeStep { Step = "Layer spinach" },
                    new RecipeStep { Step = "Sprinkle 1/3 of the mozzarella over the cottage cheese. Repeat this layering process until all ingredients are used up." },
                    new RecipeStep { Step = "Bake in the preheated oven for one hour." },
                    new RecipeStep { Step = "Let stand for 10 minutes before serving." },
                },
            },

            new Recipe
            {
                ID = 11,
                Title= "Beef bourguignon (slow cooker)",
                Servings = 6,
                CookTime = new TimeSpan(hours: 9, minutes: 30, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Slice of bacon", Quantity=5m, Unit="", },
                    new RecipeIngredient{ Name="Boneless beef chuck", Quantity=3m, Unit="lbs", },
                    new RecipeIngredient{ Name="Red cooking wine", Quantity=1m, Unit="cup", },
                    new RecipeIngredient{ Name="Chicken broth", Quantity=2m, Unit="cup", },
                    new RecipeIngredient{ Name="Tomato sauce", Quantity=0.5m, Unit="cup", },
                    new RecipeIngredient{ Name="Soy sauce", Quantity=0.25m, Unit="cup", },
                    new RecipeIngredient{ Name="Flour", Quantity=0.25m, Unit="cup", },
                    new RecipeIngredient{ Name="Garlic cloves, finely chopped", Quantity=3m, Unit="", },
                    new RecipeIngredient{ Name="Thyme, finely chopped", Quantity=2m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Medium carrots, sliced", Quantity=5m, Unit="", },
                    new RecipeIngredient{ Name="Baby potatoes", Quantity=1m, Unit="lbs", },
                    new RecipeIngredient{ Name="Mushrooms", Quantity=8m, Unit="oz", },
                    new RecipeIngredient{ Name="Chopped parsley for garnish", Quantity=1m, Unit="", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "In a large skillet cook bacon over medium high heat until crisp." },
                    new RecipeStep { Step = "Put bacon in slow cooker." },
                    new RecipeStep { Step = "Salt and pepper the beef and add to the skillet and sear on each side for 2-3 minutes." },
                    new RecipeStep { Step = "Transfer beef to the slow cooker." },
                    new RecipeStep { Step = "Add the red wine to the skillet scraping down the brown bits on the side." },
                    new RecipeStep { Step = "Allow it to simmer and reduce and slowly add chicken broth, and tomato sauce, and soy sauce." },
                    new RecipeStep { Step = "Slowly whisk in the flour." },
                    new RecipeStep { Step = "Add the sauce to the slow cooker." },
                    new RecipeStep { Step = "Add garlic, thyme, carrots, potatoes, and mushrooms to the slow cooker." },
                    new RecipeStep { Step = "Stir and cook on low until beef is tender on low for 8-10 hours or on high for 6-8 hours." },
                    new RecipeStep { Step = "Garnish with fresh parley and serve with mashed potatoes if desired." },
                },
            },

            new Recipe
            {
                ID = 12,
                Title= "Buttermilk pancakes",
                Servings = 4,
                CookTime = new TimeSpan(hours: 0, minutes: 45, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="All-purpose flour", Quantity=2m, Unit="cup", },
                    new RecipeIngredient{ Name="Baking powder", Quantity=1m, Unit="tsp", },
                    new RecipeIngredient{ Name="Baking soda", Quantity=0.5m, Unit="tsp", },
                    new RecipeIngredient{ Name="Kosher salt", Quantity=1m, Unit="tsp", },
                    new RecipeIngredient{ Name="Sugar", Quantity=1m, Unit="tbsp", },
                    new RecipeIngredient{ Name="Eggs (separated)", Quantity=2m, Unit="", },
                    new RecipeIngredient{ Name="Buttermilk", Quantity=20m, Unit="oz", },
                    new RecipeIngredient{ Name="Butter, melted (unsalted)", Quantity=4m, Unit="tbsp", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "In large bowl whisk together flour, baking powder, baking soda, salt, and sugar." },
                    new RecipeStep { Step = "In medium bowl whish egg whites until stiff peaks form." },
                    new RecipeStep { Step = "In another large bowl whish egg yolks and buttermilk." },
                    new RecipeStep { Step = "In last bowl slowly add melted butter while whisking." },
                    new RecipeStep { Step = "In last bowl fold in the egg whites until combined." },
                    new RecipeStep { Step = "Pour wet ingredients into dry ingredients until combined." },
                    new RecipeStep { Step = "Heat non-stick skillet to medium, melt butter in it and spread with paper towel." },
                    new RecipeStep { Step = "Use 1/4 cup to place 3-4 pancakes in the pan." },
                    new RecipeStep { Step = "When bubbles form on top (about 2 minutes), flip and cook other side (another 2 minutes)." },
                },
            },

            new Recipe
            {
                ID = 13,
                Title= "Piña colada (alcoholic)",
                Servings = 2,
                CookTime = new TimeSpan(hours: 0, minutes: 15, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Ice", Quantity=1.5m, Unit="cup", },
                    new RecipeIngredient{ Name="Pineapple, diced, frozen", Quantity=0.5m, Unit="cup", },
                    new RecipeIngredient{ Name="Pineapple juice", Quantity=2m, Unit="oz", },
                    new RecipeIngredient{ Name="Coconut cream", Quantity=2m, Unit="oz", },
                    new RecipeIngredient{ Name="White rum", Quantity=1.5m, Unit="oz", },
                    new RecipeIngredient{ Name="Dark rum", Quantity=1m, Unit="oz", },
                    new RecipeIngredient{ Name="Pineapple slices (garnish, optional)", Quantity=2m, Unit="", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Place all ingredients (except garnish) in blender and blend until smooth." },
                    new RecipeStep { Step = "Serve in a glass with optional garnish and a straw." },
                },
            },

            new Recipe
            {
                ID = 14,
                Title= "Hard boiled eggs",
                Servings = 6,
                CookTime = new TimeSpan(hours: 0, minutes: 15, seconds: 0),
                Ingredients = new List<RecipeIngredient>
                {
                    new RecipeIngredient{ Name="Eggs", Quantity=6m, Unit="", },
                },
                Steps = new List<RecipeStep>
                {
                    new RecipeStep { Step = "Place eggs in a pot and cover with cold water by about 1 inch" },
                    new RecipeStep { Step = "Boil over medium-high heat" },
                    new RecipeStep { Step = "Cover, then remove from heat and let cool for 10 minutes." },
                    new RecipeStep { Step = "Cool eggs in ice water, if needed" },
                    new RecipeStep { Step = "To peel eggs, crack on a hard surface, then insert a spoon into cracked opening to remove large pieces of shell." },
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
}
