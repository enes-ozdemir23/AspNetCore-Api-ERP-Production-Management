using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
