using FoodStore.Controllers.Topicos;
using FoodStore.Models;
using Microsoft.AspNetCore.SignalR;
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

        //
        // <------ INGREDIENTS ------->
        //

        public async Task<AutoCompleteSearch[]> AutoCompleteSearchIngredients(string search)
        {
            HttpResponseMessage response;

            response = await client.GetAsync(
                "https://api.spoonacular.com/food/ingredients/autocomplete?apiKey=" +
                apiKey + "&number=25&query=" + search);


            var content = await response.Content.ReadAsStringAsync();

            var autoCompleteContent = JsonConvert.DeserializeObject<AutoCompleteSearch[]>(content);

            return autoCompleteContent;
        }

        public async Task IngredientSearch(string search)
        {

        }
        
        GetIngredientInfo

        //
        // <------ PRODUCTS ------->
        //

        public async Task<AutoCompleteSearch[]> AutoCompleteSearchProducts(string search)
        {
            HttpResponseMessage response;

            response = await client.GetAsync(
                "https://api.spoonacular.com/food/products/suggest?apiKey=" +
                apiKey + "&number=25query=" + search);

            var content = await response.Content.ReadAsStringAsync();

            var autoCompleteContent = JsonConvert.DeserializeObject<AutoCompleteSearch[]>(content);

            return autoCompleteContent;
        }

        ProductSearch

        GetProductInfo

    }
}
