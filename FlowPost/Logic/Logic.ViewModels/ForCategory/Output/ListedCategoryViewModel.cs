using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForPost.Output;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output
{
	/// <summary>
	///		Contains simple data about a category which is used in listing contexts.
	/// </summary>
	/// <remarks>
	///		Used in contexts where no information is needed about the topics which this category includes.
	/// </remarks>
	public class ListedCategoryViewModel
	{
		/// <summary>
		///		
		/// </summary>
		/// <param name="category"></param>
		public ListedCategoryViewModel(Category category)
		{
			Id = category.Id;
			Name = category.Name;
			LastPost = new SimplePostViewModel(category.LastPost);
			LastPoster = new SimpleUserViewModel(category.LastPoster);
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
		///		Simple data about the last posted message. Id and Date of Posting.
		/// </summary>
		public SimplePostViewModel LastPost { get; set; }

		/// <summary>
		///		Simple data about the last poster. Id and UserName.
		/// </summary>
		public SimpleUserViewModel LastPoster { get; set; }
	}
}
