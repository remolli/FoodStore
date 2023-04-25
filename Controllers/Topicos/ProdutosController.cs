using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers.Topicos
{
    public class ProdutosController : Controller
    {
        // GET: .../Produtos
        public IActionResult Index()
        {
            return View();
        }
    }
}
