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
		 * Imporatant note:
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
		public virtual ICollection<Group> Groups { get; set; }

		/// <summary>
		///     Collection of Groups which this User moderates.
		/// </summary>
		public virtual ICollection<Group> ModeratedGroups { get; set; }

		/// <summary>
		///     Collection of banishments issued for this User.
		/// </summary>
		public virtual ICollection<Ban> Bans { get; set; }

		/// <summary>
		///     Collection of Posts created by this User.
		/// </summary>
		public virtual ICollection<Post> Posts { get; set; }

		/// <summary>
		///     Collection of Reports comitted against this User.
		/// </summary>
		public virtual ICollection<UserReport> UserReports { get; set; }

		/// <summary>
		///     Collection of Categories moderated by the User.
		/// </summary>
		public virtual ICollection<Category> ModeratedCategories { get; set; }

		/// <summary>
		///     Collection of Categories which User can view.
		/// </summary>
		public virtual ICollection<Category> CanViewCategories { get; set; }

		/// <summary>
		///     Collection of Categories which User can view and Edit.
		/// </summary>
		public virtual ICollection<Category> CanViewAndEditCategories { get; set; }

		#endregion //NavigationProperties

		//comment
	}
}