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
	}
}