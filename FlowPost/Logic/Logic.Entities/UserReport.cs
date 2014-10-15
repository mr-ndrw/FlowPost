﻿namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Report made against a User.
	/// </summary>
	public class UserReport : Report
	{
		#region NavigationProperties

		/// <summary>
		///     Id of the reported User.
		/// </summary>
		public string ReportedUserId { get; set; }

		/// <summary>
		///     Name of the reported User.
		/// </summary>
		public string ReportedUserName { get; set; }

		/// <summary>
		///     Reported user in question.
		/// </summary>
		public User ReportedUser { get; set; }

		#endregion //NavigationProperties
	}
}