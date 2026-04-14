using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.ViewComponents.Default
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
