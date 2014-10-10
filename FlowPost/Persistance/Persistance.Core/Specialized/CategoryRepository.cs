using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Core.Abstract;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;
using en.AndrewTorski.FlowPost.Persistance.Interfaces.Specialized;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	/// <summary>
	///		Specialized interace defining behaviour specific to Category entity.
	/// </summary>
	public class CategoryRepository : ICategoryRepository, RepositoryBase<Category>
	{
	}
}