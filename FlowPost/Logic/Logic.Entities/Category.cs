using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Structure which contains Posts, Topics and children Categories.
	/// </summary>
	public class Category
	{
		public Category()
		{
			CanBeViewAndEditedByUsers = new List<User>();
			CanBeViewedByUsers = new List<User>();

			CanBeViewedAndEditedByGroups = new List<Group>();
			CanBeViewedByGroups = new List<Group>();

			Categories = new List<Category>();
			Posts = new List<Post>();
			Topics = new List<Topic>();
			ModeratingUsers = new List<User>();
		}

		#region Properties

		/// <summary>
		///     Category's unique identifier which serves as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Catergory's name.
		/// </summary>
		public string Name { get; set; }

		#endregion //Properties

		#region NavigationProperties

		/// <summary>
		///     Unique identifier of the CategoryGroup this Category belongs to.
		/// </summary>
		public int CategoryGroupId { get; set; }

		/// <summary>
		///     CategoryGroup to which this Category belongs to.
		/// </summary>
		public CategoryGroup CategoryGroup { get; set; }

		/// <summary>
		///     Collection of children Categories.
		/// </summary>
		public ICollection<Category> Categories { get; set; }

		/// <summary>
		///     Collection of Topics posted to this category.
		/// </summary>
		public ICollection<Topic> Topics { get; set; }

		/// <summary>
		///     List of posts which were posted to this Category.
		/// </summary>
		public ICollection<Post> Posts { get; set; }

		/// <summary>
		///     Collection of Users which may moderate this Category.
		/// </summary>
		public ICollection<User> ModeratingUsers { get; set; }

		/// <summary>
		///     Collection of Groups which can view this Category.
		/// </summary>
		public ICollection<Group> CanBeViewedByGroups { get; set; }

		/// <summary>
		///     Collection of Groups which can view and edit this Category.
		/// </summary>
		public ICollection<Group> CanBeViewedAndEditedByGroups { get; set; }

		/// <summary>
		///     Collection of Users which can view this Category.
		/// </summary>
		public ICollection<User> CanBeViewedByUsers { get; set; }

		/// <summary>
		///     Collection of Users which can view and edit this Category.
		/// </summary>
		public ICollection<User> CanBeViewAndEditedByUsers { get; set; }

		#endregion //NavigationProperties
	}
}