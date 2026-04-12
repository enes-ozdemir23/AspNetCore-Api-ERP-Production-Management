using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.ViewComponents.Default
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
