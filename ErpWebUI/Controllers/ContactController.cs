using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
