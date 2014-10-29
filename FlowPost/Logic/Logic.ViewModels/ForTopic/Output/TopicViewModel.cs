using System;
using System.Collections.Generic;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForCategory.Output;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForPost.Output;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForTopic.Output
{
	/// <summary>
	///		Contains data about the topic post itself and all children posts.
	/// </summary>
	public class TopicViewModel
	{
		/// <summary>
		///		Initializes an object with data from Topic object.
		/// </summary>
		/// <param name="topic">
		///		Topic object for which we obtain a ViewModel.
		/// </param>
		public TopicViewModel(Topic topic)
		{
			Id = topic.Id;
			Subject = topic.Subject;
			RawContent = topic.RawContent;
			DateTime = topic.DateTime;
			Poster = new SingleUserViewModel(topic.User);
			Category = new SimpleCategoryViewModel(topic.Category);
			Posts = topic.Posts
					.Select(post => new PostViewModel(post))
					.ToList();
		}

		/// <summary>
		///     Unique identifier also serving as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Title of the Topic.
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		///     Raw text with no markup.
		/// </summary>
		public string RawContent { get; set; }

		/// <summary>
		///     Date and time of the message being posted.
		/// </summary>
		public DateTime DateTime { get; set; }

		/// <summary>
		///		User which has posted this topic post.
		/// </summary>
		public SingleUserViewModel Poster { get; set; }

		/// <summary>
		///		Parent category to which this category belongs.
		/// </summary>
		public SimpleCategoryViewModel Category { get; set; }

		/// <summary>
		///		Messages posted to this topic.
		/// </summary>
		public List<PostViewModel> Posts { get; set; }
	}
}
