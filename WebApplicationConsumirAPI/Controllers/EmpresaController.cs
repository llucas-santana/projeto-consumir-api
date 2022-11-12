using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConsumirAPI.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Empresa()
        {
            return View();
        }
    }
}
