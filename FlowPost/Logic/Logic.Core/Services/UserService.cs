using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Logic.Core.Services
{
	/// <summary>
	///		Exposes functionalities associtated with retiving and manipulating data around User entity.
	/// </summary>
	public class UserService : IUserService
	{
		private readonly IFlowPostDataContext _dataContext;

		/// <summary>
		///		Dependency injection constructor.
		/// </summary>
		/// <param name="dataContext"></param>
		public UserService(IFlowPostDataContext dataContext)
		{
			_dataContext = dataContext;
		}

		/// <summary>
		///     Returns a User if his Id exists in the Database, NULL if not.
		/// </summary>
		/// <param name="id">
		///     User's Id.
		/// </param>
		/// <returns>
		///     SingleUserViewModel object correspondening to the User, or NULL if such Id doesn't exist.
		/// </returns>
		public SingleUserViewModel GetUserById(int id)
		{
			var userToFind = _dataContext.Users
				/*.Include("Groups")
				.Include("Posts")*/
				.SingleOrDefault(u => u.Id == id);
			//	First check if such User exists.
			if (userToFind == null)
			{
				return null;
			}

			/*	Initialize the result model's properties with provided constructor which takes a User instance 
				Note: Posts are ordered descendingly inside the constructor.	*/
			var resultModel = new SingleUserViewModel(userToFind);

			return resultModel;
		}
	}
}