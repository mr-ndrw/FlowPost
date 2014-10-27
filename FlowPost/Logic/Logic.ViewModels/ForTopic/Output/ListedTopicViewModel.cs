using System;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForPost.Output;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForTopic.Output
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
		///		Simple data about the last message posted.
		/// </summary>
		public SimplePostViewModel LastPost { get; set; }

		/// <summary>
		///		Basic data about the user who has posted last message to this topic.
		/// </summary>
		public SimpleUserViewModel LastPoster { get; set; }

		/// <summary>
		///		Initializes the object with data from an object of class Topic.
		/// </summary>
		/// <param name="topic">
		///		Topic object for which the ViewModel is obtained.
		/// </param>
		public ListedTopicViewModel(Topic topic)
		{
			Id = topic.Id;
			Subject = topic.Subject;
			IsHidden = topic.IsHidden;
			IsClosed = topic.IsClosed;
			IsSticky = topic.IsSticky;
			IsExtraordinary = topic.IsExtraordinary;
			NumberOfReplies = topic.NumberOfReplies;
			NumberOfViews = topic.NumberOfViews;
			LastPost = new SimplePostViewModel(topic.LastPost);
			LastPoster = new SimpleUserViewModel(topic.LastPoster);
		}
	}
}
