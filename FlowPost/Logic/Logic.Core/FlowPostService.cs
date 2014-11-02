using en.AndrewTorski.FlowPost.Logic.Core.IServices;

namespace en.AndrewTorski.FlowPost.Logic.Core
{
	/// <summary>
	///		Service encapsulating diffrent many services associated with Entities.
	/// </summary>
	/// <remarks>
	///		These services basically cover the whole CRUD operations ground. Both the basic ones and the more sophistitacted one.
	/// </remarks>
    public class FlowPostService : IFlowPostService
    {
		#region Constructors

		/// <summary>
		///		Initializes an new instance of FlowPostService with injections of underlying dependencies.
		/// </summary>
		public FlowPostService(	IUserService userService, ICategoryService categoryService, 
								ICategoryGroupService categoryGroupService, IMessageService messageService, 
								IAccountService accountService, IGroupService groupService, 
								IReportService reportService, IPostService postService, 
								ITopicService topicService, IModeratorService moderatorService)
		{
			UserService = userService;
			CategoryService = categoryService;
			CategoryGroupService = categoryGroupService;
			MessageService = messageService;
			AccountService = accountService;
			GroupService = groupService;
			ReportService = reportService;
			PostService = postService;
			TopicService = topicService;
			ModeratorService = moderatorService;
		}

		#endregion

		#region ServiceProperties

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate User entity with.
		/// </summary>
		public IUserService UserService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Category entity with.
		/// </summary>
		public ICategoryService CategoryService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate CategoryGroup entity with.
		/// </summary>
		public ICategoryGroupService CategoryGroupService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Message entity with.
		/// </summary>
		public IMessageService MessageService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate authentication and authorizations matters with.
		/// </summary>
		public IAccountService AccountService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Group entity with.
		/// </summary>
		public IGroupService GroupService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Report entity with.
		/// </summary>
		public IReportService ReportService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Post entity with.
		/// </summary>
		public IPostService PostService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Topic entity with.
		/// </summary>
		public ITopicService TopicService { get; set; }

		/// <summary>
		///		Service which exposes methods to extract and/or manipulate Moderator entity with.
		/// </summary>
		public IModeratorService ModeratorService { get; set; } 

		#endregion
    }
}
