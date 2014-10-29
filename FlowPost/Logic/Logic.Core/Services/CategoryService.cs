using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Core.IServices;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output;
using en.AndrewTorski.FlowPost.Persistance.Data;

namespace en.AndrewTorski.FlowPost.Logic.Core.Services
{
	/// <summary>
	///		Defines a contract for methods operating around a Category service.
	/// </summary>
	public class CategoryService : ICategoryService
	{
		/// <summary>
		///		Flow post data context.
		/// </summary>
		private readonly IFlowPostDataContext _dbContext;

		/// <summary>
		///		Initializes CategoryService object with dbContext.
		/// </summary>
		/// <param name="dbContext">
		///		FlowPost data context.
		/// </param>
		public CategoryService(IFlowPostDataContext dbContext)
		{
			_dbContext = dbContext;
		}

		/// <summary>
		///		Gets a category by it's id.
		/// </summary>
		/// <param name="id">
		///		Category's Id.
		/// </param>
		/// <returns>
		///		<see cref="CategoryViewModel"/> with all of category's underlying data. 
		/// </returns>
		/// <remarks>
		///		Returns null, if no such Id was found.
		/// </remarks>
		public CategoryViewModel GetCategoryById(int id)
		{
			var categoryToFind = _dbContext.Categories
									.Include("Topics")
									.Include("ChildrenCategories")
									.SingleOrDefault(category => category.Id == id);

			if (categoryToFind == null)
			{
				return null;
			}

			var result = new CategoryViewModel(categoryToFind);

			return result;
		}
	}
}
