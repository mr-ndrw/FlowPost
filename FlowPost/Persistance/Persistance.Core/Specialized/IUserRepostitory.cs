using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	/// <summary>
	///		Specialized interface defining behaviour specific to User entity.
	/// </summary>
	public interface IUserRepostitory : IRepository<User>
	{
	}
}
