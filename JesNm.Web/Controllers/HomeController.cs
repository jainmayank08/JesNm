using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace JesNm.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : JesNmControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}