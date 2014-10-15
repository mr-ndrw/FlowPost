using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Represents a Group of Users.
	/// </summary>
	public class Group
	{
		/*	Group:
		 *		Such an entity groups toghether a number of Users, who collectively take on a name and give themselves a description.
		 *		They may have a special access to some parts of the forums. Each group is moderated by specifically designated Users who may add,
		 *		delete Users, change the name and description of the group.
		 */
		#region Properties

		/// <summary>
		///     Group's unique identifier which serves as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Group's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		Description of the Group.
		/// </summary>
		public string Description { get; set; }

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