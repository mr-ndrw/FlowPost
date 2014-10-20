using System.Data.Entity;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Data.Configurations;

namespace en.AndrewTorski.FlowPost.Persistance.Data
{
	public class FlowPostDataContext : DbContext
	{
        //public FlowPostDataContext()
        //    : base("name=FlowPost")
        //{
	        
        //}

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
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FlowPostDataContext>());

			#region EntityConfigs

			modelBuilder.Configurations.Add(new UserConfiguration());
			modelBuilder.Configurations.Add(new GroupConfiguration());
			modelBuilder.Configurations.Add(new CategoryGroupConfiguration());
			modelBuilder.Configurations.Add(new CategoryConfiguration());
			modelBuilder.Configurations.Add(new BanConfiguration());
			modelBuilder.Configurations.Add(new MessageConfiguration());
			modelBuilder.Configurations.Add(new PostConfiguration());
			modelBuilder.Configurations.Add(new TopicConfiguration());
			modelBuilder.Configurations.Add(new PostEditConfiguration());
			modelBuilder.Configurations.Add(new ReportConfiguration());
			modelBuilder.Configurations.Add(new UserReportConfiguration());
			modelBuilder.Configurations.Add(new PostReportConfiguration());
            modelBuilder.Configurations.Add(new LoginConfiguration());
            modelBuilder.Configurations.Add(new UserRoleConfiguration());

            #endregion

		}
	}
}