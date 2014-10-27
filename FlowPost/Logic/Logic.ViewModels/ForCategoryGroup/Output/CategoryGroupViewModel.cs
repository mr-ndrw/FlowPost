using System.Collections.Generic;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategoryGroup.Output
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
