using System.Web.Mvc;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Input;

namespace en.AndrewTorski.FlowPost.Client.Web.Controllers
{
	/// <summary>
	///		
	/// </summary>
    public class AuthenticationController : Controller
    {
		/// <summary>
		///		
		/// </summary>
	    public AuthenticationController()
	    {
		    
	    }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

		[HttpPost]
		public ActionResult LogIn(LogInViewModel model)
		{
			return View();
		}
    }
}