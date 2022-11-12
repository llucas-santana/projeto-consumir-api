using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConsumirAPI.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult Venda()
        {
            return View();
        }

        public IActionResult DetalhesDoPedido()
        {
            return View();
        }
    }
}
