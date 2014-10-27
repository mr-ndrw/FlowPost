using System.Collections.Generic;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
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
		List<CategoryViewModel> GetCategoryGroups();

	}
}
