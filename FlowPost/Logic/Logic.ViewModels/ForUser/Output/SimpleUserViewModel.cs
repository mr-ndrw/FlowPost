using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output
{
	/// <summary>
	///		Contains very simple data about the user.
	/// </summary>
	/// <remarks>
	///		Used in a context where we need to create a reference to a user using his Id and UserName.
	/// </remarks>
	public class SimpleUserViewModel
	{
		/// <summary>
		///		Initializes the object with data from User.
		/// </summary>
		/// <param name="user">
		///		User for which we obtain ViewModel.
		/// </param>
		public SimpleUserViewModel(User user)
		{
			Id = user.Id;
			UserName = user.UserName;
		}

		/// <summary>
		///		Id of the user.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Name of the user.
		/// </summary>
		public string UserName { get; set; }
	}
}
