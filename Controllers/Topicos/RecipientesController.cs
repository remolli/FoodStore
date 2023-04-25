using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers.Topicos
{
    public class RecipientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
