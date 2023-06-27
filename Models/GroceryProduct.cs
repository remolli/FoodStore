using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Globalization;

namespace FoodStore.Models
{
    public partial class GroceryProduct
    {
        public long id { get; set; }

        public string title { get; set; }
            
        public string[] breadcrumbs { get; set; }

        public string imageType { get; set; }

        public string[] badges { get; set; }

        public string[] importantBadges { get; set; }

        public double ingredientCount { get; set; }
            
        public string ingredientList { get; set; }

        public Ingredient[] ingredients { get; set; }

        public double likes { get; set; }

        public string aisle { get; set; }

        public Nutrition nutrition { get; set; }

        public decimal price { get; set; }

        public Servings servings { get; set; }

        public double spoonacularScore { get; set; }
    }

    public partial class Ingredient
    {
        public string description { get; set; }

        public string name { get; set; }

        public string safety_level { get; set; }
    }

    public partial class Nutrition
    {
        public Nutrient[] nutrients { get; set; }   
        public CaloricBreakdown caloricBreakdown { get; set; }
    }

    public partial class CaloricBreakdown
    {
        public double percentProtein { get; set; }
            
        public double percentFat { get; set; }

        public double percentCarbs { get; set; }
    }

    public partial class Nutrient
    {
        public string name { get; set; }

        public double amount { get; set; }

        public string unit { get; set; }

        public double percentOfDailyNeeds { get; set; }
    }

    public partial class Servings
    {
        public double number { get; set; }
        public string Size { get; set; }
        public string unit { get; set; }
    }
}
