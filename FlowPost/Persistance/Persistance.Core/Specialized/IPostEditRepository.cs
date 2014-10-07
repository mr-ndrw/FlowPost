using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	/// <summary>
	///     Specialized inteface defining behaviour specific to PostEdit entities.
	/// </summary>
	public interface IPostEditRepository : IRepository<PostEdit>
	{
	}
}