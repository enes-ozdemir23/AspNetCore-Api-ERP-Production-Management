using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
