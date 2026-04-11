using Microsoft.AspNetCore.Mvc;

namespace ErpWebUI.ViewComponents.Default
{
    public class _PopularProductComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
