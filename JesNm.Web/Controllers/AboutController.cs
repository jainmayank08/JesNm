using System.Web.Mvc;

namespace JesNm.Web.Controllers
{
    public class AboutController : JesNmControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}