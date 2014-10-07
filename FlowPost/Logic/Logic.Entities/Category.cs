using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Structure which contains Posts and children Categories.
	/// </summary>
	/// <remarks>
	///     No Entity Framework specific annotations were used.
	///     For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
	/// </remarks>
	public class Category
	{
		#region Properties

		/// <summary>
		///     Category's unique identifier which serves as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Catergory's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///     Parent category of this Category. If null, then Category is a root Category.
		/// </summary>
		public Category ParentCategory { get; set; }

		#endregion

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
		public virtual ICollection<Category> Categories { get; set; }

		/// <summary>
		///     List of posts which were posted to this Category.
		/// </summary>
		public virtual ICollection<Post> Posts { get; set; }

		/// <summary>
		///     Collection of Users which may moderate this Category.
		/// </summary>
		public virtual ICollection<User> ModeratingUsers { get; set; }

		/// <summary>
		///     Collection of Groups which can view this Category.
		/// </summary>
		public virtual ICollection<Group> CanBeViewedByGroups { get; set; }

		/// <summary>
		///     Collection of Groups which can view and edit this Category.
		/// </summary>
		public virtual ICollection<Group> CanBeViewedAndEditedByGroups { get; set; }

		/// <summary>
		///     Collection of Users which can view this Category.
		/// </summary>
		public virtual ICollection<User> CanBeViewedByUsers { get; set; }

		/// <summary>
		///     Collection of Users which can view and edit this Category.
		/// </summary>
		public virtual ICollection<User> CanBeViewAndEditedByUsers { get; set; }

		#endregion //NavigationProperties
	}
}