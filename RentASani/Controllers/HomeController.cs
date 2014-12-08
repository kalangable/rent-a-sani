using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Rent-a-Sani";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trabalho de Tecnologia de Progamação II";

            return View();
        }
    }
}
