using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{
	/// <summary>
	///		Configuration class for Message entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class TopicConfiguration : EntityTypeConfiguration<Topic>
	{
		public TopicConfiguration()
		{
			/*	Id:
			 *	Since Message entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			/*	Category:
			 *	Relationship defined in CategoryConfiguration.
			 */ 

			//----------------------------------------------------

			//	Title:
			Property(topic => topic.Subject)
				.IsRequired()
				.HasMaxLength(200);

			//----------------------------------------------------

			//	IsSticky, IsClosed, IsHidden, IsExtraordinary:
			Property(topic => topic.IsSticky)
				.IsRequired();

			Property(topic => topic.IsClosed)
				.IsRequired();
			
			Property(topic => topic.IsHidden)
				.IsRequired();
			
			Property(topic => topic.IsExtraordinary)
				.IsRequired();

			//----------------------------------------------------

			//	LastPoster, LastPosterId:

			HasRequired(topic => topic.LastPoster)
				.WithMany(user => new List<Topic>())
				.HasForeignKey(topic => topic.LastPosterUserId);

			//----------------------------------------------------

			//	LastPosterUserName, LastPostDateTime:
			Property(topic => topic.LastPosterUserName)
				.IsRequired();

			Property(topic => topic.LastPostDateTime)
				.IsRequired();

			//----------------------------------------------------

			//	NumberOfViews, NumberOfReplies
			Property(topic => topic.NumberOfViews)
				.IsRequired();

			Property(topic => topic.NumberOfReplies)
				.IsRequired();

			//----------------------------------------------------
		}
	}
}