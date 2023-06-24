using FoodStore.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FoodStore.API
{
    public class API
    {
        RestClient client;
        string apiKey;
        public API(string apiKey)
        {
            this.apiKey = apiKey;
            var options = new RestClientOptions("https://api.spoonacular.com");
            client = new RestClient(options);
        }
        public async Task<GroceryProduct> GetGroceryProduct(string id)
        {
            var request = new RestRequest($"/food/products/{id}");
            request.AddHeader("apiKey", "3a422ff82d024ed489e4d0b9ca4bcb59");
            var requestDeserialized = await client.GetAsync<GroceryProduct>(request);
            return requestDeserialized;
        }
        public async Task<SearchGroceryProductsModel> GetSearchGroceryProducts(string search)
        {
            var request = new RestRequest($"/food/products/search?query={search}");
            request.AddHeader("apiKey", "3a422ff82d024ed489e4d0b9ca4bcb59");
            var requestDeserialized = await client.GetAsync<SearchGroceryProductsModel>(request);
            return requestDeserialized;
        }
    }
}
