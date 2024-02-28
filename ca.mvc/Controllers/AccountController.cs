using Microsoft.AspNetCore.Mvc;

namespace ca.mvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }
    }
}
