using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal class CocktailService
    {
        private static List<Cocktail> cocktails = new()
        {
        };

        public static List<Cocktail> GetAllCoctails()
        {
            return cocktails;
        }

        public static Cocktail GetCoctail(string CocktailName)
        {
            return cocktails.Where(_cocktail => _cocktail.Name == CocktailName).FirstOrDefault();
        }

        public static List<Cocktail> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizedCocktails = cocktails.OrderBy(item => rnd.Next());

            return randomizedCocktails.Take(3).ToList();
        }
    }
}
