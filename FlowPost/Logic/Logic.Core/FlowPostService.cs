
using en.AndrewTorski.FlowPost.Logic.Core.IServices;

namespace en.AndrewTorski.FlowPost.Logic.Core
{
	/// <summary>
	///		
	/// </summary>
    public class FlowPostService : IFlowPostService
    {
		/// <summary>
		///		Service which exposes methods to extract and/or manipulate User entity with.
		/// </summary>
		public IUserService UserService { get; set; }
    }
}
