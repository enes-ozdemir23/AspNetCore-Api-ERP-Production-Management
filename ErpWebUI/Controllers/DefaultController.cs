using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
