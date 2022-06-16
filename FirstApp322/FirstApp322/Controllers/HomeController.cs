using Microsoft.AspNetCore.Mvc;

namespace FirstApp322.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewResult result = new ViewResult();

            //return Json(
            //    new
            //    {
            //        name="lorem",
            //        age=45,
            //    });
            //return Ok("okay");
            //return File("","");
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
