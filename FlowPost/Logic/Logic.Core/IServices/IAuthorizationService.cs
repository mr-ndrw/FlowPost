using System.Security.Claims;
using System.Threading.Tasks;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Input;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
	public interface IAuthorizationService
	{
		/// <summary>
		///		Register the contextualized Cookie Authentication Manager.
		/// </summary>
		/// <param name="authenticationManager"></param>
		/// <remarks>
		///		Should be used in every method in the Service that deals with cookies.
		/// </remarks>
		void RegisterAuthenticationManager(IAuthenticationManager authenticationManager);

		/// <summary>
		///		Sign in the user to the application.
		/// </summary>
		/// <param name="model"></param>
		/// <returns>
		///		True if User exists and has provided valid password.
		///		False if one of the given properties is invalid.
		/// </returns>
		Task<bool> LogIn(LogInViewModel model);


		/// <summary>
		///		Sign out the current user from the application.
		/// </summary>
		void LogOut();

		/// <summary>
		///		Register the user to the application.
		/// </summary>
		/// <param name="model">
		///		User provided data.
		/// </param>
		/// <returns>
		///		Result of registration.
		/// </returns>
		Task<IdentityResult> RegisterUser(RegisterViewModel model);

		/// <summary>
		///		Sign in the user to the application middleware authentication.
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		Task<ClaimsIdentity> SignIn(User user);
	}
}
