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
		public int PostId { get; set; }

		/// <summary>
		///     Reported post in question.
		/// </summary>
		public Post Post { get; set; }

		#endregion //NavigationProperties
	}
}