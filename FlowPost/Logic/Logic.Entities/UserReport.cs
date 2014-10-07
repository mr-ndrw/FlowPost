namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Report made against a User.
	/// </summary>
	public class UserReport : Report
	{
		#region NavigationProperties

		/// <summary>
		///     Unique identifier of the reported User.
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		///     Reported user in question.
		/// </summary>
		public User ReportedUser { get; set; }

		#endregion //NavigationProperties
	}
}