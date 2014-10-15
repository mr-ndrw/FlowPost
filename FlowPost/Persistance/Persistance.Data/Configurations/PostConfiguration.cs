using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{	
	/// <summary>
	///		Configuration class for Message entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class PostConfiguration : EntityTypeConfiguration<Post>
	{
		public PostConfiguration()
		{
			/*	Id:
			 *	Since Message entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	User, UserId:
			HasRequired(post => post.User)
				.WithMany(user => user.Posts)
				.HasForeignKey(post => post.UserId);

			//----------------------------------------------------

			//	UserName:
			Property(post => post.UserName)
				.IsRequired();

			//----------------------------------------------------

			//	Strikes:
			Property(post => post.Strikes)
				.IsRequired();

			//----------------------------------------------------

			//	DateTime:
			Property(post => post.DateTime)
				.IsRequired();

			//----------------------------------------------------

			//	HtmlContent, BbCodeContent, RawContent:
			Property(post => post.HtmlContent)
				.HasMaxLength(40000);

			Property(post => post.BbCodeContent)
				.HasMaxLength(40000);

			Property(post => post.RawContent)
				.HasMaxLength(40000);

			//----------------------------------------------------

			//	PostEdits:
			HasMany(post => post.PostEdits)
				.WithRequired(edit => edit.Post)
				.HasForeignKey(edit => edit.PostId);

			//----------------------------------------------------

			//	PostReports:
			HasMany(post => post.PostReports)
				.WithRequired(postReport => postReport.Post)
				.HasForeignKey(postReport => postReport.PostId);

			//----------------------------------------------------

		}
	}
}