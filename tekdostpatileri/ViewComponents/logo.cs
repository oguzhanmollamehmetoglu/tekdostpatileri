using Microsoft.AspNetCore.Mvc;

namespace tekdostpatileri.ViewComponents
{
    public class logo: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
