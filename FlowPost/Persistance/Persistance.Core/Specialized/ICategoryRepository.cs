using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	/// <summary>
	///		Specialized interace defining behaviour specific to Category entity.
	/// </summary>
	public interface ICategoryRepository : IRepository<Category>
	{
	}
}