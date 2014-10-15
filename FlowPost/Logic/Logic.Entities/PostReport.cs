namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Report made on Post.
	/// </summary>
	public class PostReport : Report
	{
		#region NavigationProperties

		/// <summary>
		///		Id of the reported Post.
		/// </summary>
		public int ReportedPostId { get; set; }

		/// <summary>
		///     Reported post in question.
		/// </summary>
		public Post ReportedPost { get; set; }

		#endregion //NavigationProperties
	}
}