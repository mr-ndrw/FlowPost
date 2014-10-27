using System.Data.Entity;
using en.AndrewTorski.FlowPost.Logic.Entities;
using en.AndrewTorski.FlowPost.Persistance.Configurations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace en.AndrewTorski.FlowPost.Persistance.Data
{

	/// <summary>
	///		Persistance layer class giving enabling access of upper layers(business logic layer) to Data Access Layer.
	/// </summary>
	public class FlowPostDataContext : IdentityDbContext<User, Role, int, Login, UserRole, Claim>, IFlowPostDataContext
	{

		/// <summary>
		///		Initializes a new instance of the <see cref="FlowPostDataContext"/> class with a default connection.
		/// </summary>
		/// <remarks>
		///		Connects to the Default Connection.
		/// </remarks>
		public FlowPostDataContext()
		{

		}

		/// <summary>
		///		Initializes a new instance of the <see cref="FlowPostDataContext"/> class.
		/// </summary>
		/// <param name="connectionName">
		///		Name of the connection.
		/// </param>
		public FlowPostDataContext(string connectionName)
			: base(string.Format("Name={0}", connectionName))
			//	we use string.Format so that we get a nice format that is understood by the Constructor.
			//	For instance: if we passed simple "FlowPost" into the base constructor WITHOUT "Name=" prepending it
			//	we would not be able to connect.
		{
			
		}

		#region Properties

		//Virtual properties so that is is possible to mock them.

		/// <summary>
		///		Gets or sets the posts.
		/// </summary>
		/// <value>
		///		The posts.
		/// </value>
		public virtual DbSet<Post> Posts { get; set; }

		/// <summary>
		///		Gets or sets the topics.
		/// </summary>
		/// <value>
		///		The topics.
		/// </value>
		public virtual DbSet<Topic> Topics { get; set; }

		/// <summary>
		///		Gets or sets the bans.
		/// </summary>
		/// <value>
		///		The bans.
		/// </value>
		public virtual DbSet<Ban> Bans { get; set; }

		/// <summary>
		///		Gets or sets the post edits.
		/// </summary>
		/// <value>
		///		The post edits.
		/// </value>
		public virtual DbSet<PostEdit> PostEdits { get; set; }

		/// <summary>
		///		Gets or sets the messages.
		/// </summary>
		/// <value>
		///		The messages.
		/// </value>
		public virtual DbSet<Message> Messages { get; set; }

		/// <summary>
		///		Gets or sets the user reports.
		/// </summary>
		/// <value>
		///		The user reports.
		/// </value>
		public virtual DbSet<UserReport> UserReports { get; set; }

		/// <summary>
		///		Gets or sets the post reports.
		/// </summary>
		/// <value>
		///		The post reports.
		/// </value>
		public virtual DbSet<PostReport> PostReports { get; set; }

		/// <summary>
		///		Gets or sets the categories.
		/// </summary>
		/// <value>
		///		The categories.
		/// </value>
		public virtual DbSet<Category> Categories { get; set; }

		/// <summary>
		///		Gets or sets the category groups.
		/// </summary>
		/// <value>
		///		The category groups.
		/// </value>
		public virtual DbSet<CategoryGroup> CategoryGroups { get; set; }


		/// <summary>
		///		Gets or sets the groups.
		/// </summary>
		/// <value>
		///		The groups.
		/// </value>
		public virtual DbSet<Group> Groups { get; set; } 

		#endregion

		/// <summary>
		///		Called when creating the model. Configures tables to match given Model criteria.
		/// </summary>
		/// <param name="modelBuilder">The model builder.</param>
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