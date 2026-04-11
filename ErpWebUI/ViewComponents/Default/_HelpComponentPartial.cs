using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.ViewComponents.Default
{
    public class _HelpComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
