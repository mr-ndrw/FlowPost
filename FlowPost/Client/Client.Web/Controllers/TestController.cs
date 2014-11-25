using System.Web.Mvc;

namespace en.AndrewTorski.FlowPost.Client.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult TopicView()
        {
            return View();
        }

	    public ActionResult PartialPost()
	    {
		    return View("_PartialPost");
	    }
    }
}