using FoodStore.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

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
        public async Task<IActionResult> Product(string id)
        {
            if (id == null)
            {
                return View("Index");
            }
            var requestDeserialized = await _api.GetGroceryProduct(id);
            if (requestDeserialized == null)
            {
                return View("Index");
            }
            return View(requestDeserialized);
        }
    }
}
