using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output
{
	/// <summary>
	///		Contains very simple data about a category.
	/// </summary>
	/// <remarks>
	///		Can be used in breadcrumbing situations.
	/// </remarks>
	public class SimpleCategoryViewModel
	{
		/// <summary>
		///		Initializes an object with data from <see cref="Category"/> object.
		/// </summary>
		/// <param name="category">
		///		Category for which we obtain a ViewModel.
		/// </param>
		public SimpleCategoryViewModel(Category category)
		{
			Id = category.Id;
			Name = category.Name;
			//	Recursion imminent
			ParentCategory = new SimpleCategoryViewModel(category.ParentCategory);
		}
		/// <summary>
		///     Category's unique identifier which serves as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Catergory's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		Parent category to which this category belongs.
		/// </summary>
		public SimpleCategoryViewModel ParentCategory { get; set; }

	}
}
