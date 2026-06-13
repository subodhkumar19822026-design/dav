using Microsoft.AspNetCore.Mvc;

namespace dav.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
