using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Output
{
	/// <summary>
	///		Category group with included children categories.
	/// </summary>
	public class CategoryGroupViewModel
	{
		/// <summary>
		///		Name of the group.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		List of Categories contained within the category group.
		/// </summary>
		public List<ListedCategoryViewModel> ChildrenCategories { get; set; }
	}
}
