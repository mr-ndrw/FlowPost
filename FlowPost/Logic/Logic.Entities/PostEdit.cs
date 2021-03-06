﻿using System;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Comitted Post Edits by either the User or Moderator.
	/// </summary>
	public class PostEdit
	{
		#region Properties

		/// <summary>
		///     Unique identifier which also serves as the Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     BBCode encoded content.
		/// </summary>
		public string BbCodeContent { get; set; }

		/// <summary>
		///		Marked-up content.
		/// </summary>
		public string HtmlContent { get; set; }

		/// <summary>
		///		Raw text with no markup.
		/// </summary>
		public string RawContent { get; set; }

		/// <summary>
		///     Date and time of the Edit.
		/// </summary>
		public DateTime DateTime { get; set; }

		#endregion //Properties

		#region NavigationProperties

		/// <summary>
		///     Post of which Content was edited.
		/// </summary>
		public Post Post { get; set; }

		#endregion
	}
}