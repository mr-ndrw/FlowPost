using System;
using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Groups multiple Categories into one entity.
	/// </summary>
	public class CategoryGroup
	{
		#region Properties

		/// <summary>
		///		Id of the Category Group
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Name of the group.
		/// </summary>
		public string Name { get; set; }

		#endregion //Properties

		#region NavigationProperties

		/// <summary>
		///     Collection of Categories which belong to this group.
		/// </summary>
		public ICollection<Category> Categories { get; set; }

		#endregion //NavigationProperties
	}
}