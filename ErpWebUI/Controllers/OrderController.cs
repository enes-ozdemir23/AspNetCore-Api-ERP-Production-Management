using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
