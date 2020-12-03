using AspDotNetCore_DI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore_DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepo;

        public HomeController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_userRepo.GetAllUsers());
        }
    }
}