using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Represents a Group of Users.
	/// </summary>
	public class Group
	{
		#region Properties

		/// <summary>
		///     Group's unique identifier which serves as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Group's name.
		/// </summary>
		public string Name { get; set; }

		#endregion

		#region NavigationProperties

		/// <summary>
		///     Collection of Users which belong to this Group
		/// </summary>
		public ICollection<User> Users { get; set; }

		/// <summary>
		///     Collection of Categories which can be viewed by the members of the Group.
		/// </summary>
		public ICollection<Category> ViewedCategories { get; set; }

		/// <summary>
		///     Collection of Categories which can be viewed and edited by the members of the Group.
		/// </summary>
		/// <remarks>
		///		It is implied that if a Group can edit(post, remove own posts etc), they most certainly can view the Category.
		/// </remarks>
		public ICollection<Category> EditedCategories { get; set; }

		/// <summary>
		///     Collection of Users which manage the group.
		/// </summary>
		public ICollection<User> ModeratingUsers { get; set; }

		#endregion
	}
}