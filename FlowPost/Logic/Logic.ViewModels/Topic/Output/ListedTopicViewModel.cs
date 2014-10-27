using System;
using en.AndrewTorski.FlowPost.Logic.ViewModels.Post.Output;
using en.AndrewTorski.FlowPost.Logic.ViewModels.User.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Topic.Output
{
	/// <summary>
	///		Contains simple data about a topic which is used in listing contexts.
	/// </summary>
	/// <remarks>
	///		Used in contexts where no information is needed about the posts which this topic includes.
	/// </remarks>
	public class ListedTopicViewModel
	{
		/// <summary>
		///		Id of the topic.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Title of the Topic.
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		///     Hidden status.
		/// </summary>
		public bool IsHidden { get; set; }

		/// <summary>
		///     Closed status.
		/// </summary>
		public bool IsClosed { get; set; }

		/// <summary>
		///     Sticky status.
		/// </summary>
		public bool IsSticky { get; set; }

		/// <summary>
		///     Extraordinary status.
		/// </summary>
		public bool IsExtraordinary { get; set; }

		/// <summary>
		///     Number of views this Topic has gotten.
		/// </summary>
		public int NumberOfViews { get; set; }

		/// <summary>
		///     Number of posted replies to this Topic.
		/// </summary>
		public int NumberOfReplies { get; set; }

		/// <summary>
		///		Datetime of the last message posted to this Topic.
		/// </summary>
		public DateTime LastPostDateTime { get; set; }

		/// <summary>
		///		Simple data about the last message posted.
		/// </summary>
		public SimplePostViewModel LastPost { get; set; }

		/// <summary>
		///		Basic data about the user who has posted last message to this topic.
		/// </summary>
		public SimpleUserViewModel LastPoster { get; set; }
	}
}
