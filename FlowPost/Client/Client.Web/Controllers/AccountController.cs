using System.Web.Mvc;
using en.AndrewTorski.FlowPost.Logic.Core;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Input;

namespace en.AndrewTorski.FlowPost.Client.Web.Controllers
{
	/// <summary>
	///		
	/// </summary>
    public class AccountController : Controller
	{
		private readonly IFlowPostService _services;

		/// <summary>
		///		
		/// </summary>
	    public AccountController(IFlowPostService service)
		{
			_services = service;
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