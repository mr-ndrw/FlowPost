
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	/// <summary>
	///		Specialized interface defining behaviour specific to Message entity.
	/// </summary>
	public interface IMessageRepository : IRepository<Message>
	{
	}
}
