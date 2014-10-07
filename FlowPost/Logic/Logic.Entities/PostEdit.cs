using System;

namespace en.AndrewTorski.FlowPost.Logic.Entities
{
	/// <summary>
	///     Comitted Post Edits by either the User or Moderator.
	/// </summary>
	/// <remarks>
	///     Holds two bool property to differantiate whether the Edit was comitted by the User himself
	///     or by someone from the Moderators. If it it is true then the Foreign Property of
	///     No Entity Framework specific annotations were used.
	///     For configuration purposes please refer to [ClassName]Configuration file in ~/Logic.Data/Configurations
	/// </remarks>
	public class PostEdit
	{
		#region Properties

		/// <summary>
		///     Unique identifier which also serves as the Key.
		/// </summary>
		public UInt64 Id { get; set; }

		/// <summary>
		///     Edit's content.
		/// </summary>
		public string Content { get; set; }

		/// <summary>
		///     Date and time of the Edit.
		/// </summary>
		public DateTime DateTime { get; set; }

		/// <summary>
		///     Was this Edit comitted by a Moderator.
		/// </summary>
		public bool ModeratorEdited { get; set; }

		#endregion //Properties

		#region NavigationProperties

		/// <summary>
		///     Unique identifier of the Post which Content was edited.
		/// </summary>
		public int PostId { get; set; }

		/// <summary>
		///     Post of which Content was edited.
		/// </summary>
		public Post Post { get; set; }

		/// <summary>
		///     Name of the Moderator which has edited this message.
		/// </summary>
		public string ModeratorUserName { get; set; }

		/// <summary>
		///     Moderator User which has edited this message.
		/// </summary>
		public User ModeratorUser { get; set; }

		#endregion
	}
}