using System.Security.Claims;
using System.Threading.Tasks;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Input;
using en.AndrewTorski.FlowPost.Persistance.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace en.AndrewTorski.FlowPost.Logic.Core.Services
{
	public class AccountService : IAccountService
	{
		//	READTHIS READTHIS READTHIS
		//	UserStore constructor expects a DbContext, which is why a concrecte class is referenced.
		//	Consider: solutions for concrete reference:
		//	1.	Implement custom UserStore accepting an interface to Data Access.
		//	2.	Create a base class which inherits from DbContext, contains abstract properties for used DbSets
		//		and which is later implemented by a concrete class and finally passed to this constructor.
		private readonly UserManager<User, int> _userManager; 
		private IAuthenticationManager _authenticationManager;

		/// <summary>
		///		Constructor initializing 
		/// </summary>
		/// <param name="dbContext"></param>
		public AccountService(FlowPostDataContext dbContext)
		{
			_userManager = new UserManager<User, int>(new UserStore<User, Role, int, Login, UserRole, UserClaim>(dbContext));
		}

		/// <summary>
		///		Register the contextualized Cookie Authentication Manager.
		/// </summary>
		/// <param name="authenticationManager"></param>
		/// <remarks>
		///		Should be used in every method in the Service that deals with cookies.
		/// </remarks>
		public void RegisterAuthenticationManager(IAuthenticationManager authenticationManager)
		{
			_authenticationManager = authenticationManager;
		}

		/// <summary>
		///		Sign in the user to the application.
		/// </summary>
		/// <param name="model"></param>
		/// <returns>
		///		True if User exists and has provided valid password.
		///		False if one of the given properties is invalid.
		/// </returns>
		public async Task<bool> LogIn(LogInViewModel model)
		{
			var user = await _userManager.FindAsync(model.UserName, model.Password);

			if (user == null)
			{
				return false;// display message - Invalid username or password. 
			}

			await SignIn(user);
			return true;
		}

		/// <summary>
		///		Sign out the current user from the application.
		/// </summary>
		public void LogOut()
		{
			_authenticationManager.SignOut("ApplicationCookie");
		}

		/// <summary>
		///		Register the user to the application.
		/// </summary>
		/// <param name="model">
		///		User provided data.
		/// </param>
		/// <returns>
		///		Result of registration.
		/// </returns>
		public async Task<IdentityResult> RegisterUser(RegisterViewModel model)
		{
			var user = new User
			{
				UserName = model.UserName,
				Email = model.Email,
				Country = model.Country,
				DateOfBirth = model.DateOfBirth,
			};
			
			var result = await _userManager.CreateAsync(user, model.Password);

			if (result.Succeeded)
			{
				await SignIn(user);
			}
			return result;
		}

		/// <summary>
		///		Sign in the user to the application middleware authentication.
		/// </summary>
		/// <param name="user">
		///		User to sign in.
		/// </param>
		/// <returns>
		///		User's claim.
		/// </returns>
		public async Task<ClaimsIdentity> SignIn(User user)
		{
			var identity = await _userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
			_authenticationManager.SignIn(identity);

			return identity;
		}
	}
}
