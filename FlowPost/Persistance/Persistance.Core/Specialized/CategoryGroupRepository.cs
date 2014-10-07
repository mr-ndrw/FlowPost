using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Core.Abstract;
using en.AndrewTorski.FlowPost.Persistance.Data;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	/// <summary>
	///		Specialized inteface defining behaviour specific to CategoryGroup entity.
	/// </summary>
	public class CategoryGroupRepository : RepositoryBase<CategoryGroup>
	{
		/// <summary>
		///		
		/// </summary>
		/// <param name="entity">Entity to be found.</param>
		/// <returns>Found entity.</returns>
		protected override CategoryGroup GetSingle(CategoryGroup entity)
		{
			return EntitySet.FirstOrDefault(cg => cg.Id == entity.Id);
		}

		protected override IQueryable<CategoryGroup> EntitySet
		{
			get { return (DataContext as FlowPostDataContext).CategoryGroups; }
		}
	}
}
