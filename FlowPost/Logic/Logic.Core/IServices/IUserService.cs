using en.AndrewTorski.FlowPost.Logic.ViewModels.Output;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
	/// <summary>
	///		Describes contract methods used with User Entity.
	/// </summary>
	public interface IUserService
	{
		/// <summary>
		///		Returns a User if his Id exists in the Database, NULL if not.
		/// </summary>
		/// <param name="id">
		///		User's Id.
		/// </param>
		/// <returns>
		///		SingleUserViewModel object correspondening to the User, or NULL if such parameter Id doesn't exist.
		/// </returns>
		SingleUserViewModel GetUserById(int id);
	}
}
