using Microsoft.AspNetCore.Mvc;

namespace PacientifyWeb.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
