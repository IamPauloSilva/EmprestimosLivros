using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.Controllers
{
    public class EmprestimosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
