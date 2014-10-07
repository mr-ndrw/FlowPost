
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	/// <summary>
	///		Specialized interace defining behaviour specific to Post entity.
	/// </summary>
	public interface IPostRepository : IRepository<Post>
	{
	}
}
