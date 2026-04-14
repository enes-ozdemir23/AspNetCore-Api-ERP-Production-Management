using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
