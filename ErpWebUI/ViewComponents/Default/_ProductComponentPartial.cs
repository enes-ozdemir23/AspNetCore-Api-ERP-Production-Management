using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.ViewComponents.Default
{
    public class _ProductComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
