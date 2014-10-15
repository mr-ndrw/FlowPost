using System;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Provides information on a Banishment of a User such as the User himself,
	///     from when until when he is banned, for what reason is he banished and the Moderating User who has issued the Ban.
	/// </summary>
	public class Ban
	{
		#region Properties

		/// <summary>
		///     Id of the Banishment..
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///     Moderator-issued reason for the banishment.
		/// </summary>
		public string Reason { get; set; }

		/// <summary>
		///     Date and time of the banishment.
		/// </summary>
		public DateTime FromDateTime { get; set; }

		/// <summary>
		///     On what Date and time does the banishment expire.
		/// </summary>
		public DateTime ToDateTime { get; set; }

		#endregion //Properties

		#region NavigationProperties

		/// <summary>
		///     Id of the banished user.
		/// </summary>
		public string BanishedUserId { get; set; }
		
		/// <summary>
		///		Name of the banished User.
		/// </summary>
		public string BanishedUserName { get; set; }

		/// <summary>
		///     Banished User.
		/// </summary>
		public User BanishedUser { get; set; }

		/// <summary>
		///     Id of the moderator who has issued the banishment.
		/// </summary>
		public string ModeratorUserId { get; set; }

		/// <summary>
		///     Name of the moderator who has issued the banishment.
		/// </summary>
		public string ModeratorUserName { get; set; }

		/// <summary>
		///     Moderator who has issued the banishment.
		/// </summary>
		public User Moderatoruser { get; set; }

		#endregion //NavigationProperties
	}
}