using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class ResumoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
