using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers.Topicos
{
    public class RecipientesController : Controller
    {
        // GET: .../Recipientes
        public IActionResult Index()
        {
            return View();
        }
    }
}
