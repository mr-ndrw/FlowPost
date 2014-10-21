using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data
{
	public interface IFlowPostDataContext
	{
		DbSet<User> Users { get; set; }
		DbSet<Post> Posts { get; set; }
		DbSet<Topic> Topics { get; set; }
		DbSet<Ban> Bans { get; set; }
		DbSet<PostEdit> PostEdits { get; set; }
		DbSet<Message> Messages { get; set; }
		DbSet<UserReport> UserReports { get; set; }
		DbSet<PostReport> PostReports { get; set; }
		DbSet<Category> Categories { get; set; }
		DbSet<CategoryGroup> CategoryGroups { get; set; }

		int SaveChanges();
	}
}
