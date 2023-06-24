using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class ProductsController : Controller
    {
        // GET: .../Products
        public IActionResult Index()
        {
            return View();
        }
    }
}
