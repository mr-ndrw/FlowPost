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
		public string Title { get; set; }

		/// <summary>
		///     Message's content.
		/// </summary>
		/// <remarks>
		///     May be BBC encoded.
		/// </remarks>
		public string Content { get; set; }

		/// <summary>
		///     Date and time of the message posting.
		/// </summary>
		public DateTime DateTime { get; set; }

		#endregion

		#region NavigationProperties

		/// <summary>
		///     Name of the Sender of the message.
		/// </summary>
		public string SenderUserName { get; set; }

		/// <summary>
		///     Sender of the message.
		/// </summary>
		public User SenderUser { get; set; }


		public string AdresseUserName { get; set; }

		/// <summary>
		///     Addressee of the message.
		/// </summary>
		public User AddresseUser { get; set; }

		#endregion
	}
}