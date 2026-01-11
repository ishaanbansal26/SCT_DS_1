using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPractice.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
