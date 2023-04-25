using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers.Topicos
{
    public class VinhosController : Controller
    {
        // GET: .../Vinhos
        public IActionResult Index()
        {
            return View();
        }
    }
}
