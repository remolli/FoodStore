namespace FoodStore.Models
{
    public class AutoCompleteSearchProductModel
    {
        public int id { get; set; }
        public string Title { get; set; }
    }

    public class IngredientSearchModel
    {
        public ResultsName[] results { get; set; }
    }

    public class GetIngredientInfoModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public EstimatedCost estimatedCost { get; set; }


    }

    public class EstimatedCost
    {
        public decimal value { get; set; }
        public string unit { get; set; }
    }

    public class ResultsTitle
    {
        public int id { get; set; }
        public string title { get; set; }
    }
    
    public class ResultsName
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
