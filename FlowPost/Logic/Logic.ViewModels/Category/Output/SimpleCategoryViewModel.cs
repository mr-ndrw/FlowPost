namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Category.Output
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
		public SimpleCategoryViewModel CategoryViewModel { get; set; }

	}
}
