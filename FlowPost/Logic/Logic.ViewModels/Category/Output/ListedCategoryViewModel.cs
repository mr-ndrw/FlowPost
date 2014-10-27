using en.AndrewTorski.FlowPost.Logic.ViewModels.Post.Output;
using en.AndrewTorski.FlowPost.Logic.ViewModels.User.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Category.Output
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
