using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{	
	/// <summary>
	///		Configuration class for Post entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class PostConfiguration : EntityTypeConfiguration<Post>
	{
		public PostConfiguration()
		{
            /*  Inheritance configuration:
             */

            ToTable("Posts");

            //----------------------------------------------------
			/*	Id:
			 *	Since Message entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	User:
		    HasRequired(post => post.User)
		        .WithMany(user => user.Posts)
                .WillCascadeOnDelete(false);

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
		        .WithRequired(edit => edit.Post);

			//----------------------------------------------------

			//	PostReports:
		    HasMany(post => post.PostReports)
		        .WithRequired(postReport => postReport.ReportedPost);

		    //----------------------------------------------------

		}
	}
}