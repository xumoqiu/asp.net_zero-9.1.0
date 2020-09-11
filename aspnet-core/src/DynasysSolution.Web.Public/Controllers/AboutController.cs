using Microsoft.AspNetCore.Mvc;
using DynasysSolution.Web.Controllers;

namespace DynasysSolution.Web.Public.Controllers
{
    public class AboutController : DynasysSolutionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}