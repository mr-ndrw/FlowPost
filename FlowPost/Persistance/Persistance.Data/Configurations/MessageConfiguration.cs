using System.Data.Entity.ModelConfiguration;
using en.AndrewTorski.FlowPost.Logic.Entities;

namespace en.AndrewTorski.FlowPost.Persistance.Data.Configurations
{
	/// <summary>
	///		Configuration class for Message entity defining relationships between entities, column types and entity behaviours.
	/// </summary>
	public class MessageConfiguration : EntityTypeConfiguration<Message>
	{
		public MessageConfiguration()
		{
			/*	Id:
			 * Since Message entity alread contains Property called 'Id', we do not explicitly configure EF to use that Property as the Key.
			 *	By convention Any Property Containing 'Id' will be used as Primary Key by EF. 
			 */

			//----------------------------------------------------

			//	Subject:
			Property(message => message.Subject).IsRequired().HasMaxLength(100);

			//----------------------------------------------------

			//	DateTime:
			Property(message => message.DateTime).IsRequired();

			//----------------------------------------------------

			//	FromUser, FromUserId:
			HasRequired(message => message.FromUser)
				.WithMany(user => user.SentMessages)
				.HasForeignKey(message => message.FromUserId);

			//----------------------------------------------------

			//	ToUser, ToUserId:
			HasRequired(message => message.ToUser)
				.WithMany(user => user.ReceivedMessages)
				.HasForeignKey(message => message.ToUserId);

			//----------------------------------------------------

			/*	FromUserName, ToUserName:
			 *	These properties don't depend on anything and are purely functional.
			 *	During the creation of a Message entity. These will have to be updated.
			 *	They are however Required.
			 */
			Property(message => message.FromUserName).IsRequired();
			Property(message => message.ToUserName).IsRequired();

		}
	}
}