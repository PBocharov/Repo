using System.Web.Mvc;

namespace MentorIT.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.IsAuthenticated = User.Identity.IsAuthenticated;
            base.OnActionExecuting(filterContext);
        }

        
    }
}