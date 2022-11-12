using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConsumirAPI.Controllers
{
    public class IngressoController : Controller
    {
        public IActionResult Ingresso()
        {
            return View();
        }
    }
}
