using System;
using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Structure which contains Posts and children Categories.
	/// </summary>
	public class Category
	{
		#region Properties

		//Consider: Description property.

		/// <summary>
		///     Category's unique identifier which serves as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Catergory's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		Date and time of the last posted message in this Category.
		/// </summary>
		public DateTime LastPostDateTime { get; set; }

		#endregion

		#region NavigationProperties

		/// <summary>
		///     Parent category of this Category. If null, then Category is a root Category.
		/// </summary>
		public Category ParentCategory { get; set; }

		/// <summary>
		///		Last message posted to this Category.
		/// </summary>
		public Post LastPost { get; set; }

		/// <summary>
		///		User who posted the last message to this Category.
		/// </summary>
		public User LastPoster { get; set; }

		/// <summary>
		///     CategoryGroup to which this Category belongs to.
		/// </summary>
		public CategoryGroup CategoryGroup { get; set; }

		//Consider: change the to ChildrenCategories?
		/// <summary>
		///     Collection of children Categories.
		/// </summary>
		public ICollection<Category> Categories { get; set; }

		/// <summary>
		///     List of posts which were posted to this Category.
		/// </summary>
		/// <remarks>
		///		Instead of holding the entire post collection, we just hold Topic entities
		///		for quicker acquisition of Topic posted in a Category.
		/// </remarks>
		public ICollection<Topic> Topics { get; set; }

		/// <summary>
		///     Collection of Users which may moderate this Category.
		/// </summary>
		public ICollection<User> ModeratingUsers { get; set; }

		/// <summary>
		///     Collection of Groups which can view this Category.
		/// </summary>
		public ICollection<Group> ViewedByGroups { get; set; }

		/// <summary>
		///     Collection of Groups which can view and edit this Category.
		/// </summary>
		/// <remarks>
		///		It is implied that if a Group can edit(post, remove own posts etc), they most certainly can view the Category.
		/// </remarks>
		public ICollection<Group> EditedByGroups { get; set; }

		/// <summary>
		///     Collection of Users which can view this Category.
		/// </summary>
		public ICollection<User> ViewedByUsers { get; set; }

		/// <summary>
		///     Collection of Users which can view and edit this Category.
		/// </summary>
		/// <remarks>
		///		It is implied that if a User can edit(post, remove own posts etc), he/she most certainly can view the Category.
		/// </remarks>
		public ICollection<User> EditedByUsers { get; set; }

		#endregion //NavigationProperties
	}
}