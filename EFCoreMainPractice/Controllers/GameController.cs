using Microsoft.AspNetCore.Mvc;

namespace EFCoreMainPractice.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
