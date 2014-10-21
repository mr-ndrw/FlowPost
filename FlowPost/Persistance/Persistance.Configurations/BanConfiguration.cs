using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Configurations
{
	/// <summary>
	///		Configuration class for Ban entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class BanConfiguration : EntityTypeConfiguration<Ban>
	{
		public BanConfiguration()
		{
			/*	Id:
			 *	Since Group entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	Reason:
			Property(ban => ban.Reason)
				.IsRequired()
				.HasMaxLength(500);

			//----------------------------------------------------

			//	FromDateTime, ToDateTime:
			Property(ban => ban.FromDateTime)
				.IsRequired();

			Property(ban => ban.ToDateTime)
				.IsRequired();

			//----------------------------------------------------

			//	BanishedUser:

		    HasRequired(ban => ban.BanishedUser)
		        .WithMany(user => user.Bans);

			//----------------------------------------------------

			//	IssuingModeratorUser:

		    HasRequired(ban => ban.IssuingModerator)
		        .WithMany()
                .WillCascadeOnDelete(false);

			//----------------------------------------------------
		}
	}
}