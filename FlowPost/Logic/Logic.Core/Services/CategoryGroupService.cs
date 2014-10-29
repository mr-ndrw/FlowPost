using System.Collections.Generic;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategoryGroup.Output;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Logic.Core.Services
{
	/// <summary>
	///		Gives access to methods which operate around the CategoryGroup entities.
	/// </summary>
	public class CategoryGroupService : ICategoryGroupService
	{
		private readonly IFlowPostDataContext _dbContext;

		/// <summary>
		///		Initializes the service with an injection of <see cref="IFlowPostDataContext"/> implementing class object.
		/// </summary>
		/// <param name="dbContext">
		///		IFlowPostDataContext implementation injection object.
		/// </param>
		public CategoryGroupService(IFlowPostDataContext dbContext)
		{
			_dbContext = dbContext;
		}

		/// <summary>
		///		Gets category groups.
		/// </summary>
		/// <returns>
		///		List containing category group.
		///	</returns>
		/// <remarks>
		///		Returns empty list(count == 0) if not category group was found.
		/// </remarks>
		public List<CategoryGroupViewModel> GetCategoryGroups()
		{
			var foundCategoriesList = _dbContext.CategoryGroups
				.Select(categoryGroup => new CategoryGroupViewModel(categoryGroup))
				.ToList();

			//TODO: check if returns null
			return foundCategoriesList;
		}
	}

}
