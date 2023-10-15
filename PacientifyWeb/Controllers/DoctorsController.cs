using Microsoft.AspNetCore.Mvc;

namespace PacientifyWeb.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
