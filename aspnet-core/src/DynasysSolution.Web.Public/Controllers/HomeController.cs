using Microsoft.AspNetCore.Mvc;
using DynasysSolution.Web.Controllers;

namespace DynasysSolution.Web.Public.Controllers
{
    public class HomeController : DynasysSolutionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}