using System.Data.Entity;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data
{

	/// <summary>
	///		Describes contract for the Persistance access class to realize.
	/// </summary>
	public interface IFlowPostDataContext
	{
		/// <summary>
		///		Gets or sets the users.
		/// </summary>
		/// <value>
		///		The users.
		/// </value>
		IDbSet<User> Users { get; set; }

		/// <summary>
		///		Gets or sets the posts.
		/// </summary>
		/// <value>
		///		The posts.
		/// </value>
		DbSet<Post> Posts { get; set; }

		/// <summary>
		///		Gets or sets the topics.
		/// </summary>
		/// <value>
		///		The topics.
		/// </value>
		DbSet<Topic> Topics { get; set; }

		/// <summary>
		///		Gets or sets the bans.
		/// </summary>
		/// <value>
		///		The bans.
		/// </value>
		DbSet<Ban> Bans { get; set; }

		/// <summary>
		///		Gets or sets the post edits.
		/// </summary>
		/// <value>
		///		The post edits.
		/// </value>
		DbSet<PostEdit> PostEdits { get; set; }

		/// <summary>
		///		Gets or sets the messages.
		/// </summary>
		/// <value>
		///		The messages.
		/// </value>
		DbSet<Message> Messages { get; set; }

		/// <summary>
		///		Gets or sets the user reports.
		/// </summary>
		/// <value>
		///		The user reports.
		/// </value>
		DbSet<UserReport> UserReports { get; set; }

		/// <summary>
		///		Gets or sets the post reports.
		/// </summary>
		/// <value>
		///		The post reports.
		/// </value>
		DbSet<PostReport> PostReports { get; set; }

		/// <summary>
		///		Gets or sets the categories.
		/// </summary>
		/// <value>
		///		The categories.
		/// </value>
		DbSet<Category> Categories { get; set; }

		/// <summary>
		///		Gets or sets the category groups.
		/// </summary>
		/// <value>
		///		The category groups.
		/// </value>
		DbSet<CategoryGroup> CategoryGroups { get; set; }


		/// <summary>
		///		Gets or sets the groups.
		/// </summary>
		/// <value>
		///		The groups.
		/// </value>
		DbSet<Group> Groups { get; set; }

		/// <summary>
		///		Saves the changes.
		/// </summary>
		/// <returns></returns>
		int SaveChanges();
	}
}
