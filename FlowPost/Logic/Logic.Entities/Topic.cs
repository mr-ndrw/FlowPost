using System;
using System.Collections.Generic;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Topical Post - a post with no parent post.
	/// </summary>
	public class Topic : Post
	{
		#region Properties

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

		#endregion

		#region NavigationProperties

		/// <summary>
		///		Id of the last User who has posted a message to this topic.
		/// </summary>
		public string LastPosterUserId{ get; set; }

		/// <summary>
		///		Name of the last User who has posted a message to this topic.
		/// </summary>
		public string LastPosterUserName { get; set; }
		
		/// <summary>
		///		Last User who has posted under this topic.
		/// </summary>
		public User LastPoster { get; set; }

		/// <summary>
		///		Id of the last posted message.
		/// </summary>
		public int LastPostId { get; set; }

		/// <summary>
		///		Last posted message.
		/// </summary>
		public Post LastPost { get; set; }

		/// <summary>
		///     Unique identifier of the catergory to which this Post belongs.
		/// </summary>
		public int CategoryId { get; set; }

		/// <summary>
		///     The catergory to which this Post belongs.
		/// </summary>
		public Category Category { get; set; }

		/// <summary>
		///     Collection of posts which are replies to this Topic.
		/// </summary>
		public ICollection<Post> Posts { get; set; }

		#endregion
	}
}