using System;
using System.Collections.Generic;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Output
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
		public SingleUserViewModel(User user)
		{
			Id = user.Id;
			UserName = user.UserName;
			Age = DateTime.Now.Year - user.DateOfBirth.Year;
			Country = user.Country;
			//Posts = user.Posts as List<Post>;
			//Posts.OrderByDescending(post => post.DateTime);//Sort
			Groups = user.Groups as List<Group>;
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
		///		Country in which this User lives.
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		///		Number of topics, replies written by this user.
		/// </summary>
		public int NumberOfPosts { get; set; }

		/// <summary>
		///		List of descendingly sorted(by date) Posts written by this user.
		/// </summary>
		/// <remarks>
		///		Descendingly sorted, so that we obtain newer posts in the beginning of the List.
		/// </remarks>
		/* Consider: Will this include Topics as well? 
		 *		And if so, to what will the reference in Web Application redirect?
		 * Consider: Should it be documented that the count may be equal to zero?
		 */
		public List<Post> Posts { get; set; }

		/// <summary>
		///		List of Groups to which this User belongs.
		/// </summary>
		/*	Consider: Should it be considered that EVERYONE could have a view into what Groups a User belongs to?
		 */
		public List<Group> Groups { get; set; }
	}
}
