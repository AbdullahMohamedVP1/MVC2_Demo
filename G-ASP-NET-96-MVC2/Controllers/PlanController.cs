using Microsoft.AspNetCore.Mvc;

namespace G_ASP_NET_96_MVC2.Controllers
{
    public class PlanController : Controller
    {
        public IActionResult IndexTest()
        {
            return View(); //return view with same action name [Views/Plan/IndexTest.cshtml]
            //return View("ViewTEST");
            //return View(new Member() {});
            //return View("ViewTEST", new Member() { });
        }
    }
}
