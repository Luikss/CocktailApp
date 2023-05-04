using Nancy.Json;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CocktailApp
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<CocktailData> GetCocktailData(string query)
        {
            CocktailData cocktailData = null;

            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    cocktailData = JsonConvert.DeserializeObject<CocktailData>(content);
                    return cocktailData;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return cocktailData;
        }
    }
}
