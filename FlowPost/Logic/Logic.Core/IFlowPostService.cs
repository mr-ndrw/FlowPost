using en.AndrewTorski.FlowPost.Logic.Core.IServices;

namespace en.AndrewTorski.FlowPost.Logic.Core
{
	/// <summary>
	///		Describes a contract for deriving class to implement.
	/// </summary>
	/// <remarks>
	///		Primarily used for getting a clear view of how the functionalities this rather large class has.
	/// </remarks>
	public interface IFlowPostService
	{
		/// <summary>
		///		Service which exposes methods to extract and/or manipulate User entity with.
		/// </summary>
		IUserService UserService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Category entity with.
		/// </summary>
		ICategoryService CategoryService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate CategoryGroup entity with.
		/// </summary>
		ICategoryGroupService CategoryGroupService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Message entity with.
		/// </summary>
		IMessageService MessageService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate authentication and authorizations matters with.
		/// </summary>
		IAccountService AccountService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Group entity with.
		/// </summary>
		IGroupService GroupService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Report entity with.
		/// </summary>
		IReportService ReportService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Post entity with.
		/// </summary>
		IPostService PostService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Topic entity with.
		/// </summary>
		ITopicService TopicService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Moderator entity with.
		/// </summary>
		IModeratorService ModeratorService { get; set; }
	}
}