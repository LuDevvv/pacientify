using Microsoft.AspNetCore.Mvc;

namespace PacientifyWeb.Controllers
{
    public class LaboratoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
