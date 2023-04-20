using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailApp
{
    public class CocktailData
    {
        //https://www.youtube.com/watch?v=uDaIArfc5LM
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Drink
        {
            [JsonProperty("idDrink")]
            public string idDrink { get; set; }

            [JsonProperty("strDrink")]
            public string strDrink { get; set; }

            [JsonProperty("strDrinkAlternate")]
            public object strDrinkAlternate { get; set; }

            [JsonProperty("strTags")]
            public object strTags { get; set; }

            [JsonProperty("strVideo")]
            public object strVideo { get; set; }

            [JsonProperty("strCategory")]
            public string strCategory { get; set; }

            [JsonProperty("strIBA")]
            public object strIBA { get; set; }

            [JsonProperty("strAlcoholic")]
            public string strAlcoholic { get; set; }

            [JsonProperty("strGlass")]
            public string strGlass { get; set; }

            [JsonProperty("strInstructions")]
            public string strInstructions { get; set; }

            [JsonProperty("strDrinkThumb")]
            public string strDrinkThumb { get; set; }

            [JsonProperty("strIngredient1")]
            public string strIngredient1 { get; set; }

            [JsonProperty("strIngredient2")]
            public string strIngredient2 { get; set; }

            [JsonProperty("strIngredient3")]
            public string strIngredient3 { get; set; }

            [JsonProperty("strIngredient4")]
            public object strIngredient4 { get; set; }

            [JsonProperty("strIngredient5")]
            public object strIngredient5 { get; set; }

            [JsonProperty("strIngredient6")]
            public object strIngredient6 { get; set; }

            [JsonProperty("strIngredient7")]
            public object strIngredient7 { get; set; }

            [JsonProperty("strIngredient8")]
            public object strIngredient8 { get; set; }

            [JsonProperty("strIngredient9")]
            public object strIngredient9 { get; set; }

            [JsonProperty("strIngredient10")]
            public object strIngredient10 { get; set; }

            [JsonProperty("strIngredient11")]
            public object strIngredient11 { get; set; }

            [JsonProperty("strIngredient12")]
            public object strIngredient12 { get; set; }

            [JsonProperty("strIngredient13")]
            public object strIngredient13 { get; set; }

            [JsonProperty("strIngredient14")]
            public object strIngredient14 { get; set; }

            [JsonProperty("strIngredient15")]
            public object strIngredient15 { get; set; }

            [JsonProperty("strMeasure1")]
            public string strMeasure1 { get; set; }

            [JsonProperty("strMeasure2")]
            public string strMeasure2 { get; set; }

            [JsonProperty("strMeasure3")]
            public string strMeasure3 { get; set; }

            [JsonProperty("strMeasure4")]
            public object strMeasure4 { get; set; }

            [JsonProperty("strMeasure5")]
            public object strMeasure5 { get; set; }

            [JsonProperty("strMeasure6")]
            public object strMeasure6 { get; set; }

            [JsonProperty("strMeasure7")]
            public object strMeasure7 { get; set; }

            [JsonProperty("strMeasure8")]
            public object strMeasure8 { get; set; }

            [JsonProperty("strMeasure9")]
            public object strMeasure9 { get; set; }

            [JsonProperty("strMeasure10")]
            public object strMeasure10 { get; set; }

            [JsonProperty("strMeasure11")]
            public object strMeasure11 { get; set; }

            [JsonProperty("strMeasure12")]
            public object strMeasure12 { get; set; }

            [JsonProperty("strMeasure13")]
            public object strMeasure13 { get; set; }

            [JsonProperty("strMeasure14")]
            public object strMeasure14 { get; set; }

            [JsonProperty("strMeasure15")]
            public object strMeasure15 { get; set; }

            [JsonProperty("strImageSource")]
            public object strImageSource { get; set; }

            [JsonProperty("strImageAttribution")]
            public object strImageAttribution { get; set; }

            [JsonProperty("strCreativeCommonsConfirmed")]
            public string strCreativeCommonsConfirmed { get; set; }

            [JsonProperty("dateModified")]
            public string dateModified { get; set; }
        }

        public class Root
        {
            [JsonProperty("drinks")]
            public List<Drink> drinks { get; set; }
        }


    }
}
