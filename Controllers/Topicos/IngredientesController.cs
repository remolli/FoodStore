using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers.Topicos
{
    public class IngredientesController : Controller
    {
        // GET: .../Ingredientes
        public IActionResult Index()
        {
            return View();
        }
    }
}
