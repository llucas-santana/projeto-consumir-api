using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConsumirAPI.Controllers
{
    public class FilmeController : Controller
    {
        public IActionResult Filme()
        {
            return View();
        }
    }
}
