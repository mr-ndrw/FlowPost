using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.Output;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Logic.Core.Services
{
	/// <summary>
	///     Exposes
	/// </summary>
	public class UserService : IUserService
	{
		private readonly FlowPostDataContext _dataContext;


		public UserService(FlowPostDataContext dataContext)
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
			//	First check if such User exists.
			//	Consider: Integrate somehow to include a fast Include of User's Posts?
			User userToFind = _dataContext.Users
				.Include("Groups")
				.Include("Posts")
				.SingleOrDefault(u => u.Id == id);

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