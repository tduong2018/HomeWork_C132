using Microsoft.AspNetCore.Mvc;

namespace myapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(){
            return View();
        }
    }
}