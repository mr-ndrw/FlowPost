using System.Collections.Generic;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Logic.Core.IServices
{
	public interface ICategoryGroupService
	{
		List<CategoryGroup> GetCategoryGroupsWithChildren();

	}
}
