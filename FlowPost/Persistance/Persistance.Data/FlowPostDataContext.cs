using System.Data.Entity;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data.Configurations;

namespace en.AndrewTorski.FlowPost.Persistance.Data
{
	public class FlowPostDataContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public DbSet<Ban> Bans { get; set; }
		public DbSet<PostEdit> PostEdits { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<UserReport> UserReports { get; set; }
		public DbSet<PostReport> PostReports { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryGroup> CategoryGroups { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//TODO: Add entity configurations to modelBuilder.
			//TODO: Add ACTUAL configuration logic to Persistance.Data.Configurations.
			modelBuilder.Configurations.Add(new UserConfiguration());
			modelBuilder.Configurations.Add(new GroupConfiguration());
			modelBuilder.Configurations.Add(new CategoryGroupConfiguration());
			modelBuilder.Configurations.Add(new CategoryConfiguration());
			modelBuilder.Configurations.Add(new BanConfiguration());
			modelBuilder.Configurations.Add(new MessageConfiguration());
		}
	}
}