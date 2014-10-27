using System;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.User.Output
{
	/// <summary>
	///		Encapsulates basic information(name, country, age, groups, his posts[topics and replies]) about a single user for simple displaying.
	/// </summary>
	public class SingleUserViewModel
	{
		/// <summary>
		///		Initializes the object with data from User entity. 
		/// </summary>
		/// <param name="user">
		///		User for which we create a ViewModel.
		/// </param>
		public SingleUserViewModel(Entities.User user)
		{
			Id = user.Id;
			UserName = user.UserName;
			Age = DateTime.Now.Year - user.DateOfBirth.Year;
			DateOfRegistration = user.DateOfRegistration;
			Country = user.Country;
		}
		/// <summary>
		///		Id of the User.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		User name of the User.
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		///		Calculated age.
		/// </summary>
		public int Age { get; set; }

		/// <summary>
		///		Date of the user's registration.
		/// </summary>
		public DateTime DateOfRegistration { get; set; }

		/// <summary>
		///		Country in which this User lives.
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		///		Number of topics, replies written by this user.
		/// </summary>
		public int NumberOfPosts { get; set; }
	}
}
