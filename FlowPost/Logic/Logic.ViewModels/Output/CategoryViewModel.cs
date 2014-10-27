using System;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Output
{
	/// <summary>
	///		Contains simple data about a category.
	/// </summary>
	/// <remarks>
	///		This
	///	</remarks>
	public class CategoryViewModel
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
		///		Date and time of the last posted message in this Category.
		/// </summary>
		public DateTime LastPostDateTime { get; set; }
	}
}
