using System.Collections.Generic;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategoryGroup.Output;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
	/// <summary>
	///		Defines a contract for operations which manipulate objects of class CategoryGroup.
	/// </summary>
	public interface ICategoryGroupService
	{
		/// <summary>
		///		Gets category groups.
		/// </summary>
		/// <returns>
		///		List containing category group.
		///	</returns>
		/// <remarks>
		///		Returns empty list(count == 0) if not category group was found.
		/// </remarks>
		List<CategoryGroupViewModel> GetCategoryGroups();

	}
}
