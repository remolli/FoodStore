using FoodStore.Models;
using Newtonsoft.Json;

namespace FoodStore.API
{
    public class API
    {
        HttpClient client;
        string apiKey;
        public API(string apiKey)
        {
            this.apiKey = apiKey;
            client = new HttpClient();
        }

        public async Task<AutoCompleteSearch[]> AutoCompleteSearch (string search, string topico)
        {
            HttpResponseMessage response;

            if (topico == "recipes")
            {
                response = await client.GetAsync(
                    "https://api.spoonacular.com/recipes/autocomplete?apiKey=" +
                    apiKey + "&number=5&query=" + search);
            }
            else if(topico == "ingredients")
            {
                response = await client.GetAsync(
                    "https://api.spoonacular.com/food/ingredients/autocomplete?apiKey=" +
                    apiKey + "&number=5&query=" + search);
            }
            else if(topico == "products")
            {
                response = await client.GetAsync(
                    "https://api.spoonacular.com/food/products/suggest?apiKey=" +
                    apiKey + "&number=5query=" + search);
            }
            else
            {
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();

            var autoCompleteContent = JsonConvert.DeserializeObject<AutoCompleteSearch[]>(content);

            return autoCompleteContent;
        }

    }
}
