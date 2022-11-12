using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationConsumirAPI.Models;

namespace WebApplicationConsumirAPI.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cliente()
        {
            return View();
        }
    }
}
