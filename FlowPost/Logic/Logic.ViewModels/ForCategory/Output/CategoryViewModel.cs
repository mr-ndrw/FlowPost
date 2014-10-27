using System.Collections.Generic;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForTopic.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output
{
	/// <summary>
	///     Contains all needed data to correctly reperesent a category, when it is accessed.
	/// </summary>
	/// <remarks>
	///     Mentioned data includes such elements as topics posted to the category, children categories and parent category.
	/// </remarks>
	public class CategoryViewModel
	{
		#region Properties

		/// <summary>
		///     Id of the category.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Catergory's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///     Category to which this category belongs.
		/// </summary>
		public ListedCategoryViewModel ParentCategory { get; set; }

		/// <summary>
		///     Collection of children categories of this category.
		/// </summary>
		public List<ListedCategoryViewModel> ChildrenCategories { get; set; }

		/// <summary>
		///     Collection of Topics posted to this category.
		/// </summary>
		public List<ListedTopicViewModel> Topics { get; set; }

		#endregion

		/// <summary>
		///		Initializes an object with data from an object of class Category.
		/// </summary>
		/// <param name="category">
		///		Category for which we obtain the ViewModel.
		/// </param>
		public CategoryViewModel(Category category)
		{
			Id = category.Id;
			Name = category.Name;
			ParentCategory = new ListedCategoryViewModel(category.ParentCategory);
			ChildrenCategories = this.GetListedCategoryViewModels(category.Categories);
			Topics = this.GetListedTopicViewModels(category.Topics);
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
			//	Expression belows creates a new list of ListedCategoryViewModel object based on the objects contained in parameter-categories'
			//	collection of Categories.
			var listedCategoryViewModels = categories
											.Select(category => new ListedCategoryViewModel(category))
											.ToList();

			return listedCategoryViewModels;
		}

		/// <summary>
		///		Converts a collection of Topic objects into a collection of ListedTopicViewModel objects.
		/// </summary>
		/// <param name="topics">
		///		Collection Topics to convert.
		/// </param>
		/// <returns>
		///		List of converted ListedTopicViewModel objects.
		/// </returns>
		private List<ListedTopicViewModel> GetListedTopicViewModels(IEnumerable<Topic> topics)
		{
			//	Expression belows creates a new list of ListedTopicViewModels object based on the objects contained in parameter-topics'
			//	collection of Topics.
			var listedTopicViewModels = topics
											.Select(topic => new ListedTopicViewModel(topic))
											.ToList();

			return listedTopicViewModels;
		}
	}
}