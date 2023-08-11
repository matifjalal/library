using Microsoft.AspNetCore.Mvc;

namespace LiabraryMnagementS.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
