namespace Services
{
    internal class CocktailService
    {
        private static readonly List<Cocktail> alcoholicCocktails = new()
        {
            new()
            {
                Name = " Rosemary Blue",
                GlassType = "Balloon Glass",
                Instructions = "1) Add the Bombay Sapphire, Blue Curacao, rosemary sprig and gently squeezed lemon wedge to a balloon glass. Swirl well to combine.\r\n2) Fill with cubed ice and top with the Fever-Tree Light Tonic Water.\r\n3) Gently fold with a bar spoon to mix.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/qwc5f91512406543.jpg",
                Ingredients = new List<string>
                {
                    "Gin: 50ml",
                    "Blue Curacao: 15ml",
                    "Tonic Water: 100ml",
                    "Garnish with Rosemary"
                }
            },
            new()
            {
                Name = " Winter Rita",
                GlassType = "Highball Glass",
                Instructions = "Salt rim. Combine all ingredients, shake with ice, and strain over fresh ice.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/fwpd0v1614006733.jpg",
                Ingredients = new List<string>
                {
                    "Tequila: 60ml",
                    "Campari: 7ml",
                    "Lime Juice: 21ml",
                    "Orange Juice: 15ml",
                    "Rosemary Syrup: 15ml",
                    "Salt: Dash",
                }
            },
            new()
            {
                Name = " Caribbean Boilermaker",
                GlassType = "Beer pilsner",
                Instructions = "Pour the Corona into an pint beer glass pour the rum into the beer.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/svsxsv1454511666.jpg",
                Ingredients = new List<string>
                {
                    "Corona: 1 bottle",
                    "Light rum: 1 shot"
                }
            },
            new()
            {
                Name = " Amaretto Sunrise",
                GlassType = "Collins Glass",
                Instructions = "Mix together the amaretto and orange juice. Pour into glass and then add the grenadine untill you see the sunrise.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/akcpsh1493070267.jpg",
                Ingredients = new List<string>
                {
                    "Amaretto: 10ml",
                    "Orange juice: 120ml",
                    "Grenadine: 3ml"
                }
            },
            new()
            {
                Name = " Martinez",
                GlassType = "Cocktail Glass",
                Instructions = "Add all ingredients to a mixing glass and fill with ice.\r\nStir until chilled, and strain into a chilled coupe glass.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/fs6kiq1513708455.jpg",
                Ingredients = new List<string>
                {
                    "Gin: 45ml",
                    "Sweet Vermouth: 45ml",
                    "Maraschino Liqueur: 1 teaspoon",
                    "Angostura Bitters: 2 dashes"
                }
            }
        };

        private static readonly List<Cocktail> nonAlcoholicCocktails = new()
        {
            new()
            {
                Name = " Apple Karate",
                GlassType = "Highball Glass",
                Instructions = "Place all ingredients in the blender jar - cover and whiz on medium speed until well blended. Pour in one tall, 2 medium or 3 small glasses and drink up.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/syusvw1468876634.jpg",
                Ingredients = new List<string>
                {
                    "Apple juice: 2 cups",
                    "Carrot: 1 large"
                }
            },
            new()
            {
                Name = " Iced Coffee",
                GlassType = "Coffee mug",
                Instructions = "Mix together until coffee and sugar is dissolved. Add milk. Shake well. Using a blender or milk shake maker produces a very foamy drink. Serve in coffee mug.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/ytprxy1454513855.jpg",
                Ingredients = new List<string>
                {
                    "Coffee: 1/4 cup instant",
                    "Sugar: 1/4 cup",
                    "Water: 1/4 cup hot",
                    "Milk: 1/4 cup cold"
                }
            },
            new()
            {
                Name = " Banana Strawberry Shake",
                GlassType = "Highball Glass",
                Instructions = "Blend all together in a blender until smooth.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/vqquwx1472720634.jpg",
                Ingredients = new List<string>
                {
                    "Strawberries: 1/2 lb frozen",
                    "Banana: 1 frozen",
                    "Yoghurt: 1 cup plain",
                    "Milk: 1 cup",
                    "Honey: to taste"
                }
            },
            new()
            {
                Name = " Limeade",
                GlassType = "Highball Glass",
                Instructions = "In a large glass, put the lime juice and sugar, and stir well. Add cold seltzer water to fill. Put the lime peels in the glass. Drink. Repeat until limes or soda run out.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/5jdp5r1487603680.jpg",
                Ingredients = new List<string>
                {
                    "Lime: Juice of 1",
                    "Sugar: 1 tablespoon",
                    "Soda water: seltzer water",
                    "Lime peel: 1"
                }
            },
            new()
            {
                Name = " Kill the cold Smoothie",
                GlassType = "Highball Glass",
                Instructions = "Juice ginger and lemon and add it to hot water. You may add cardomom.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/7j1z2e1487603414.jpg",
                Ingredients = new List<string>
                {
                    "Ginger: 1 inch",
                    "Lemon: 1/4",
                    "Water: 1 cup hot"
                }
            }
        };

        public static List<Cocktail> GetAlcoholicCoctails()
        {
            return alcoholicCocktails;
        }

        public static List<Cocktail> GetNonAlcoholicCoctails()
        {
            return nonAlcoholicCocktails;
        }
    }
}
