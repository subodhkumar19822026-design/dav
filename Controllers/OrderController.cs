using Microsoft.AspNetCore.Mvc;

namespace dav.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
