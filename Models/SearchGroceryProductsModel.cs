using Newtonsoft.Json;

namespace FoodStore.Models
{
    public class SearchGroceryProductsModel
    {
        [JsonProperty("products")]
        public Product[] Products { get; set; }
        [JsonProperty("totalProducts")]
        public long TotalProducts { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("offset")]
        public long Offset { get; set; }
        [JsonProperty("number")]
        public long Number { get; set; }

        public class Product
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("imageType")]
            public string ImageType { get; set; }
        }
    }
}
