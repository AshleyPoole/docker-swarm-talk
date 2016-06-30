using Microsoft.AspNetCore.Mvc;

namespace HelloDocker
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View(new HomeViewModel());
    }
}