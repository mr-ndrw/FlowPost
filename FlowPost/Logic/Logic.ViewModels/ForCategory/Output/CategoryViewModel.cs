using System.Collections.Generic;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForTopic.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output
{
	/// <summary>
	///		Contains all needed data to correctly reperesent a category, when it is accessed.
	/// </summary>
	/// <remarks>
	///		Mentioned data includes such elements as topics posted to the category, children categories and parent category.
	/// </remarks>
	public class CategoryViewModel
	{
		public CategoryViewModel(Category category)
		{
			Id = category.Id;
			Name = category.Name;
			ParentCategory = new ListedCategoryViewModel(category.ParentCategory);

		}



		/// <summary>
		///		Id of the category.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Catergory's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		Category to which this category belongs.
		/// </summary>
		public ListedCategoryViewModel ParentCategory { get; set; }

		/// <summary>
		///		Collection of children categories of this category.
		/// </summary>
		public List<ListedCategoryViewModel> ChildrenCategories { get; set; }

		/// <summary>
		///		Collection of Topics posted to this category.
		/// </summary>
		public List<ListedTopicViewModel> Topics { get; set; }

	}
}
