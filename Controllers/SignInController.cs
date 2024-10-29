using Microsoft.AspNetCore.Mvc;

namespace GymProject.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index() 
        { 
            return View(); 
        }

        public IActionResult Cliente()
        {
            return View();
        }

        public IActionResult PersonalTrainer()
        {
            return View();
        }
    }

}
