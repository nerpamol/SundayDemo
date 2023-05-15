using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AmolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
