using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConsumirAPI.Controllers
{
    public class SalaController : Controller
    {
        public IActionResult Sala()
        {
            return View();
        }
    }
}
