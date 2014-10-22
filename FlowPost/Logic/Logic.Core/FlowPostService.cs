
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
		/// <summary>
		///		Service which exposes methods to extract and/or manipulate User entity with.
		/// </summary>
		public IUserService UserService { get; set; }
    }
}
