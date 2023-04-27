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

        public async Task<AutoCompleteSearch[]> AutoCompleteSearch (string search)
        {
            var response = await client.GetAsync(
                "https://api.spoonacular.com/recipes/autocomplete?apiKey=" +
                apiKey + "&number=10&query=" + search);

            var content = await response.Content.ReadAsStringAsync();

            var autoCompleteContent = JsonConvert.DeserializeObject<AutoCompleteSearch[]>(content);

            return autoCompleteContent;
        }
    }
}
