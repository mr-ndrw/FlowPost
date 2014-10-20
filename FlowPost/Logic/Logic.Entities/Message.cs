using System;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Message sent between Users.
	/// </summary>
	/// <remarks>
	///     No Entity Framework specific annotations were used.
	///     For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
	/// </remarks>
	public class Message
	{
		#region Properties

		/// <summary>
		///     Message's unique identifie which serves as a Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Title of the message.
		/// </summary>
		public string Subject { get; set; }

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
		///     Date and time of the message posting.
		/// </summary>
		public DateTime DateTime { get; set; }

		#endregion

		#region NavigationProperties

		/// <summary>
		///     Sender of the message.
		/// </summary>
		public User FromUser { get; set; }

		/// <summary>
		///     Addressee of the message.
		/// </summary>
		public User ToUser { get; set; }

		#endregion
	}
}