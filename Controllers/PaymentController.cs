using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
