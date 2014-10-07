using System;
using System.Linq;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Core.Abstract;
using en.AndrewTorski.FlowPost.Persistance.Data;
using en.AndrewTorski.FlowPost.Persistance.Interfaces.Specialized;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Specialized
{
	public class BanRepository : RepositoryBase<Ban>, IBanRepository
	{
		protected override IQueryable<Ban> EntitySet
		{
			get { return (DataContext as FlowPostDataContext).Bans; }
		}

		protected override Ban GetSingle(Ban entity)
		{
			return EntitySet.FirstOrDefault(b => b.Id == entity.Id);
		}
	}
}