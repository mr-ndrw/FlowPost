using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq.Expressions;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{
	/// <summary>
	///		Configuration class for Report entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class ReportConfiguration : EntityTypeConfiguration<Report>
	{
		public ReportConfiguration()
		{
			/*	Id:
			 *	Since Report entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	Content:
			Property(report => report.Content)
				.IsRequired()
				.HasMaxLength(500);

			//----------------------------------------------------

			// ModeratorReply:
			Property(report => report.ModeratorReply)
				.IsRequired()
				.HasMaxLength(500);

			//----------------------------------------------------

			//	SentDateTime:
			Property(report => report.SentDateTime)
				.IsRequired();

			//----------------------------------------------------

			//	IsResolved:
			Property(report => report.IsResolved)
				.IsRequired();

			//----------------------------------------------------

			//	ReportingUser, ReportingUserId
		    HasRequired(report => report.ReportingUser)
		        .WithMany(user => user.Reports)
                .WillCascadeOnDelete(false);


			//----------------------------------------------------

			//	ModeratorUser, ModeratorUserId
		    HasRequired(report => report.ModeratorUser)
		        .WithMany()
                .WillCascadeOnDelete(false);

			//----------------------------------------------------
		}
	}
}