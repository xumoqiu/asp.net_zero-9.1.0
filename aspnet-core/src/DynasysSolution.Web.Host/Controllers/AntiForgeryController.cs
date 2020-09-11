using Microsoft.AspNetCore.Antiforgery;

namespace DynasysSolution.Web.Controllers
{
    public class AntiForgeryController : DynasysSolutionControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
