using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailApp
{
    public class CocktailData
    {
        public class Root
        {
            public List<Cocktail> Drinks { get; set; }
        }

        public class Cocktail
        {
            [JsonProperty("idDrink")]
            public string Id { get; set; }

            [JsonProperty("strDrink")]
            public string Name { get; set; }

            [JsonProperty("strDrinkThumb")]
            public string ThumbnailUrl { get; set; }
        }          
    }
}
