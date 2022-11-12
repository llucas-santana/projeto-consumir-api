using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConsumirAPI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
