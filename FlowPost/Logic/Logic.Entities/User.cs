using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Represents a User of the FlowPost forum.
	/// </summary>
	/// <remarks>
	///     No Entity Framework specific annotations were used.
	/// </remarks>
	public class User : IdentityUser<int, Login, UserRole, Claim>
	{
		#region Properties

		/*
		 * Imporatant notice:
		 * Inherited class IndentityUser, already contains such properties as UserName, Email, UserId and Password.
		 */

		/// <summary>
		///     User's Date of birth.
		/// </summary>
		public DateTime DateOfBirth { get; set; }

		/// <summary>
		///     User's country.
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		///     Total number of messages posted by the User.
		/// </summary>
		public int NumberOfPosts { get; set; }

		#endregion

		#region NavigationProperties

		/// <summary>
		///     Collection of Groups to which the User belongs.
		/// </summary>
		public ICollection<Group> Groups { get; set; }

		/// <summary>
		///     Collection of Groups which this User moderates.
		/// </summary>
		public ICollection<Group> ModeratedGroups { get; set; }

		/// <summary>
		///     Collection of banishments issued for this User.
		/// </summary>
		public ICollection<Ban> Bans { get; set; }

		/// <summary>
		///     Collection of Posts created by this User.
		/// </summary>
		public ICollection<Post> Posts { get; set; }

		/// <summary>
		///     Collection of Reports comitted against this User.
		/// </summary>
		public ICollection<UserReport> UserReports { get; set; }

		/// <summary>
		///     Collection of Categories moderated by the User.
		/// </summary>
		public ICollection<Category> ModeratedCategories { get; set; }

		/// <summary>
		///     Collection of Categories which User can view.
		/// </summary>
		public ICollection<Category> ViewedCategories { get; set; }

		/// <summary>
		///     Collection of Categories which User can view and Edit.
		/// </summary>
		/// <remarks>
		///		It is implied that if a User can edit(post, remove own posts etc), he/she most certainly can view the Category.
		/// </remarks>
		public ICollection<Category> EditedCategories { get; set; }

		/// <summary>
		///		Messages sent by this User.
		/// </summary>
		public ICollection<Message> SentMessages { get; set; }

		/// <summary>
		///		Messages received by this User.
		/// </summary>
		public ICollection<Message> ReceivedMessages { get; set; }

		#endregion //NavigationProperties
	}
}