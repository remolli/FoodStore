using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class ProductsController : Controller
    {
        API _api = new API();

        // GET: .../Products
        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                search = "pizza";
            }
            var requestDeserialized = await _api.GetSearchGroceryProducts(search);
            if (requestDeserialized == null)
            {
                return View("Home/Index");
            }
            return View(requestDeserialized);
        }
    }
}
