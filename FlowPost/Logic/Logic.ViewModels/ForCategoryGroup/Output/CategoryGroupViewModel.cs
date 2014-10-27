using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Entities;
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

		/// <summary>
		///		Initializes the object with data from the object of clas of CategoryGroup. 
		/// </summary>
		/// <param name="categoryGroup">
		///		CategoryGroup object for which we obtain the ViewModel.
		/// </param>
		public CategoryGroupViewModel(CategoryGroup categoryGroup)
		{
			Name = categoryGroup.Name;
			ChildrenCategories = GetListedCategoryViewModels(categoryGroup.Categories);
		}

		/// <summary>
		///		Converts a collection of Category objects into a collection of ListedCategoryViewModel objects.
		/// </summary>
		/// <param name="categories">
		///		Collection of Categories to convert.
		/// </param>
		/// <returns>
		///		List of converted ListedCategoryViewModel objects.
		/// </returns>
		private List<ListedCategoryViewModel> GetListedCategoryViewModels(IEnumerable<Category> categories)
		{
			var listedCategoryViewModelsList = categories
												.Select(category => new ListedCategoryViewModel(category))
												.ToList();

			return listedCategoryViewModelsList;
		}
	}
}
