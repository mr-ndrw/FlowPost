using System;
using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Posted message on the forum.
	/// </summary>
	/// <remarks>
	///     No Entity Framework specific annotations were used.
	///     For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
	/// </remarks>
	public class Post
	{
		#region Properties

		/// <summary>
		///     Unique identifier also serving as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     BBCode encoded content.
		/// </summary>
		public string BbCodeContent { get; set; }

		/// <summary>
		///		HyperText-Marked-up content.
		/// </summary>
		public string HtmlContent { get; set; }

		/// <summary>
		///		Raw text with no markup.
		/// </summary>
		public string RawContent { get; set; }

		/// <summary>
		///     Date and time of the message being posted.
		/// </summary>
		public DateTime DateTime { get; set; }

		/// <summary>
		///     Number of strikes against the Post.
		/// </summary>
		public int Strikes { get; set; }

		#endregion //Properties

		#region NavigationProperties

        /// <summary>
        ///     The Topic post to which this post is a reply.
        /// </summary>
        public Topic ParentTopic { get; set; }

		/// <summary>
		///     User which has posted this message.
		/// </summary>
		public User User { get; set; }

		/// <summary>
		///     Reports comitted to this Post.
		/// </summary>
		public virtual ICollection<PostReport> PostReports { get; set; }

		/// <summary>
		///     Collection of past PostEdits to this Post.
		/// </summary>
		public virtual ICollection<PostEdit> PostEdits { get; set; }

		#endregion //NavigationProperties
	}
}