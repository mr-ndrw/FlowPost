using System;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///		User's complain.
	/// </summary>
	public class Report
	{
		#region Properties

		/// <summary>
		///     Unique identifier which also serves as a Key.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Message of the report.
		/// </summary>
		public string Content { get; set; }

		/// <summary>
		///     Date and time of the registration of the report.
		/// </summary>
		public DateTime SentDateTime { get; set; }

		public DateTime ResolvedDateTime { get; set; }

		/// <summary>
		///     Has the report been resolved by the moderating officers.
		/// </summary>
		public bool IsResolved { get; set; }

		/// <summary>
		///     Moderating officer's message to this report.
		/// </summary>
		public string ModeratorReply { get; set; }

		#endregion

		#region NavigationProperties

		/// <summary>
		///		Id of the reporting User.
		/// </summary>
		public int ReportingUserId { get; set; }

		/// <summary>
		///     Name of the reporting User.
		/// </summary>
		public string ReportingUserName { get; set; }

		/// <summary>
		///     Reporting User.
		/// </summary>
		public User ReportingUser { get; set; }

		/// <summary>
		///     Id of the moderator which has replied to this message.
		/// </summary>
		public int ModeratorUserId { get; set; }

		/// <summary>
		///     Name of the moderator which has replied to this message.
		/// </summary>
		public string ModeratorUserName { get; set; }

		/// <summary>
		///     Moderator which has replied to this message.
		/// </summary>
		public User ModeratorUser { get; set; }

		#endregion
	}
}