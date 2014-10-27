using System;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForPost.Output
{
	/// <summary>
	///		Contains very simple data about a posted message.
	/// </summary>
	/// <remarks>
	///		Used in a context where we need to create a reference to a post(hence Id) and date of posting.
	/// </remarks>
	public class SimplePostViewModel
	{
		/// <summary>
		///		Initi
		/// </summary>
		public SimplePostViewModel(Post post)
		{
			Id = post.Id;
			DateOfPosting = post.DateTime;
		}

		/// <summary>
		///		Id of the posted message.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Date when the message was posted.
		/// </summary>
		public DateTime DateOfPosting { get; set; }
	}
}
