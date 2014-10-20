using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{
	/// <summary>
	///		Configuration class for PostReport entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class PostReportConfiguration : EntityTypeConfiguration<PostReport>
	{
		public PostReportConfiguration()
		{
            /*  Inheritance configuration:
             */

            ToTable("PostReports");

            //----------------------------------------------------
			/*	Id:
			 *	Since UserReport entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	ReportedPost, ReportedPostId:
		    HasRequired(postReport => postReport.ReportedPost)
		        .WithMany(post => post.PostReports)
                .WillCascadeOnDelete(false);
		}
	}
}