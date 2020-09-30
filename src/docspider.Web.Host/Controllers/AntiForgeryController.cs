using Microsoft.AspNetCore.Antiforgery;
using docspider.Controllers;

namespace docspider.Web.Host.Controllers
{
    public class AntiForgeryController : docspiderControllerBase
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
