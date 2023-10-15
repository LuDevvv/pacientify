using Microsoft.AspNetCore.Mvc;

namespace PacientifyWeb.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
