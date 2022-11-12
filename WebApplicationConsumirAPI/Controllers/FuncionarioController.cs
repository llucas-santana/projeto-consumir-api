using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConsumirAPI.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Funcionario()
        {
            return View();
        }
    }
}
