using System;

namespace en.AndrewTorski.FlowPost.Logic.ViewModels.Output
{
	public class PostViewModel
	{
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