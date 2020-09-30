using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using docspider.Controllers;

namespace docspider.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : docspiderControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
