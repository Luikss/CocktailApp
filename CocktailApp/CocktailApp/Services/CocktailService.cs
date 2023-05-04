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
                Name = " Alice Cocktail",
                GlassType = "Cocktail glass",
                Instructions = "Shake well, strain into a large cocktail glass.",
                ImageUrl = "https://www.thecocktaildb.com/images/media/drink/qyqtpv1468876144.jpg",
                Ingredients = new List<string>
                {
                    "Grenadine: 10ml",
                    "Orange juice: 10ml",
                    "Pineapple juice: 20ml",
                    "Cream: 40ml"
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
