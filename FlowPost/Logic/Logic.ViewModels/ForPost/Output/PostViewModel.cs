using System;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Logic.ViewModels.ForUser.Output;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.ForPost.Output
{
	/// <summary>
	/// TODO: Comment
	/// </summary>
	public class PostViewModel
	{
		public PostViewModel()
		{
			
		}
		/// <summary>
		///		Initializes an object with data from Post object.
		/// </summary>
		/// <param name="post">
		///		Post object for which we obtain the ViewModel.
		/// </param>
		public PostViewModel(Post post)
		{
			Id = post.Id;
			RawContent = post.RawContent;
			DateTime = post.DateTime;
			User = new SingleUserViewModel(post.User);
		}

		/// <summary>
		///     Id of the Post
		/// </summary>
		public int Id { get; set; }

		//	Consider:	Remember to change the Content from RawContent(raw text) to HtmlContent as development continues!
		/// <summary>
		///		Raw text with no markup.
		/// </summary>
		public string RawContent { get; set; }

		/// <summary>
		///     Date and time of the message being posted.
		/// </summary>
		public DateTime DateTime { get; set; }

		/// <summary>
		///		User which has posted this message.
		/// </summary>
		public SingleUserViewModel User { get; set; }
	}
}