using System.Data.Entity;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Configurations;
using en.AndrewTorski.FlowPost.Persistance.Data;
/*	Constructed with the help of http://msdn.microsoft.com/en-us/data/dn314431.aspx	*/
namespace en.AndrewTorski.FlowPost.Test.Data
{
	class TestFlowPostDataContext : IFlowPostDataContext
	{
		public TestFlowPostDataContext()
		{
/*			Users = new TestDbSet<User>();
			Posts = new TestDbSet<Post>();
			Topics = new TestDbSet<Topic>();
			Bans = new TestDbSet<Ban>();
			PostEdits = new TestDbSet<PostEdit>();
			Messages = new TestDbSet<Message>();
			UserReports = new TestDbSet<UserReport>();
			PostReports = new TestDbSet<PostReport>();
			Categories = new TestDbSet<Category>();
			CategoryGroups = new TestDbSet<CategoryGroup>();*/
		}

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

		// ReSharper disable once MemberCanBePrivate.Global
		public int SaveChangesCount { get; private set; }

		public int SaveChanges()
		{
			SaveChangesCount++;
			return 1;
		}

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
			//modelBuilder.Configurations.Add(new LoginConfiguration());
			//modelBuilder.Configurations.Add(new UserRoleConfiguration());

			#endregion

		}
	}
}
